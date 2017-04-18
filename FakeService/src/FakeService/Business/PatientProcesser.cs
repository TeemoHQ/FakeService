using DataBaseTables;
using DataHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataModels.Base;
using ServiceCore;
using Newtonsoft.Json.Linq;

namespace FakeService.Business
{
    public class 门诊病人信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.patient.info";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res病人信息查询();
            try
            {
                var model = req.ToObject<req病人信息查询>();
                var info = context.病人信息.FirstOrDefault(p => p.cardNo == model.cardNo);
                if (info == null)
                {
                    res.success = false;
                    res.msg = "未找到病人信息，没有这条记录";
                }
                else
                {
                    res.success = true;
                    res.msg = "成功";
                    res.data = new List<DataModels.病人信息>();
                    res.data.Add(new DataModels.病人信息
                    {
                        accBalance = info.accBalance,
                        accountNo = info.accountNo,
                        address = info.address,
                        birthday = info.birthday,
                        cardNo = info.cardNo,
                        guardianNo = info.guardianNo,
                        idNo = info.idNo,
                        name = info.name,
                        patientId = info.patientId,
                        patientType = info.patientType,
                        phone = info.phone,
                        platformId = info.platformId,
                        sex = info.sex
                    });
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}病人信息查询:{ex.Message}";
            }
            return res;
        }
    }
    public class 门诊病人建档发卡 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.set.patient.info";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var model = req.ToObject<req病人建档发卡>();
            var res = new res病人建档发卡();
            try
            {
                if (model == null)
                {
                    res.success = false;
                    res.msg = $"建档失败:服务端序列化失败";
                    return res;
                }
                else if (string.IsNullOrEmpty(model.name))
                {
                    res.success = false;
                    res.msg = $"建档失败:名字不能为空";
                    return res;
                }
                else if (string.IsNullOrEmpty(model.cardNo))
                {
                    res.success = false;
                    res.msg = $"建档失败:卡号不能为空";
                    return res;
                }
                //else if (string.IsNullOrEmpty(model.idNo))
                //{
                //    res.success = false;
                //    res.msg = $"建档失败:身份证不能为空";
                //    return res;
                //}
                else if (string.IsNullOrEmpty(model.phone))
                {
                    res.success = false;
                    res.msg = $"建档失败:手机号码不能为空";
                    return res;
                }
                else if (context.病人信息?.FirstOrDefault(p => p.idNo == model.idNo) != null)
                {
                    res.success = false;
                    res.msg = $"建档失败:病人信息已经存在";
                    return res;
                }
                else if (context.病人信息?.FirstOrDefault(p => p.cardNo == model.cardNo) != null)
                {
                    res.success = false;
                    res.msg = $"建档失败:该卡号已经注册过，请换卡号";
                    return res;
                }
                var newInfo = new 病人信息
                {
                    patientId = "FK" + DateTime.Now.ToString("yyyyMMddhhmmss"),
                    platformId = model.operId,
                    name = model.name,
                    sex = model.sex,
                    birthday = model.birthday,
                    idNo = model.idNo,
                    cardNo = model.cardNo,
                    guardianNo = model.guardianNo,
                    address = model.address,
                    phone = model.phone,
                    patientType = model.patientType,
                    accountNo = model.accountNo,
                    accBalance = "0",
                };
                context.病人信息.Add(newInfo);
                context.SaveChanges();
                res.success = true;
                res.data = new DataModels.建档信息
                {
                    accBalance = "0",
                    patientCard = model.cardNo,
                    patientid = newInfo.patientId,
                    platformId = model.operId,
                };
                res.msg = "建档成功";
                return res;
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}病人建档发卡:{ex.Message}";
                return res;
            }
        }
    }
    public class 门诊病人基本信息修改 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.modify.patient.info";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var model = req.ToObject<req病人基本信息修改>();
            var res = new res病人基本信息修改();
            try
            {
                if (string.IsNullOrEmpty(model.name))
                {
                    res.success = false;
                    res.msg = $"病人基本信息修改失败:名字不能为空";
                    return res;
                }
                else if (string.IsNullOrEmpty(model.cardNo))
                {
                    res.success = false;
                    res.msg = $"病人基本信息修改失败:卡号不能为空";
                    return res;
                }
                else if (string.IsNullOrEmpty(model.idNo))
                {
                    res.success = false;
                    res.msg = $"病人基本信息修改失败:身份证不能为空";
                    return res;
                }
                else if (string.IsNullOrEmpty(model.phone))
                {
                    res.success = false;
                    res.msg = $"病人基本信息修改失败:手机号码不能为空";
                    return res;
                }
                var oldInfo = context.病人信息?.FirstOrDefault(p => p.idNo == model.idNo);
                if (oldInfo == null)
                {
                    res.success = false;
                    res.msg = $"病人基本信息修改失败:病人信息不存在";
                    return res;
                }
                oldInfo.platformId = model.operId;
                oldInfo.name = model.name;
                oldInfo.sex = model.sex;
                oldInfo.birthday = model.birthday;
                oldInfo.idNo = model.idNo;
                oldInfo.cardNo = model.cardNo;
                oldInfo.guardianNo = model.guardianNo;
                oldInfo.address = model.address;
                oldInfo.phone = model.phone;
                oldInfo.patientType = model.patientType;
                context.SaveChanges();
                res.success = true;
                res.msg = "病人信息修改成功";
                return res;
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}病人信息修改失败:{ex.Message}";
                return res;
            }
        }
    }
    public class 门诊病人类别查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.patient.type";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var model = req.ToObject<req病人类别>();
            var res = new res病人类别
            {
                success = false,
                msg="暂时不知此",
            };
            return res;
        }
    }
    public class 住院病人信息查询 : ProcesserBase
    {
        public override string Service
        {
            get
            {
                return "yuantu.wap.query.inhos.patient.info";
            }
        }
        public override GatewayResponse Process(JObject req, MyDBContext context)
        {
            var res = new res住院患者信息查询();
            try
            {
                var model = req.ToObject<req住院患者信息查询>();
                var info = context.住院患者信息.FirstOrDefault(p => p.patientHosId == model.patientId);
                if (info == null)
                {
                    res.success = false;
                    res.msg = "未找到病人信息，没有这条记录";
                }
                else
                {
                    res.success = true;
                    res.msg = "成功";
                    res.data = new DataModels.住院患者信息
                    {
                        accBalance = info.accBalance,
                        accountNo = info.accountNo,
                        address = info.address,
                        birthday = info.birthday,
                        cardNo = info.cardNo,
                        guardianNo = info.guardianNo,
                        idNo = info.idNo,
                        name = info.name,
                        patientType = info.patientType,
                        phone = info.phone,
                        sex = info.sex
                    };
                }
            }
            catch (Exception ex)
            {
                res.success = false;
                res.msg = $"{exMsg}住院患者信息查询:{ex.Message}";
            }
            return res;
        }
    }
}
