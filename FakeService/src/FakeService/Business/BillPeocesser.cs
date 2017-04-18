using DataBaseTables;
using DataHandler;
using DataModels;
using DataModels.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeService.Business
{
    public class 待缴费概要信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.wait.balance.bill.list";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res获取缴费概要信息
            {
                success = true,
                data = new List<缴费概要信息>(),
                msg = "查询成功"
            }; ;
            try
            {
                var model = req.ToObject<req获取缴费概要信息>();
                var infos = from p in context.缴费明细信息
                            where p.patientId == model.patientId
                                && p.status == "1"
                            select p;
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "未找到缴费概要信息，没有记录";
                    return res;
                }
                else
                {
                    foreach (var detail in infos)
                    {
                        缴费概要信息 处方 = res.data.FirstOrDefault(p => p.billNo == detail.billNo);
                        if (处方 == null)
                        {
                            处方 = new 缴费概要信息
                            {
                                billNo = detail.billNo,
                                billDate = detail.billDate,
                                billFee = "0",
                                billType = detail.billType,
                                billItem = new List<DataModels.缴费明细信息>()
                            };
                            res.data.Add(处方);
                        }
                        处方.billItem.Add(new DataModels.缴费明细信息
                        {
                            billNo = detail.billNo,
                            billDate = detail.billDate,
                            billFee = detail.billFee,
                            billSeq = detail.billSeq,
                            billType = detail.billType,
                            deptCode = detail.deptCode,
                            deptName = detail.deptName,
                            diseaseCode = detail.diseaseCode,
                            doctCode = detail.doctCode,
                            doctName = detail.doctName,
                            execDeptName = detail.execDeptName,
                            hosFeeNo = detail.hosFeeNo,
                            itemCode = detail.itemCode,
                            itemLiquid = detail.itemLiquid,
                            itemName = detail.itemName,
                            extend = null,
                            itemNo = detail.itemNo,
                            itemPrice = detail.itemPrice,
                            itemQty = detail.itemQty,
                            itemSpecs = detail.itemSpecs,
                            itemUnits = detail.itemUnits,
                            productCode = detail.productCode,
                            ybInfo = detail.ybInfo
                        });
                        处方.billFee = (double.Parse(处方.billFee) + double.Parse(detail.billFee)).ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}代缴费概要信息查询:{ex.Message}";
            }
            return res;
        }
    }

    public class 缴费预结算 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.pre.balance.bill";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res缴费预结算
            {
                success = true,
                msg = "成功"
            };
            try
            {

            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}缴费预结算:{ex.Message}";
            }
            return res;
        }
    }

    public class 缴费结算 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.balance.and.pay.bill";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res缴费结算();
            try
            {
                var model = req.ToObject<req缴费结算>();
                var infos = (from p in context.缴费明细信息
                             where p.patientId == model.patientId
                                 && p.status == "1"
                                 && p.billNo == model.billNo
                             select p).ToList();
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "未找到缴费概要信息，没有记录";
                    return res;
                }
                var receiptNo = DateTime.Now.ToString("hhmmssyyyyMMdd");
                foreach (var info in infos)
                {
                    info.status = "2";
                    //也可以根据状态直接维护缴费明细表
                    context.结算记录.Add(new DataBaseTables.结算记录
                    {
                        billNo = info.billNo,
                        itemLiquid = info.itemLiquid,
                        itemName = info.itemName,
                        itemPrice = info.itemPrice,
                        itemQty = info.itemQty,
                        itemSpecs = info.itemSpecs,
                        itemUnits = info.itemUnits,
                        billFee = info.billFee,
                        tradeTime = info.tradeTime,
                        receiptNo = receiptNo,
                        patientId=model.patientId
                    });
                }
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
                context.SaveChanges();
                res.success = true;
                res.data = new 结算结果
                {
                    testCode = "123456",
                    takeMedWin = "东三窗口",
                    receiptNo = receiptNo
                };
                res.msg = "成功";
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}缴费结算:{ex.Message}";
            }
            return res;
        }
    }

    public class 已结算概要信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.bill.balance.and.pay.summary.record";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res获取已结算记录();
            try
            {
                var model = req.ToObject<req获取已结算记录>();
                var infos = from p in context.结算记录
                            where p.patientId == model.patientId
                            select p;
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "未找到已结算概要信息，没有记录";
                    return res;
                }
                res.success = true;
                res.data = new List<已缴费概要信息>();
                res.msg = "成功";
                foreach (var detail in infos)
                {
                    已缴费概要信息 处方 = res.data.FirstOrDefault(p => p.billNo == detail.billNo);
                    if (处方 == null)
                    {
                        处方 = new 已缴费概要信息
                        {
                            billNo = detail.billNo,
                            billFee = "0",
                            billType = detail.billType,
                            billItem = new List<DataModels.结算记录>()
                        };
                        res.data.Add(处方);
                    }
                    处方.billItem.Add(new DataModels.结算记录
                    {
                        itemLiquid = detail.itemLiquid,
                        itemName = detail.itemName,
                        extend = null,
                        itemPrice = detail.itemPrice,
                        itemQty = detail.itemQty,
                        itemSpecs = detail.itemSpecs,
                        itemUnits = detail.itemUnits,
                        billFee = detail.billFee,
                        tradeTime = detail.tradeTime,
                    });
                    处方.billFee = (double.Parse(处方.billFee) + double.Parse(detail.billFee)).ToString();
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}已结算概要信息查询:{ex.Message}";
            }
            return res;
        }
    }
}
