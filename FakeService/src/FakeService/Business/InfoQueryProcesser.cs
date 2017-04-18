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
    public class 收费项目查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.cost.info";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res收费项目查询
            {
                success = true,
                msg = "成功"
            };
            try
            {
                var model = req.ToObject<req收费项目查询>();
                var infos = from p in context.收费项目信息
                            where p.itemCode.Contains(model.pinyinCode)
                            select p;
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "未找到收费项目信息，没有记录";
                    return res;
                }
                else
                {
                    res.data = new List<DataModels.收费项目信息>();
                    foreach (var info in infos)
                    {
                        res.data.Add(new DataModels.收费项目信息
                        {
                            extend = null,
                            itemCode = info.itemCode,
                            itemName = info.itemName,
                            medicalRatio = info.medicalRatio,
                            price = info.price,
                            priceUnit = info.priceUnit,
                            producer = info.producer,
                            specifications = info.specifications,
                            type = info.type
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}收费项目查询:{ex.Message}";
            }
            return res;

        }
    }

    public class 药品项目查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.medicines.info";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res药品项目查询
            {
                success = true,
                msg = "成功"
            };
            try
            {
                var model = req.ToObject<req药品项目查询>();
                var infos = from p in context.药品项目信息
                            where p.medicineCode.Contains(model.pinyinCode)
                            select p;
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "未找到药品项目信息，没有记录";
                    return res;
                }
                else
                {
                    res.data = new List<DataModels.药品项目信息>();
                    foreach (var info in infos)
                    {
                        res.data.Add(new DataModels.药品项目信息
                        {
                            extend = null,
                            medicalRatio = info.medicalRatio,
                            price = info.price,
                            priceUnit = info.priceUnit,
                            producer = info.producer,
                            specifications = info.specifications,
                            type = info.type,
                            medicineCode = info.medicineCode,
                            medicineName = info.medicineName,
                            miniUnit = info.miniUnit,
                            packagingUnit = info.packagingUnit
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}药品项目查询:{ex.Message}";
            }
            return res;

        }
    }

    public class 住院患者费用明细查询 : ProcesserBase //一日清单
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.inhos.bill";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res住院患者费用明细查询();
            try
            {
                var model = req.ToObject<req住院患者费用明细查询>();
                var infos = from p in context.住院患者费用明细
                            where p.patientHosId == model.patientHosId
                            select p;
                if (infos == null || infos.Count() <= 0)
                {
                    res.success = false;
                    res.msg = "未找到已结算概要信息，没有记录";
                    return res;
                }
                res.success = true;
                res.data = new List<DataModels.住院患者费用明细>();
                res.msg = "成功";
                foreach (var detail in infos)
                {
                    res.data.Add(new DataModels.住院患者费用明细
                    {
                        cost = detail.cost,
                        deptName = detail.deptName,
                        extend = null,
                        itemLiquid = detail.itemLiquid,
                        itemName = detail.itemName,
                        itemPrice = detail.itemPrice,
                        itemQty = detail.itemQty,
                        itemSpecs = detail.itemSpecs,
                        itemUnits = detail.itemUnits,
                        ratio = detail.itemUnits,
                        tradeTime = detail.tradeTime,
                        visited = detail.visited
                    });
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}住院患者费用明细查询:{ex.Message}";
            }
            return res;
        }
    }
}
