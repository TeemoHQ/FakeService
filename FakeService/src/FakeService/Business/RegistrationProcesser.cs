using DataBaseTables;
using DataHandler;
using DataModels.Base;
using Newtonsoft.Json.Linq;
using ServiceCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeService.Business
{
    public class 科室信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.registration.dep.list";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res排班科室信息查询();
            try
            {
                var model = req.ToObject<req排班科室信息查询>();
                var list = from p in context.科室信息
                           where  p.regType == model.regType //p.regMode == model.regMode &&
                           select p;
                if (list == null || list.Count() == 0)
                {
                    res.success = false;
                    res.msg = "无科室信息";
                    return res;
                }
                else
                {
                    res.success = true;
                    res.data = new List<DataModels.排班科室信息>();
                    foreach (var temp in list)
                    {
                        res.data.Add(new DataModels.排班科室信息
                        {
                            deptCode = temp.deptCode,
                            deptName = temp.deptName,
                            parentDeptCode = temp.parentDeptCode,
                            parentDeptName = temp.parentDeptName,
                            simplePy = temp.simplePy,
                            fullPy = temp.fullPy,
                            deptIntro = temp.deptIntro
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}排班科室信息查询失败：{ex.Message}";
            }
            return res;
        }
    }
    public class 医生信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.hospital.all.doc";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res查询所有医生信息();
            try
            {
                var model = req.ToObject<req医生信息查询>();
                var list = from p in context.医生介绍
                           where p.deptCode == model.deptCode
                           select p;
                if (list == null || list.Count() == 0)
                {
                    res.success = false;
                    res.msg = "无医生信息";
                    return res;
                }
                else
                {
                    res.success = true;
                    res.data = new List<DataModels.医生介绍>();
                    foreach (var temp in list)
                    {
                        res.data.Add(new DataModels.医生介绍
                        {
                            deptCode = temp.deptCode,
                            deptName = temp.deptName,
                            doctCode = temp.doctCode,
                            doctIntro = temp.doctIntro,
                            doctName = temp.doctName,
                            doctProfe = temp.doctProfe,
                            doctSpec = temp.doctSpec,
                            sex = temp.sex,
                            corpCode = temp.corpCode,
                            doctSimplePY = temp.doctSimplePY,
                            doctLevel = temp.doctLevel,
                            doctLogo = temp.doctLogo,
                            doctPhoneNum = temp.doctPhoneNum,
                            doctPictureIntranetUrl = temp.doctPictureIntranetUrl,
                            doctPY = temp.doctPY
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}查询所有医生信息失败：{ex.Message}";
            }
            return res;
        }
    }
    public class 排班信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.registration.schedule.info.list";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res排班信息查询();
            try
            {
                var model = req.ToObject<req排班信息查询>();
                //挂号类型1预约 2挂号
                var list = (from p in context.排班信息
                            where p.deptCode == model.deptCode
                            && p.regType == model.regType
                            && DateTime.Parse(model.startDate).Date == (DateTime.Parse(p.medDate).Date)
                            select p).ToList(); //如果不转换成list，那么There is already an open DataReader associated with this Connection which must be closed first
                if (list == null || list.Count() == 0)
                {
                    res.success = false;
                    res.msg = "无排班信息";
                    return res;
                }
                else
                {
                    res.success = true;
                    foreach (var temp in list)
                    {
                        var restnum = model.regMode == "2" ? context.号源明细.Where(p => p.scheduleId == temp.scheduleId && p.isEnable == "1"
                        && DateTime.Parse(model.startDate).Date == DateTime.Parse(p.medBegtime).Date
                        && DateTime.Compare(DateTime.Parse(model.startDate), DateTime.Parse(p.medBegtime)) > 0).Count()
                        : context.号源明细.Where(p => p.scheduleId == temp.scheduleId && p.isEnable == "1"
                        && DateTime.Parse(model.startDate).Date == DateTime.Parse(p.medBegtime).Date).Count();
                        res.data = new List<DataModels.排班信息>();
                        res.data.Add(new DataModels.排班信息
                        {
                            deptCode = temp.deptCode,
                            deptName = temp.deptName,
                            doctCode = temp.doctCode,
                            doctName = temp.doctName,
                            doctTech = temp.doctTech,
                            hosRegType = temp.hosRegType,
                            medAmPm = temp.medAmPm,
                            medDate = temp.medDate,
                            parentDeptCode = temp.parentDeptCode,
                            parentDeptName = temp.parentDeptName,
                            regAmount = temp.regAmount,
                            regfee = temp.regfee,
                            regMode = temp.regMode,
                            regType = temp.regType,
                            restnum = restnum.ToString(),
                            scheduleId = temp.scheduleId,
                            treatfee = temp.treatfee
                        });
                    }
                }

            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}排班信息查询失败：{ex.Message}";
            }
            return res;
        }
    }
    public class 号源信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.registration.sources";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res号源明细查询();
            try
            {
                var model = req.ToObject<req号源明细查询>();
                var list = from p in context.号源明细
                           where p.scheduleId == model.scheduleId
                                 && p.isEnable == "1"
                                 && DateTime.Parse(model.medDate).Date == (DateTime.Parse(p.medBegtime).Date)
                           select p;
                if (list == null || list.Count() == 0)
                {
                    res.success = false;
                    res.msg = "无号源明细信息";
                    return res;
                }
                else
                {
                    res.success = true;
                    res.data = new List<DataModels.号源明细>();
                    foreach (var temp in list)
                    {
                        res.data.Add(new DataModels.号源明细
                        {
                            appoNo = temp.appoNo,
                            medBegtime = temp.medBegtime,
                            medEndtime = temp.medEndtime,
                            //restNum = temp.restNum//号源的restNum无用
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}号源明细查询失败：{ex.Message}";
            }
            return res;
        }
    }
    public class 预约挂号 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.appointment.or.registration";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res预约挂号();
            try
            {
                var model = req.ToObject<req预约挂号>();
                号源明细 registration号源 = context.号源明细.FirstOrDefault(p => p.scheduleId == model.scheduleId);
                if (string.IsNullOrEmpty(model.scheduleId))
                {
                    res.success = false;
                    res.msg = $"排班ID不能为空";
                    return res;
                }
                if (model.regMode == "1")
                {
                    if (string.IsNullOrEmpty(model.appoNo))
                    {
                        res.success = false;
                        res.msg = $"号源No不能为空";
                        return res;
                    }
                    var app = context.号源明细.FirstOrDefault(p => p.appoNo == model.appoNo);
                    if (app != null)
                    {
                        app.isEnable = "0";
                    }
                }
                else
                {
                    if (registration号源 == null)
                    {
                        res.success = false;
                        res.msg = $"号源已经挂完";
                        return res;
                    }
                    TimeSpan flag = new TimeSpan(24, 0, 0);
                    foreach (var item in context.号源明细.Where(p => p.scheduleId == model.scheduleId && p.isEnable == "1"))
                    {
                        if (DateTime.Parse(item.medBegtime) > DateTime.Now
                            && (DateTime.Parse(item.medBegtime) - DateTime.Now < flag))
                        {
                            registration号源 = item;
                            flag = DateTime.Parse(item.medBegtime) - DateTime.Now;
                        }
                    }
                    context.号源明细.FirstOrDefault(p => p.appoNo == registration号源.appoNo).isEnable = "0";
                    if (model.tradeMode == "OC")
                    {
                        var balance = context.病人信息.FirstOrDefault(p => p.patientId == model.patientId).accBalance;
                        if ((double.Parse(balance) - double.Parse(model.cash)) < 0)
                        {
                            res.success = false;
                            res.msg = $"余额不足";
                            return res;
                        }
                        context.病人信息.FirstOrDefault(p => p.patientId == model.patientId).accBalance = (double.Parse(balance) - (double.Parse(model.cash))).ToString();
                    }
                }

                var newData = new 挂号预约记录
                {
                    regNo = DateTimeCore.Now.ToString("yyyyMMddhhmmss"),
                    appoNo = model.regMode == "1" ? model.appoNo : registration号源.appoNo,
                    scheduleId = model.scheduleId,
                    patientId = model.patientId,
                    tradeTime = model.tradeTime,
                    medDate = model.regMode == "1" ? model.medDate : DateTime.Parse(registration号源.medBegtime).Date.ToString(),
                    medTime = model.regMode == "1" ? model.medTime : DateTime.Parse(registration号源.medBegtime).ToString("hh:mm:ss"),
                    medAmPm = model.regMode == "1" ? model.medAmPm : DateTimeCore.Now.Hour <= 12 ? "1" : "2",
                    hospCode = model.hospCode,
                    hospName = null,
                    deptName = model.deptName,
                    doctName = model.doctName,
                    address = null,
                    appoFrom = null,
                    regFee = model.cash,
                    treatFee = null,
                    regAmount = model.cash,
                    status = model.regMode == "1" ? "0" : "1",//0 已预约,1 已挂号,2 已取消,3 已过期,4 已停诊,5 已退号
                    orderNo = null,
                    doctCode = model.doctCode,
                    deptCode = model.deptCode,
                    payStatus = model.regMode == "1" ? "100" : "200",
                    lockId = model.lockId
                };
                context.挂号预约记录.Add(newData);
                context.SaveChanges();
                res.success = true;
                res.data = new DataModels.挂号结果
                {
                    address = "二楼202",
                    appoNo = model.regMode == "1" ? model.appoNo : registration号源.appoNo,
                    deptName = model.deptName,
                    doctName = model.doctCode,
                    regFee = model.cash,
                    treatFee = null,
                    regAmount = model.cash,
                    orderNo = null,
                    medDate = model.medDate,
                };
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}预约挂号失败：{ex.Message}";
            }
            return res;
        }
    }
}
