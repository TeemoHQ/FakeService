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
    public class TakeNumProcesser
    {
        public class 号源信息查询 : ProcesserBase
        {
            public override string Service
            {
                get
                {
                    return "yuantu.wap.query.appointment.and.registration.record";
                }
            }
            public override GatewayResponse Process(JObject req, DBContext context)
            {
                var res = new res挂号预约记录查询();
                try
                {
                    var model = req.ToObject<req挂号预约记录查询>();
                    var list = from p in context.挂号预约记录
                               where p.patientId == model.patientId
                                     && DateTime.Parse(p.medDate).Date == DateTime.Now.Date
                                     && p.status == "0"//0 已预约,1 已挂号,2 已取消,3 已过期,4 已停诊,5 已退号
                               select p;
                    if (list == null || list.Count() == 0)
                    {
                        res.success = false;
                        res.msg = "当日无预约记录";
                        return res;
                    }
                    else
                    {
                        res.success = true;
                        res.data = new List<DataModels.挂号预约记录>();
                        foreach (var temp in list)
                        {
                            res.data.Add(new DataModels.挂号预约记录
                            {
                                tradeTime = temp.tradeTime,
                                medDate = temp.medDate,
                                medTime = temp.medTime,
                                deptName = temp.deptName,
                                deptCode = temp.deptCode,
                                doctName = temp.doctName,
                                doctCode = temp.doctCode,
                                appoNo = temp.appoNo,
                                regNo = temp.regNo,
                                scheduleId = temp.scheduleId,
                                medAmPm = temp.medAmPm,
                                status = temp.status,
                                regAmount = temp.regAmount,
                                address = temp.address,
                                appoFrom = temp.appoFrom,
                                doctTech = temp.doctTech,
                                hospCode = temp.hospCode,
                                hospName = temp.hospName,
                                orderNo = temp.orderNo,
                                treatFee = temp.treatFee,
                                payStatus = temp.payStatus,
                                regFee = temp.regFee
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

        public class 预约取号 : ProcesserBase
        {
            public override string Service
            {
                get
                {
                    return "yuantu.wap.take.registration.no";
                }
            }

            public override GatewayResponse Process(JObject req, DBContext context)
            {
                var res = new res预约取号();
                try
                {
                    var model = req.ToObject<req预约取号>();
                    var 记录 = context.挂号预约记录.FirstOrDefault(p => p.appoNo == model.appoNo && p.status == "0");
                    if (记录 == null)
                    {
                        res.success = false;
                        res.msg = "无预约记录";
                        return res;
                    }
                    else
                    {
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
                        记录.status = "2";
                        context.SaveChanges();
                        res.success = true;
                        res.data = new DataModels.取号结果
                        {
                            medDate = 记录.medDate,
                            deptName = 记录.deptName,
                            doctName = 记录.doctName,
                            appoNo = 记录.appoNo,
                            address = "二楼202",
                            treatFee = 记录.treatFee,
                            regFee = 记录.regFee,
                        };
                        res.msg = "预约取号成功";
                    }
                }
                catch (Exception ex)
                {
                    res.success = false;
                    res.msg = $"{exMsg}预约取号失败：{ex.Message}";
                }
                return res;
            }
        }
        /// 1预约成功 2取号成功 3取消成功 4已过期
        public class 取消预约 : ProcesserBase
        {
            public override string Service
            {
                get
                {
                    return "yuantu.wap.cancel.appointment.or.registration";
                }
            }

            public override GatewayResponse Process(JObject req, DBContext context)
            {
                var res = new res取消预约();
                try
                {
                    var model = req.ToObject<req取消预约>();
                    var 记录 = context.挂号预约记录.FirstOrDefault(p => p.appoNo == model.appoNo && p.status == "0");
                    if (记录 == null)
                    {
                        res.success = false;
                        res.msg = "无预约记录";
                        return res;
                    }
                    else
                    {
                        记录.status = "3";
                        context.SaveChanges();
                        res.success = true;
                        res.data = null;
                        res.msg = "预约取消成功";

                    }
                }
                catch (Exception ex)
                {
                    res.success = false;
                    res.msg = $"{exMsg}预约取消失败：{ex.Message}";
                }
                return res;
            }
        }
    }
}
