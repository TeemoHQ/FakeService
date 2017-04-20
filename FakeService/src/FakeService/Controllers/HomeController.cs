using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataBaseTables;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using FakeService.Models.Response;
using System.Threading;
using FakeService.Models.Request;
using FakeService.Models;
using ServiceCore;

namespace FakeService.Controllers
{
    public class HomeController : BaseController
    {
        public HomeController(MyDBContext context) : base(context)
        {
        }

        public IActionResult Index()
        {
            ViewData["Hos"] = _context.医院信息.ToList();
            ViewData["Type"] = _context.科室类别.ToList();
            ViewData["Date"] = new List<string>()
            {
                DateTimeCore.Now.ToString("MM月dd日"),
                DateTimeCore.Now.AddDays(1).ToString("MM月dd日"),
                DateTimeCore.Now.AddDays(3).ToString("MM月dd日"),
                DateTimeCore.Now.AddDays(4).ToString("MM月dd日"),
                DateTimeCore.Now.AddDays(5).ToString("MM月dd日"),
                DateTimeCore.Now.AddDays(6).ToString("MM月dd日"),
                DateTimeCore.Now.AddDays(7).ToString("MM月dd日"),
            };
            return View();
        }
        public List<科室信息> GetDepts(JObject data)
        {
            var model = Request.Form["requestInstitution"].ToString();
            var req = JsonConvert.DeserializeObject<DeptRequest>(model);
            return _context.科室信息.Where(p => p.regType == req.TypeId).ToList();
        }
        public List<医生介绍> GetDoctors(JObject data)
        {
            var model = Request.Form["requestInstitution"].ToString();
            var req = JsonConvert.DeserializeObject<DoctorRequest>(model);
            return _context.医生介绍.Where(p => p.deptCode == req.DeptId).ToList();
        }
        public string AddSchedul(JObject data)
        {
            var res = new SchedulResponse
            {
                success = true
            };
            try
            {
                var model = Request.Form["requestInstitution"].ToString();
                var req = JsonConvert.DeserializeObject<SchedulRequest>(model);
                var dept = _context.科室信息.FirstOrDefault(p => p.deptCode == req.DeptId);
                var doctor = _context.医生介绍.FirstOrDefault(p => p.doctCode == req.DoctorId);
                var scheduleId = DateTimeCore.Now.ToString("yyyyMMddhhmmss");
                var date = DateTime.Parse(req.Date);
                var schedule = new 排班信息
                {
                    hospitalId = req.HosId,
                    regType = req.TypeId,
                    deptCode = req.DeptId,
                    deptName = dept?.deptName,
                    doctCode = req.DoctorId,
                    doctName = doctor?.doctName,
                    doctTech = doctor.doctIntro,
                    hosRegType = req.TypeId,
                    medDate = date.ToString("yyyy-MM-dd"),
                    medAmPm = req.AMPMId,
                    parentDeptCode = dept.parentDeptCode,
                    parentDeptName = dept.parentDeptName,
                    scheduleId = scheduleId,
                    regAmount = "1000",
                };
                _context.排班信息.Add(schedule);
                var resource = new 号源明细
                {
                    hospitalId = req.HosId,
                    isEnable = "1",
                    scheduleId = scheduleId,
                };

                if (req.AMPMId == "1")//全天
                {
                    var smallerTime = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
                    var BigerstTime = new DateTime(date.Year, date.Month, date.Day, 23, 0, 0);
                    while (DateTime.Compare(BigerstTime, smallerTime) > 0)
                    {
                        resource.appoNo = Guid.NewGuid().ToString();
                        resource.medBegtime = smallerTime.ToString("yyyy-MM-dd HH:mm:ss");
                        resource.medEndtime = smallerTime.AddMinutes(30).ToString("yyyy-MM-dd HH:mm:ss");
                        _context.号源明细.Add(resource);
                        smallerTime = smallerTime.AddMinutes(30);
                        _context.SaveChanges();
                    }
                }
                else if (req.AMPMId == "2")//上午
                {
                    var smallerTime = new DateTime(date.Year, date.Month, date.Day, 8, 0, 0);
                    var BigerstTime = new DateTime(date.Year, date.Month, date.Day, 11, 30, 0);
                    while (DateTime.Compare(BigerstTime, smallerTime) > 0)
                    {
                        resource.appoNo = Guid.NewGuid().ToString();
                        resource.medBegtime = smallerTime.ToString("yyyy-MM-dd HH:mm:ss");
                        resource.medEndtime = smallerTime.AddMinutes(30).ToString("yyyy-MM-dd HH:mm:ss");
                        _context.号源明细.Add(resource);
                        smallerTime = smallerTime.AddMinutes(30);
                        _context.SaveChanges();
                    }
                }
                else
                {
                    var smallerTime = new DateTime(date.Year, date.Month, date.Day, 13, 0, 0);
                    var BigerstTime = new DateTime(date.Year, date.Month, date.Day, 17, 30, 0);
                    while (DateTime.Compare(BigerstTime, smallerTime) > 0)
                    {
                        resource.appoNo = Guid.NewGuid().ToString();
                        resource.medBegtime = smallerTime.ToString("yyyy-MM-dd HH:mm:ss");
                        resource.medEndtime = smallerTime.AddMinutes(30).ToString("yyyy-MM-dd HH:mm:ss");
                        _context.号源明细.Add(resource);
                        smallerTime = smallerTime.AddMinutes(30);
                        _context.SaveChanges();
                    }
                }
                _context.SaveChanges();
            }
            catch (Exception e)
            {
                res.success = false;
                res.msg = $"服务端异常:{e.Message}";
                throw;
            }

            return JsonConvert.SerializeObject(res);
        }
        public string Delete(JObject data)
        {
            var res = new SchedulResponse
            {
                success = true
            };
            var model = Request.Form["requestInstitution"].ToString();
            var req = JsonConvert.DeserializeObject<DeleteRequest>(model);
            var schedules = _context.排班信息.Where(p => p.hospitalId == req.HosId);
            foreach (var item in schedules)
            {
                _context.排班信息.Remove(item);
            }
            var resources = _context.号源明细.Where(p => p.hospitalId == req.HosId);
            foreach (var item in resources)
            {
                _context.号源明细.Remove(item);
            }
            _context.SaveChanges();
            return JsonConvert.SerializeObject(res);
        }
        public string AddBill(JObject data)
        {
            var res = new SchedulResponse
            {
                success = true
            };
            var model = Request.Form["requestInstitution"].ToString();
            var req = JsonConvert.DeserializeObject<AddBillRequest>(model);
            var patient = _context.病人信息.FirstOrDefault(p => p.hospitalId == req.HosId && p.patientId == req.PatientId);
            if (patient == null)
            {
                res.success = false;
                res.msg = "病人信息不存在";
                return JsonConvert.SerializeObject(res);
            }
            var lists = new List<缴费明细信息>
            {
                new 缴费明细信息
                {
                    billDate = DateTimeCore.Now.ToString(),
                    billFee = "8000",
                    billNo = "111111",
                    billType = "非药品",
                    deptCode = "1",
                    deptName = "感染科室",
                    doctCode = null,
                    doctName = null,
                    hospitalId = req.HosId,
                    itemNo = "1",
                    productCode = "FK11111",
                    itemName = "17α羟孕酮测定",
                    itemUnits = "项",
                    itemQty = "1",
                    itemPrice = "8000",
                    status="1",
                    patientId=req.PatientId
                },
                new 缴费明细信息
                {
                    billDate = DateTimeCore.Now.ToString(),
                    billFee = "8000",
                    billNo = "111111",
                    billType = "非药品",
                    deptCode = "1",
                    deptName = "感染科室",
                    doctCode = null,
                    doctName = null,
                     hospitalId = req.HosId,
                    itemNo = "1",
                    productCode = "FK11111",
                    itemName = "17α羟孕酮测定",
                    itemUnits = "项",
                    itemQty = "1",
                    itemPrice = "8000",
                    status="1",
                    patientId=req.PatientId
                },
                new 缴费明细信息
                {
                    billDate = DateTimeCore.Now.ToString(),
                    billFee = "5500",
                    billNo = "22222",
                    billType = "非药品",
                    deptCode = "1",
                    deptName = "感染科室",
                    doctCode = null,
                    doctName = null,
                    hospitalId = req.HosId,
                    itemNo = "1",
                    productCode = "FK2222",
                    itemName = "酮胎菊鉴定",
                    itemUnits = "项",
                    itemQty = "1",
                    itemPrice = "5500",
                    status="1",
                    patientId=req.PatientId
                }
            };
            lists.ForEach((p) =>
            {
                _context.缴费明细信息.Add(p);
                _context.SaveChanges();
            });
            return JsonConvert.SerializeObject(res);
        }
    }
}
