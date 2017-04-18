using DataBaseTables;
using DataHandler;
using DataModels.Base;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeService.Business
{
    public class 门诊预缴金充值 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.recharge.virtual.settlement";
            }
        }
        public override GatewayResponse Process(JObject req, DBContext context)
        {
            var res = new res预缴金充值
            {
                success = true,
                msg = "成功"
            };
            try
            {
                var model = req.ToObject<req预缴金充值>();
                var patient = context.病人信息.FirstOrDefault(p => p.patientId == model.patientId);
                if (patient == null)
                {
                    res.success = false;
                    res.msg = "无此病人信息";
                    return res;
                }
                patient.accBalance = (double.Parse(patient.accBalance) + double.Parse(model.cash)).ToString();
                context.充值记录.Add(new 充值记录
                {
                    cash = model.cash,
                    cardNo = patient.cardNo,
                    accountNo = model.accountNo,
                    No = DateTime.Now.ToString("MMddmmsshh"),
                    operId = model.operId,
                    optType = null,
                    patientId = model.patientId,
                    receiptNo = DateTime.Now.ToString("hhmmssyyyyMMdd"),
                    tradeMode = model.tradeMode,
                    tradeTime = model.tradeTime
                });
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}门诊预缴金充值:{ex.Message}";
            }
            return res;

        }
    }
    public class 门诊预缴金充值记录查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.patient.vs.record";
            }
        }
        public override GatewayResponse Process(JObject req, DBContext context)
        {
            var res = new res查询预缴金充值记录
            {
                success = true,
                msg = "成功"
            };
            try
            {
                var model = req.ToObject<req查询预缴金充值记录>();
                var infos = from p in context.充值记录
                            where p.cardNo == model.cardNo
                            select p;
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "无充值记录";
                    return res;
                }
                res.data = new List<DataModels.充值记录>();
                foreach (var info in infos)
                {
                    res.data.Add(new DataModels.充值记录
                    {
                        cash = info.cash,
                        accountNo = info.accountNo,
                        operId = info.operId,
                        optType = null,
                        receiptNo = info.receiptNo,
                        tradeMode = info.tradeMode,
                        tradeTime = info.tradeTime
                    });
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}查询预缴金充值记录:{ex.Message}";
            }
            return res;

        }
    }
    public class 住院预缴金充值 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.recharge.inhos.virtual.settlement";
            }
        }
        public override GatewayResponse Process(JObject req, DBContext context)
        {
            var res = new res住院预缴金充值
            {
                success = true,
                msg = "成功"
            };
            try
            {
                var model = req.ToObject<req住院预缴金充值>();
                var patient = context.住院患者信息.FirstOrDefault(p => p.cardNo == model.cardNo);
                if (patient == null)
                {
                    res.success = false;
                    res.msg = "无此病人信息";
                    return res;
                }
                patient.accBalance = (double.Parse(patient.accBalance) + double.Parse(model.cash) / 100).ToString();
                context.住院充值记录.Add(new 住院充值记录
                {
                    cash = model.cash,
                    operId = model.operId,
                    receiptNo = DateTime.Now.ToString("hhmmssyyyyMMdd"),
                    tradeMode = model.tradeMode,
                    tradeTime = model.tradeTime,
                    payerName = model.payerName,
                    visitId = null
                });
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}住院预缴金充值:{ex.Message}";
            }
            return res;

        }
    }
    public class 住院预缴金充值记录查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.inhos.rechare.record";
            }
        }
        public override GatewayResponse Process(JObject req, DBContext context)
        {
            var res = new res住院预缴金充值记录查询
            {
                success = true,
                msg = "成功"
            };
            try
            {
                var model = req.ToObject<req住院预缴金充值记录查询>();
                var infos = from p in context.住院充值记录
                            where p.cardNo == model.cardNo
                            select p;
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "无住院充值记录";
                    return res;
                }
                res.data = new List<DataModels.住院充值记录>();
                foreach (var info in infos)
                {
                    res.data.Add(new DataModels.住院充值记录
                    {
                        cash = info.cash,
                        operId = info.operId,
                        receiptNo = info.receiptNo,
                        tradeMode = info.tradeMode,
                        tradeTime = info.tradeTime,
                        visitId = info.visitId,
                        payerName = info.payerName
                    });
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}查询住院预缴金充值记录:{ex.Message}";
            }
            return res;

        }
    }
}
