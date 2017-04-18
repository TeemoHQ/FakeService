using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using DataModels.Base;
using DataModels;

namespace DataHandler
{
    public partial class DataHandlerEx
    {
        public static IDataHandler Handler{get;set;}
        public static res病人信息查询 病人信息查询(req病人信息查询 req)
        {
            return Handler.Query<res病人信息查询, req病人信息查询>(req);
        }

        public static res病人建档发卡 病人建档发卡(req病人建档发卡 req)
        {
            return Handler.Query<res病人建档发卡, req病人建档发卡>(req);
        }

        public static res病人基本信息修改 病人基本信息修改(req病人基本信息修改 req)
        {
            return Handler.Query<res病人基本信息修改, req病人基本信息修改>(req);
        }

        public static res病人类别 病人类别(req病人类别 req)
        {
            return Handler.Query<res病人类别, req病人类别>(req);
        }

        public static res医保科室 医保科室(req医保科室 req)
        {
            return Handler.Query<res医保科室, req医保科室>(req);
        }

        public static res病人领卡查询 病人领卡查询(req病人领卡查询 req)
        {
            return Handler.Query<res病人领卡查询, req病人领卡查询>(req);
        }

        public static res诊疗卡账户修改密码 诊疗卡账户修改密码(req诊疗卡账户修改密码 req)
        {
            return Handler.Query<res诊疗卡账户修改密码, req诊疗卡账户修改密码>(req);
        }

        public static res诊疗卡密码校验 诊疗卡密码校验(req诊疗卡密码校验 req)
        {
            return Handler.Query<res诊疗卡密码校验, req诊疗卡密码校验>(req);
        }

        public static res对账 对账(req对账 req)
        {
            return Handler.Query<res对账, req对账>(req);
        }

        public static res自助绑定银行卡 自助绑定银行卡(req自助绑定银行卡 req)
        {
            return Handler.Query<res自助绑定银行卡, req自助绑定银行卡>(req);
        }

        public static res自助绑定银行卡解绑 自助绑定银行卡解绑(req自助绑定银行卡解绑 req)
        {
            return Handler.Query<res自助绑定银行卡解绑, req自助绑定银行卡解绑>(req);
        }

        public static res排班科室信息查询 排班科室信息查询(req排班科室信息查询 req)
        {
            return Handler.Query<res排班科室信息查询, req排班科室信息查询>(req);
        }

        public static res排班信息查询 排班信息查询(req排班信息查询 req)
        {
            return Handler.Query<res排班信息查询, req排班信息查询>(req);
        }

        public static res号源明细查询 号源明细查询(req号源明细查询 req)
        {
            return Handler.Query<res号源明细查询, req号源明细查询>(req);
        }

        public static res预约挂号预处理 预约挂号预处理(req预约挂号预处理 req)
        {
            return Handler.Query<res预约挂号预处理, req预约挂号预处理>(req);
        }

        public static res挂号锁号 挂号锁号(req挂号锁号 req)
        {
            return Handler.Query<res挂号锁号, req挂号锁号>(req);
        }

        public static res挂号解锁 挂号解锁(req挂号解锁 req)
        {
            return Handler.Query<res挂号解锁, req挂号解锁>(req);
        }

        public static res预约挂号 预约挂号(req预约挂号 req)
        {
            return Handler.Query<res预约挂号, req预约挂号>(req);
        }

        public static res预约取号 预约取号(req预约取号 req)
        {
            return Handler.Query<res预约取号, req预约取号>(req);
        }

        public static res取消预约 取消预约(req取消预约 req)
        {
            return Handler.Query<res取消预约, req取消预约>(req);
        }

        public static res挂号预约记录查询 挂号预约记录查询(req挂号预约记录查询 req)
        {
            return Handler.Query<res挂号预约记录查询, req挂号预约记录查询>(req);
        }

        public static res获取缴费概要信息 获取缴费概要信息(req获取缴费概要信息 req)
        {
            return Handler.Query<res获取缴费概要信息, req获取缴费概要信息>(req);
        }

        public static res获取缴费明细信息 获取缴费明细信息(req获取缴费明细信息 req)
        {
            return Handler.Query<res获取缴费明细信息, req获取缴费明细信息>(req);
        }

        public static res缴费预结算 缴费预结算(req缴费预结算 req)
        {
            return Handler.Query<res缴费预结算, req缴费预结算>(req);
        }

        public static res缴费结算 缴费结算(req缴费结算 req)
        {
            return Handler.Query<res缴费结算, req缴费结算>(req);
        }

        public static res获取已结算记录 获取已结算记录(req获取已结算记录 req)
        {
            return Handler.Query<res获取已结算记录, req获取已结算记录>(req);
        }

        public static res获取已结算明细记录 获取已结算明细记录(req获取已结算明细记录 req)
        {
            return Handler.Query<res获取已结算明细记录, req获取已结算明细记录>(req);
        }

        public static res虚拟账户开通 虚拟账户开通(req虚拟账户开通 req)
        {
            return Handler.Query<res虚拟账户开通, req虚拟账户开通>(req);
        }

        public static res预缴金充值 预缴金充值(req预缴金充值 req)
        {
            return Handler.Query<res预缴金充值, req预缴金充值>(req);
        }

        public static res充值数据同步到his系统 充值数据同步到his系统(req充值数据同步到his系统 req)
        {
            return Handler.Query<res充值数据同步到his系统, req充值数据同步到his系统>(req);
        }

        public static res预约挂号记录同步到his系统 预约挂号记录同步到his系统(req预约挂号记录同步到his系统 req)
        {
            return Handler.Query<res预约挂号记录同步到his系统, req预约挂号记录同步到his系统>(req);
        }

        public static res交易记录同步到his系统 交易记录同步到his系统(req交易记录同步到his系统 req)
        {
            return Handler.Query<res交易记录同步到his系统, req交易记录同步到his系统>(req);
        }

        public static res查询预缴金充值记录 查询预缴金充值记录(req查询预缴金充值记录 req)
        {
            return Handler.Query<res查询预缴金充值记录, req查询预缴金充值记录>(req);
        }

        public static res查询预缴金账户余额 查询预缴金账户余额(req查询预缴金账户余额 req)
        {
            return Handler.Query<res查询预缴金账户余额, req查询预缴金账户余额>(req);
        }

        public static res预缴金消费 预缴金消费(req预缴金消费 req)
        {
            return Handler.Query<res预缴金消费, req预缴金消费>(req);
        }

        public static res预缴金消费冲正 预缴金消费冲正(req预缴金消费冲正 req)
        {
            return Handler.Query<res预缴金消费冲正, req预缴金消费冲正>(req);
        }

        public static res住院患者信息查询 住院患者信息查询(req住院患者信息查询 req)
        {
            return Handler.Query<res住院患者信息查询, req住院患者信息查询>(req);
        }

        public static res住院患者费用明细查询 住院患者费用明细查询(req住院患者费用明细查询 req)
        {
            return Handler.Query<res住院患者费用明细查询, req住院患者费用明细查询>(req);
        }

        public static res住院患者费用明细打印 住院患者费用明细打印(req住院患者费用明细打印 req)
        {
            return Handler.Query<res住院患者费用明细打印, req住院患者费用明细打印>(req);
        }

        public static res住院预缴金充值 住院预缴金充值(req住院预缴金充值 req)
        {
            return Handler.Query<res住院预缴金充值, req住院预缴金充值>(req);
        }

        public static res住院预缴金充值记录查询 住院预缴金充值记录查询(req住院预缴金充值记录查询 req)
        {
            return Handler.Query<res住院预缴金充值记录查询, req住院预缴金充值记录查询>(req);
        }

        public static res检查病人是否能自助机结算 检查病人是否能自助机结算(req检查病人是否能自助机结算 req)
        {
            return Handler.Query<res检查病人是否能自助机结算, req检查病人是否能自助机结算>(req);
        }

        public static res自助出院预结算 自助出院预结算(req自助出院预结算 req)
        {
            return Handler.Query<res自助出院预结算, req自助出院预结算>(req);
        }

        public static res自助出院结算 自助出院结算(req自助出院结算 req)
        {
            return Handler.Query<res自助出院结算, req自助出院结算>(req);
        }

        public static res住院床位信息查询 住院床位信息查询(req住院床位信息查询 req)
        {
            return Handler.Query<res住院床位信息查询, req住院床位信息查询>(req);
        }

        public static res检验基本信息查询 检验基本信息查询(req检验基本信息查询 req)
        {
            return Handler.Query<res检验基本信息查询, req检验基本信息查询>(req);
        }

        public static res检查结果查询 检查结果查询(req检查结果查询 req)
        {
            return Handler.Query<res检查结果查询, req检查结果查询>(req);
        }

        public static res影像诊断结果查询 影像诊断结果查询(req影像诊断结果查询 req)
        {
            return Handler.Query<res影像诊断结果查询, req影像诊断结果查询>(req);
        }

        public static res医生信息查询 医生信息查询(req医生信息查询 req)
        {
            return Handler.Query<res医生信息查询, req医生信息查询>(req);
        }

        public static res科室信息查询 科室信息查询(req科室信息查询 req)
        {
            return Handler.Query<res科室信息查询, req科室信息查询>(req);
        }

        public static res药品项目查询 药品项目查询(req药品项目查询 req)
        {
            return Handler.Query<res药品项目查询, req药品项目查询>(req);
        }

        public static res收费项目查询 收费项目查询(req收费项目查询 req)
        {
            return Handler.Query<res收费项目查询, req收费项目查询>(req);
        }

        public static res查询所有医生信息 查询所有医生信息(req查询所有医生信息 req)
        {
            return Handler.Query<res查询所有医生信息, req查询所有医生信息>(req);
        }

        public static res就诊情况记录查询 就诊情况记录查询(req就诊情况记录查询 req)
        {
            return Handler.Query<res就诊情况记录查询, req就诊情况记录查询>(req);
        }

        public static res就诊满意度 就诊满意度(req就诊满意度 req)
        {
            return Handler.Query<res就诊满意度, req就诊满意度>(req);
        }

        public static res系统签到 系统签到(req系统签到 req)
        {
            return Handler.Query<res系统签到, req系统签到>(req);
        }

        public static res信息上报 信息上报(req信息上报 req)
        {
            return Handler.Query<res信息上报, req信息上报>(req);
        }

        public static res清钱箱上报 清钱箱上报(req清钱箱上报 req)
        {
            return Handler.Query<res清钱箱上报, req清钱箱上报>(req);
        }

        public static res创建扫码订单 创建扫码订单(req创建扫码订单 req)
        {
            return Handler.Query<res创建扫码订单, req创建扫码订单>(req);
        }

        public static res取消扫码订单 取消扫码订单(req取消扫码订单 req)
        {
            return Handler.Query<res取消扫码订单, req取消扫码订单>(req);
        }

        public static res查询订单状态 查询订单状态(req查询订单状态 req)
        {
            return Handler.Query<res查询订单状态, req查询订单状态>(req);
        }

        public static res操作成功状态上传 操作成功状态上传(req操作成功状态上传 req)
        {
            return Handler.Query<res操作成功状态上传, req操作成功状态上传>(req);
        }

        public static res查询网关状态 查询网关状态(req查询网关状态 req)
        {
            return Handler.Query<res查询网关状态, req查询网关状态>(req);
        }

        public static res门诊挂号预结算 门诊挂号预结算(req门诊挂号预结算 req)
        {
            return Handler.Query<res门诊挂号预结算, req门诊挂号预结算>(req);
        }

        public static res门诊挂号预结算结果确认 门诊挂号预结算结果确认(req门诊挂号预结算结果确认 req)
        {
            return Handler.Query<res门诊挂号预结算结果确认, req门诊挂号预结算结果确认>(req);
        }

        public static res门诊缴费预结算结果确认 门诊缴费预结算结果确认(req门诊缴费预结算结果确认 req)
        {
            return Handler.Query<res门诊缴费预结算结果确认, req门诊缴费预结算结果确认>(req);
        }

        public static res拍照录像上传 拍照录像上传(req拍照录像上传 req)
        {
            return Handler.Query<res拍照录像上传, req拍照录像上传>(req);
        }

    }

    
    public class req病人信息查询 : GatewayRequest
    {
        /// <summary>
        /// 病人信息查询
        /// </summary>
        public req病人信息查询()
        {
            service = "yuantu.wap.query.patient.info";
            _serviceName = "病人信息查询";
        }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string searchType { get; set; }
        [Obsolete]
        public string secrityNo { get; set; }
        public string patientName { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(searchType)] = searchType;
            dic[nameof(secrityNo)] = secrityNo;
            dic[nameof(patientName)] = patientName;
            return dic;
        }

    }
    
    public class req病人建档发卡 : GatewayRequest
    {
        /// <summary>
        /// 病人建档发卡
        /// </summary>
        public req病人建档发卡()
        {
            service = "yuantu.wap.set.patient.info";
            _serviceName = "病人建档发卡";
        }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string idNo { get; set; }
        public string idType { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string nation { get; set; }
        public string patientType { get; set; }
        [Obsolete]
        public string guardianName { get; set; }
        public string guardianNo { get; set; }
        public string pwd { get; set; }
        [Obsolete]
        public string school { get; set; }
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string bankCardNo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        public string setupType { get; set; }
        public string platformId { get; set; }
        /// <summary>
        /// 第三方的交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 付款人账号，WX、ZFB不可空
        /// </summary>
        public string payAccountNo { get; set; }
        /// <summary>
        /// 远图平台流水号
        /// </summary>
        public string outTradeNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(idNo)] = idNo;
            dic[nameof(idType)] = idType;
            dic[nameof(name)] = name;
            dic[nameof(sex)] = sex;
            dic[nameof(birthday)] = birthday;
            dic[nameof(address)] = address;
            dic[nameof(phone)] = phone;
            dic[nameof(nation)] = nation;
            dic[nameof(patientType)] = patientType;
            dic[nameof(guardianName)] = guardianName;
            dic[nameof(guardianNo)] = guardianNo;
            dic[nameof(pwd)] = pwd;
            dic[nameof(school)] = school;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            dic[nameof(cash)] = cash;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(setupType)] = setupType;
            dic[nameof(platformId)] = platformId;
            dic[nameof(transNo)] = transNo;
            dic[nameof(payAccountNo)] = payAccountNo;
            dic[nameof(outTradeNo)] = outTradeNo;
            return dic;
        }

    }
    
    public class req病人基本信息修改 : GatewayRequest
    {
        /// <summary>
        /// 病人基本信息修改
        /// </summary>
        public req病人基本信息修改()
        {
            service = "yuantu.wap.modify.patient.info";
            _serviceName = "病人基本信息修改";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string idNo { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string patientType { get; set; }
        public string guardianNo { get; set; }
        public string platformId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(idNo)] = idNo;
            dic[nameof(name)] = name;
            dic[nameof(sex)] = sex;
            dic[nameof(birthday)] = birthday;
            dic[nameof(phone)] = phone;
            dic[nameof(address)] = address;
            dic[nameof(patientType)] = patientType;
            dic[nameof(guardianNo)] = guardianNo;
            dic[nameof(platformId)] = platformId;
            return dic;
        }

    }
    
    public class req病人类别 : GatewayRequest
    {
        /// <summary>
        /// 病人类别
        /// </summary>
        public req病人类别()
        {
            service = "yuantu.wap.query.patient.type";
            _serviceName = "病人类别";
        }
    }
    
    public class req医保科室 : GatewayRequest
    {
        /// <summary>
        /// 医保科室
        /// </summary>
        public req医保科室()
        {
            service = "yuantu.wap.query.si.compare.dept";
            _serviceName = "医保科室";
        }
    }
    
    public class req病人领卡查询 : GatewayRequest
    {
        /// <summary>
        /// 病人领卡查询
        /// </summary>
        public req病人领卡查询()
        {
            service = "yuantu.wap.query.patient.card";
            _serviceName = "病人领卡查询";
        }
        public string idNo { get; set; }
        public string idType { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(idNo)] = idNo;
            dic[nameof(idType)] = idType;
            return dic;
        }

    }
    
    public class req诊疗卡账户修改密码 : GatewayRequest
    {
        /// <summary>
        /// 诊疗卡账户修改密码
        /// </summary>
        public req诊疗卡账户修改密码()
        {
            service = "yuantu.wap.modify.card.pwd";
            _serviceName = "诊疗卡账户修改密码";
        }
        public string patientId { get; set; }
        public string oldPassword { get; set; }
        public string newPassword { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(oldPassword)] = oldPassword;
            dic[nameof(newPassword)] = newPassword;
            return dic;
        }

    }
    
    public class req诊疗卡密码校验 : GatewayRequest
    {
        /// <summary>
        /// 诊疗卡密码校验
        /// </summary>
        public req诊疗卡密码校验()
        {
            service = "yuantu.wap.validate.card.pwd";
            _serviceName = "诊疗卡密码校验";
        }
        public string patientId { get; set; }
        public string password { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(password)] = password;
            return dic;
        }

    }
    
    public class req对账 : GatewayRequest
    {
        /// <summary>
        /// 对账
        /// </summary>
        public req对账()
        {
            service = "yuantu.wap.dui.zhang";
            _serviceName = "对账";
        }
        public string startDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(startDate)] = startDate;
            return dic;
        }

    }
    
    public class req自助绑定银行卡 : GatewayRequest
    {
        /// <summary>
        /// 自助绑定银行卡
        /// </summary>
        public req自助绑定银行卡()
        {
            service = "yuantu.wap.binging.bank.card";
            _serviceName = "自助绑定银行卡";
        }
        public string patientId { get; set; }
        public string bankCardNo { get; set; }
        public string name { get; set; }
        public string idNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(name)] = name;
            dic[nameof(idNo)] = idNo;
            return dic;
        }

    }
    
    public class req自助绑定银行卡解绑 : GatewayRequest
    {
        /// <summary>
        /// 自助绑定银行卡解绑
        /// </summary>
        public req自助绑定银行卡解绑()
        {
            service = "yuantu.wap.un.binging.bank.card";
            _serviceName = "自助绑定银行卡解绑";
        }
        public string patientId { get; set; }
        public string bankCardNo { get; set; }
        public string idNo { get; set; }
        public string name { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(idNo)] = idNo;
            dic[nameof(name)] = name;
            return dic;
        }

    }
    
    public class req排班科室信息查询 : GatewayRequest
    {
        /// <summary>
        /// 排班科室信息查询
        /// </summary>
        public req排班科室信息查询()
        {
            service = "yuantu.wap.query.registration.dep.list";
            _serviceName = "排班科室信息查询";
        }
        /// <summary>
        /// 挂号类型1预约 2挂号
        /// </summary>
        public string regMode { get; set; }
        public string regType { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(regMode)] = regMode;
            dic[nameof(regType)] = regType;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            return dic;
        }

    }
    
    public class req排班信息查询 : GatewayRequest
    {
        /// <summary>
        /// 排班信息查询
        /// </summary>
        public req排班信息查询()
        {
            service = "yuantu.wap.query.registration.schedule.info.list";
            _serviceName = "排班信息查询";
        }
        public string regMode { get; set; }
        public string regType { get; set; }
        public string medAmPm { get; set; }
        public string deptCode { get; set; }
        public string parentDeptCode { get; set; }
        public string doctCode { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(regMode)] = regMode;
            dic[nameof(regType)] = regType;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(parentDeptCode)] = parentDeptCode;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            return dic;
        }

    }
    
    public class req号源明细查询 : GatewayRequest
    {
        /// <summary>
        /// 号源明细查询
        /// </summary>
        public req号源明细查询()
        {
            service = "yuantu.wap.query.registration.sources";
            _serviceName = "号源明细查询";
        }
        public string regMode { get; set; }
        public string medDate { get; set; }
        public string medAmPm { get; set; }
        public string regType { get; set; }
        public string deptCode { get; set; }
        public string secondDeptCode { get; set; }
        public string doctCode { get; set; }
        public string scheduleId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(regMode)] = regMode;
            dic[nameof(medDate)] = medDate;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(regType)] = regType;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(secondDeptCode)] = secondDeptCode;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(scheduleId)] = scheduleId;
            return dic;
        }

    }
    
    public class req预约挂号预处理 : GatewayRequest
    {
        /// <summary>
        /// 预约挂号预处理
        /// </summary>
        public req预约挂号预处理()
        {
            service = "yuantu.wap.reg.pre.process";
            _serviceName = "预约挂号预处理";
        }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string regDate { get; set; }
        public string regType { get; set; }
        public string medAmPm { get; set; }
        public string deptCode { get; set; }
        public string doctCode { get; set; }
        public string appoNo { get; set; }
        public string patientId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(regDate)] = regDate;
            dic[nameof(regType)] = regType;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(appoNo)] = appoNo;
            dic[nameof(patientId)] = patientId;
            return dic;
        }

    }
    
    public class req挂号锁号 : GatewayRequest
    {
        /// <summary>
        /// 挂号锁号
        /// </summary>
        public req挂号锁号()
        {
            service = "yuantu.wap.lock.registration.source";
            _serviceName = "挂号锁号";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string regType { get; set; }
        public string medDate { get; set; }
        public string scheduleId { get; set; }
        public string deptCode { get; set; }
        public string doctCode { get; set; }
        public string medAmPm { get; set; }
        /// <summary>
        /// 挂号类型1预约 2挂号
        /// </summary>
        [Obsolete]
        public string regMode { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(regType)] = regType;
            dic[nameof(medDate)] = medDate;
            dic[nameof(scheduleId)] = scheduleId;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(regMode)] = regMode;
            return dic;
        }

    }
    
    public class req挂号解锁 : GatewayRequest
    {
        /// <summary>
        /// 挂号解锁
        /// </summary>
        public req挂号解锁()
        {
            service = "yuantu.wap.un.lock.registration.source";
            _serviceName = "挂号解锁";
        }
        public string lockId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(lockId)] = lockId;
            return dic;
        }

    }
    
    public class req预约挂号 : GatewayRequest
    {
        /// <summary>
        /// 预约挂号
        /// </summary>
        public req预约挂号()
        {
            service = "yuantu.wap.appointment.or.registration";
            _serviceName = "预约挂号";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        [Obsolete]
        public string idNo { get; set; }
        [Obsolete]
        public string phone { get; set; }
        public string regMode { get; set; }
        public string regType { get; set; }
        public string medDate { get; set; }
        public string medTime { get; set; }
        public string scheduleId { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string doctCode { get; set; }
        public string doctName { get; set; }
        public string medAmPm { get; set; }
        public string appoNo { get; set; }
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string bankCardNo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        /// <summary>
        /// 第三方的交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 锁号Id
        /// </summary>
        public string lockId { get; set; }
        [Obsolete]
        public string invoice { get; set; }
        [Obsolete]
        public string clinicres { get; set; }
        [Obsolete]
        public string patientName { get; set; }
        [Obsolete]
        public string guarderId { get; set; }
        /// <summary>
        /// 医保信息
        /// </summary>
        public string ybInfo { get; set; }
        /// <summary>
        /// 付款人账号，WX、ZFB不可空
        /// </summary>
        public string payAccountNo { get; set; }
        /// <summary>
        /// 远图平台流水号
        /// </summary>
        public string outTradeNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(idNo)] = idNo;
            dic[nameof(phone)] = phone;
            dic[nameof(regMode)] = regMode;
            dic[nameof(regType)] = regType;
            dic[nameof(medDate)] = medDate;
            dic[nameof(medTime)] = medTime;
            dic[nameof(scheduleId)] = scheduleId;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(deptName)] = deptName;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(doctName)] = doctName;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(appoNo)] = appoNo;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            dic[nameof(cash)] = cash;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(transNo)] = transNo;
            dic[nameof(lockId)] = lockId;
            dic[nameof(invoice)] = invoice;
            dic[nameof(clinicres)] = clinicres;
            dic[nameof(patientName)] = patientName;
            dic[nameof(guarderId)] = guarderId;
            dic[nameof(ybInfo)] = ybInfo;
            dic[nameof(payAccountNo)] = payAccountNo;
            dic[nameof(outTradeNo)] = outTradeNo;
            return dic;
        }

    }
    
    public class req预约取号 : GatewayRequest
    {
        /// <summary>
        /// 预约取号
        /// </summary>
        public req预约取号()
        {
            service = "yuantu.wap.take.registration.no";
            _serviceName = "预约取号";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public string appoNo { get; set; }
        [Obsolete]
        public string medDate { get; set; }
        [Obsolete]
        public string scheduleId { get; set; }
        [Obsolete]
        public string medAmPm { get; set; }
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string bankCardNo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        public string searchType { get; set; }
        /// <summary>
        /// 第三方的交易流水号
        /// </summary>
        public string transNo { get; set; }
        [Obsolete]
        public string invoice { get; set; }
        [Obsolete]
        public string clinicres { get; set; }
        /// <summary>
        /// 取号密码
        /// </summary>
        public string orderNo { get; set; }
        /// <summary>
        /// 医保信息
        /// </summary>
        public string ybInfo { get; set; }
        /// <summary>
        /// 付款人账号，WX、ZFB不可空
        /// </summary>
        public string payAccountNo { get; set; }
        /// <summary>
        /// 远图平台流水号
        /// </summary>
        public string outTradeNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(appoNo)] = appoNo;
            dic[nameof(medDate)] = medDate;
            dic[nameof(scheduleId)] = scheduleId;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            dic[nameof(cash)] = cash;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(searchType)] = searchType;
            dic[nameof(transNo)] = transNo;
            dic[nameof(invoice)] = invoice;
            dic[nameof(clinicres)] = clinicres;
            dic[nameof(orderNo)] = orderNo;
            dic[nameof(ybInfo)] = ybInfo;
            dic[nameof(payAccountNo)] = payAccountNo;
            dic[nameof(outTradeNo)] = outTradeNo;
            return dic;
        }

    }
    
    public class req取消预约 : GatewayRequest
    {
        /// <summary>
        /// 取消预约
        /// </summary>
        public req取消预约()
        {
            service = "yuantu.wap.cancel.appointment.or.registration";
            _serviceName = "取消预约";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public string appoNo { get; set; }
        [Obsolete]
        public string scheduleId { get; set; }
        [Obsolete]
        public string medDate { get; set; }
        [Obsolete]
        public string medAmPm { get; set; }
        public string regMode { get; set; }
        [Obsolete]
        public string regNo { get; set; }
        /// <summary>
        /// 取号密码
        /// </summary>
        public string orderNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(appoNo)] = appoNo;
            dic[nameof(scheduleId)] = scheduleId;
            dic[nameof(medDate)] = medDate;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(regMode)] = regMode;
            dic[nameof(regNo)] = regNo;
            dic[nameof(orderNo)] = orderNo;
            return dic;
        }

    }
    
    public class req挂号预约记录查询 : GatewayRequest
    {
        /// <summary>
        /// 挂号预约记录查询
        /// </summary>
        public req挂号预约记录查询()
        {
            service = "yuantu.wap.query.appointment.and.registration.record";
            _serviceName = "挂号预约记录查询";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string patientName { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string searchType { get; set; }
        public string status { get; set; }
        public string appoNo { get; set; }
        public string regMode { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientName)] = patientName;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            dic[nameof(searchType)] = searchType;
            dic[nameof(status)] = status;
            dic[nameof(appoNo)] = appoNo;
            dic[nameof(regMode)] = regMode;
            return dic;
        }

    }
    
    public class req获取缴费概要信息 : GatewayRequest
    {
        /// <summary>
        /// 获取缴费概要信息
        /// </summary>
        public req获取缴费概要信息()
        {
            service = "yuantu.wap.query.wait.balance.bill.list";
            _serviceName = "获取缴费概要信息";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string billType { get; set; }
        [Obsolete]
        public string secrityNo { get; set; }
        [Obsolete]
        public string patientName { get; set; }
        [Obsolete]
        public string idNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(billType)] = billType;
            dic[nameof(secrityNo)] = secrityNo;
            dic[nameof(patientName)] = patientName;
            dic[nameof(idNo)] = idNo;
            return dic;
        }

    }
    
    public class req获取缴费明细信息 : GatewayRequest
    {
        /// <summary>
        /// 获取缴费明细信息
        /// </summary>
        public req获取缴费明细信息()
        {
            service = "yuantu.wap.query.wait.balance.bill.item.list";
            _serviceName = "获取缴费明细信息";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string billType { get; set; }
        public string billNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(billType)] = billType;
            dic[nameof(billNo)] = billNo;
            return dic;
        }

    }
    
    public class req缴费预结算 : GatewayRequest
    {
        /// <summary>
        /// 缴费预结算
        /// </summary>
        public req缴费预结算()
        {
            service = "yuantu.wap.pre.balance.bill";
            _serviceName = "缴费预结算";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string billNo { get; set; }
        /// <summary>
        /// 所有缴费明细(医保使用)
        /// </summary>
        public string billItems { get; set; }
        /// <summary>
        /// 支付方式(只传MIC)
        /// </summary>
        public string tradeMode { get; set; }
        /// <summary>
        /// 医保卡号码
        /// </summary>
        public string ybCardNo { get; set; }
        public string patientTypeId { get; set; }
        public string cash { get; set; }
        public string ybTradeType { get; set; }
        public string isZj { get; set; }
        public string cardHardInfo { get; set; }
        public string siPatientInfo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(billNo)] = billNo;
            dic[nameof(billItems)] = billItems;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(ybCardNo)] = ybCardNo;
            dic[nameof(patientTypeId)] = patientTypeId;
            dic[nameof(cash)] = cash;
            dic[nameof(ybTradeType)] = ybTradeType;
            dic[nameof(isZj)] = isZj;
            dic[nameof(cardHardInfo)] = cardHardInfo;
            dic[nameof(siPatientInfo)] = siPatientInfo;
            return dic;
        }

    }
    
    public class req缴费结算 : GatewayRequest
    {
        /// <summary>
        /// 缴费结算
        /// </summary>
        public req缴费结算()
        {
            service = "yuantu.wap.balance.and.pay.bill";
            _serviceName = "缴费结算";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string billNo { get; set; }
        public string allSelf { get; set; }
        [Obsolete]
        public string secrityNo { get; set; }
        [Obsolete]
        public string extendBalanceInfo { get; set; }
        [Obsolete]
        public string invoice { get; set; }
        [Obsolete]
        public string clinicres { get; set; }
        [Obsolete]
        public string patientName { get; set; }
        /// <summary>
        /// 病人医保类型，可空
        /// </summary>
        public string patientTypeId { get; set; }
        /// <summary>
        /// 医保卡号码
        /// </summary>
        public string ybCardNo { get; set; }
        /// <summary>
        /// 缴费预结算中医保支付信息
        /// </summary>
        public string preYbinfo { get; set; }
        /// <summary>
        /// 所有缴费明细(医保使用)
        /// </summary>
        public string billItems { get; set; }
        /// <summary>
        /// 预结算时返回的单据号
        /// </summary>
        public string balBillNo { get; set; }
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string bankCardNo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        /// <summary>
        /// 第三方的交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 付款人账号，WX、ZFB不可空
        /// </summary>
        public string payAccountNo { get; set; }
        /// <summary>
        /// 远图平台流水号
        /// </summary>
        public string outTradeNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(billNo)] = billNo;
            dic[nameof(allSelf)] = allSelf;
            dic[nameof(secrityNo)] = secrityNo;
            dic[nameof(extendBalanceInfo)] = extendBalanceInfo;
            dic[nameof(invoice)] = invoice;
            dic[nameof(clinicres)] = clinicres;
            dic[nameof(patientName)] = patientName;
            dic[nameof(patientTypeId)] = patientTypeId;
            dic[nameof(ybCardNo)] = ybCardNo;
            dic[nameof(preYbinfo)] = preYbinfo;
            dic[nameof(billItems)] = billItems;
            dic[nameof(balBillNo)] = balBillNo;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            dic[nameof(cash)] = cash;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(transNo)] = transNo;
            dic[nameof(payAccountNo)] = payAccountNo;
            dic[nameof(outTradeNo)] = outTradeNo;
            return dic;
        }

    }
    
    public class req获取已结算记录 : GatewayRequest
    {
        /// <summary>
        /// 获取已结算记录
        /// </summary>
        public req获取已结算记录()
        {
            service = "yuantu.wap.query.bill.balance.and.pay.summary.record";
            _serviceName = "获取已结算记录";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        [Obsolete]
        public string beginDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            dic[nameof(beginDate)] = beginDate;
            return dic;
        }

    }
    
    public class req获取已结算明细记录 : GatewayRequest
    {
        /// <summary>
        /// 获取已结算明细记录
        /// </summary>
        public req获取已结算明细记录()
        {
            service = "yuantu.wap.query.bill.balance.and.pay.record";
            _serviceName = "获取已结算明细记录";
        }
        public string cardNo { get; set; }
        public string billNo { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(billNo)] = billNo;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            return dic;
        }

    }
    
    public class req虚拟账户开通 : GatewayRequest
    {
        /// <summary>
        /// 虚拟账户开通
        /// </summary>
        public req虚拟账户开通()
        {
            service = "yuantu.wap.register.virtual.settlement";
            _serviceName = "虚拟账户开通";
        }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string idNo { get; set; }
        public string idType { get; set; }
        public string patientName { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string nation { get; set; }
        public string patientType { get; set; }
        public string guarderId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(idNo)] = idNo;
            dic[nameof(idType)] = idType;
            dic[nameof(patientName)] = patientName;
            dic[nameof(sex)] = sex;
            dic[nameof(birthday)] = birthday;
            dic[nameof(phone)] = phone;
            dic[nameof(address)] = address;
            dic[nameof(nation)] = nation;
            dic[nameof(patientType)] = patientType;
            dic[nameof(guarderId)] = guarderId;
            return dic;
        }

    }
    
    public class req预缴金充值 : GatewayRequest
    {
        /// <summary>
        /// 预缴金充值
        /// </summary>
        public req预缴金充值()
        {
            service = "yuantu.wap.recharge.virtual.settlement";
            _serviceName = "预缴金充值";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string platformId { get; set; }
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string bankCardNo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        /// <summary>
        /// 1门诊2住院
        /// </summary>
        public string inHos { get; set; }
        public string name { get; set; }
        /// <summary>
        /// 交易流水号（交易方式为CA OC ZFB WX增加参数）
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 付款人账号，WX、ZFB不可空
        /// </summary>
        public string payAccountNo { get; set; }
        /// <summary>
        /// 远图平台流水号
        /// </summary>
        public string outTradeNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(platformId)] = platformId;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            dic[nameof(cash)] = cash;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(inHos)] = inHos;
            dic[nameof(name)] = name;
            dic[nameof(transNo)] = transNo;
            dic[nameof(payAccountNo)] = payAccountNo;
            dic[nameof(outTradeNo)] = outTradeNo;
            return dic;
        }

    }
    
    public class req充值数据同步到his系统 : GatewayRequest
    {
        /// <summary>
        /// 充值数据同步到his系统
        /// </summary>
        public req充值数据同步到his系统()
        {
            service = "yuantu.wap.upload.recharge.record";
            _serviceName = "充值数据同步到his系统";
        }
        [Obsolete]
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string bankCardNo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 1门诊2住院
        /// </summary>
        public string inHos { get; set; }
        public string name { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            dic[nameof(cash)] = cash;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(transNo)] = transNo;
            dic[nameof(inHos)] = inHos;
            dic[nameof(name)] = name;
            return dic;
        }

    }
    
    public class req预约挂号记录同步到his系统 : GatewayRequest
    {
        /// <summary>
        /// 预约挂号记录同步到his系统
        /// </summary>
        public req预约挂号记录同步到his系统()
        {
            service = "yuantu.wap.upload.reg.record";
            _serviceName = "预约挂号记录同步到his系统";
        }
        public string regMode { get; set; }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string idNo { get; set; }
        public string patientName { get; set; }
        public string phone { get; set; }
        public string sex { get; set; }
        public string age { get; set; }
        public string guardianName { get; set; }
        public string guardianNo { get; set; }
        public string medAmPm { get; set; }
        public string medDate { get; set; }
        public string medTime { get; set; }
        public string regType { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string doctCode { get; set; }
        public string doctName { get; set; }
        public string appoNo { get; set; }
        public string address { get; set; }
        public string status { get; set; }
        public string tradeMode { get; set; }
        public string cash { get; set; }
        public string costItemName { get; set; }
        public string costItemId { get; set; }
        public string orderNo { get; set; }
        public string medBegtime { get; set; }
        public string medEndtime { get; set; }
        public string scheduleId { get; set; }
        public string thirdPartyRegId { get; set; }
        public string patientId { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankCardNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string deviceInfo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        public string transNo { get; set; }
        public string tradeModeExtend { get; set; }
        public string tradeTime { get; set; }
        public string payAccountNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(regMode)] = regMode;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(idNo)] = idNo;
            dic[nameof(patientName)] = patientName;
            dic[nameof(phone)] = phone;
            dic[nameof(sex)] = sex;
            dic[nameof(age)] = age;
            dic[nameof(guardianName)] = guardianName;
            dic[nameof(guardianNo)] = guardianNo;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(medDate)] = medDate;
            dic[nameof(medTime)] = medTime;
            dic[nameof(regType)] = regType;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(deptName)] = deptName;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(doctName)] = doctName;
            dic[nameof(appoNo)] = appoNo;
            dic[nameof(address)] = address;
            dic[nameof(status)] = status;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(cash)] = cash;
            dic[nameof(costItemName)] = costItemName;
            dic[nameof(costItemId)] = costItemId;
            dic[nameof(orderNo)] = orderNo;
            dic[nameof(medBegtime)] = medBegtime;
            dic[nameof(medEndtime)] = medEndtime;
            dic[nameof(scheduleId)] = scheduleId;
            dic[nameof(thirdPartyRegId)] = thirdPartyRegId;
            dic[nameof(patientId)] = patientId;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(deviceInfo)] = deviceInfo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(transNo)] = transNo;
            dic[nameof(tradeModeExtend)] = tradeModeExtend;
            dic[nameof(tradeTime)] = tradeTime;
            dic[nameof(payAccountNo)] = payAccountNo;
            return dic;
        }

    }
    
    public class req交易记录同步到his系统 : GatewayRequest
    {
        /// <summary>
        /// 交易记录同步到his系统
        /// </summary>
        public req交易记录同步到his系统()
        {
            service = "yuantu.wap.upload.consume.record";
            _serviceName = "交易记录同步到his系统";
        }
        public string platformId { get; set; }
        public string hisPatientId  { get; set; }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string idNo { get; set; }
        public string patientName { get; set; }
        public string guarderId { get; set; }
        public string tradeMode { get; set; }
        public string tradeType { get; set; }
        public string cash { get; set; }
        public string inHos { get; set; }
        public string remarks { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankCardNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        public string transNo { get; set; }
        public string tradeModeExtend { get; set; }
        public string payAccountNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(platformId)] = platformId;
            dic[nameof(hisPatientId )] = hisPatientId ;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(idNo)] = idNo;
            dic[nameof(patientName)] = patientName;
            dic[nameof(guarderId)] = guarderId;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(tradeType)] = tradeType;
            dic[nameof(cash)] = cash;
            dic[nameof(inHos)] = inHos;
            dic[nameof(remarks)] = remarks;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(transNo)] = transNo;
            dic[nameof(tradeModeExtend)] = tradeModeExtend;
            dic[nameof(payAccountNo)] = payAccountNo;
            return dic;
        }

    }
    
    public class req查询预缴金充值记录 : GatewayRequest
    {
        /// <summary>
        /// 查询预缴金充值记录
        /// </summary>
        public req查询预缴金充值记录()
        {
            service = "yuantu.wap.query.patient.vs.record";
            _serviceName = "查询预缴金充值记录";
        }
        [Obsolete]
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string idNo { get; set; }
        public string patientName { get; set; }
        public string guarderId { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(idNo)] = idNo;
            dic[nameof(patientName)] = patientName;
            dic[nameof(guarderId)] = guarderId;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            return dic;
        }

    }
    
    public class req查询预缴金账户余额 : GatewayRequest
    {
        /// <summary>
        /// 查询预缴金账户余额
        /// </summary>
        public req查询预缴金账户余额()
        {
            service = "yuantu.wap.query.virtual.settlement";
            _serviceName = "查询预缴金账户余额";
        }
        [Obsolete]
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string idNo { get; set; }
        public string patientName { get; set; }
        public string guarderId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(idNo)] = idNo;
            dic[nameof(patientName)] = patientName;
            dic[nameof(guarderId)] = guarderId;
            return dic;
        }

    }
    
    public class req预缴金消费 : GatewayRequest
    {
        /// <summary>
        /// 预缴金消费
        /// </summary>
        public req预缴金消费()
        {
            service = "yuantu.wap.consume.vs.cash";
            _serviceName = "预缴金消费";
        }
        /// <summary>
        /// 卡内号码
        /// </summary>
        public string cardNo { get; set; }
        /// <summary>
        /// 卡类型
        /// </summary>
        public string cardType { get; set; }
        /// <summary>
        /// 病人类型
        /// </summary>
        public string patientName { get; set; }
        /// <summary>
        /// 消费金额
        /// </summary>
        public string cash { get; set; }
        /// <summary>
        /// 住院或门诊(1:门诊 2:住院)
        /// </summary>
        public string inHos { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(patientName)] = patientName;
            dic[nameof(cash)] = cash;
            dic[nameof(inHos)] = inHos;
            return dic;
        }

    }
    
    public class req预缴金消费冲正 : GatewayRequest
    {
        /// <summary>
        /// 预缴金消费冲正
        /// </summary>
        public req预缴金消费冲正()
        {
            service = "yuantu.wap.consume.flushes.vs.cash";
            _serviceName = "预缴金消费冲正";
        }
        /// <summary>
        /// 消费流水号
        /// </summary>
        public string sFlowId { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string cash { get; set; }
        /// <summary>
        /// 订单Id
        /// </summary>
        public string orderId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(sFlowId)] = sFlowId;
            dic[nameof(cash)] = cash;
            dic[nameof(orderId)] = orderId;
            return dic;
        }

    }
    
    public class req住院患者信息查询 : GatewayRequest
    {
        /// <summary>
        /// 住院患者信息查询
        /// </summary>
        public req住院患者信息查询()
        {
            service = "yuantu.wap.query.inhos.patient.info";
            _serviceName = "住院患者信息查询";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string patientName { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientName)] = patientName;
            return dic;
        }

    }
    
    public class req住院患者费用明细查询 : GatewayRequest
    {
        /// <summary>
        /// 住院患者费用明细查询
        /// </summary>
        public req住院患者费用明细查询()
        {
            service = "yuantu.wap.query.inhos.bill.item.list";
            _serviceName = "住院患者费用明细查询";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        [Obsolete]
        public string patientHosId { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        /// <summary>
        /// 出生日期
        /// </summary>
        public string birthday { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientHosId)] = patientHosId;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            dic[nameof(birthday)] = birthday;
            return dic;
        }

    }
    
    public class req住院患者费用明细打印 : GatewayRequest
    {
        /// <summary>
        /// 住院患者费用明细打印
        /// </summary>
        public req住院患者费用明细打印()
        {
            service = "yuantu.wap.query.inhos.print.bill.item.list";
            _serviceName = "住院患者费用明细打印";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        [Obsolete]
        public string patientHosId { get; set; }
        public string date { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientHosId)] = patientHosId;
            dic[nameof(date)] = date;
            return dic;
        }

    }
    
    public class req住院预缴金充值 : GatewayRequest
    {
        /// <summary>
        /// 住院预缴金充值
        /// </summary>
        public req住院预缴金充值()
        {
            service = "yuantu.wap.recharge.inhos.virtual.settlement";
            _serviceName = "住院预缴金充值";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string patientName { get; set; }
        public string patientHosId { get; set; }
        public string patientHosNo { get; set; }
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string posTransNo { get; set; }
        public string bankTransNo { get; set; }
        public string bankDate { get; set; }
        public string bankTime { get; set; }
        public string bankSettlementTime { get; set; }
        public string bankCardNo { get; set; }
        public string posIndexNo { get; set; }
        public string sellerAccountNo { get; set; }
        public string payerName { get; set; }
        /// <summary>
        /// 付款人账号，WX、ZFB不可空
        /// </summary>
        public string payAccountNo { get; set; }
        /// <summary>
        /// 远图平台流水号
        /// </summary>
        public string outTradeNo { get; set; }
        /// <summary>
        /// 第三方的交易流水号
        /// </summary>
        public string transNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientName)] = patientName;
            dic[nameof(patientHosId)] = patientHosId;
            dic[nameof(patientHosNo)] = patientHosNo;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            dic[nameof(cash)] = cash;
            dic[nameof(posTransNo)] = posTransNo;
            dic[nameof(bankTransNo)] = bankTransNo;
            dic[nameof(bankDate)] = bankDate;
            dic[nameof(bankTime)] = bankTime;
            dic[nameof(bankSettlementTime)] = bankSettlementTime;
            dic[nameof(bankCardNo)] = bankCardNo;
            dic[nameof(posIndexNo)] = posIndexNo;
            dic[nameof(sellerAccountNo)] = sellerAccountNo;
            dic[nameof(payerName)] = payerName;
            dic[nameof(payAccountNo)] = payAccountNo;
            dic[nameof(outTradeNo)] = outTradeNo;
            dic[nameof(transNo)] = transNo;
            return dic;
        }

    }
    
    public class req住院预缴金充值记录查询 : GatewayRequest
    {
        /// <summary>
        /// 住院预缴金充值记录查询
        /// </summary>
        public req住院预缴金充值记录查询()
        {
            service = "yuantu.wap.query.inhos.vs.record";
            _serviceName = "住院预缴金充值记录查询";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            return dic;
        }

    }
    
    public class req检查病人是否能自助机结算 : GatewayRequest
    {
        /// <summary>
        /// 检查病人是否能自助机结算
        /// </summary>
        public req检查病人是否能自助机结算()
        {
            service = "yuantu.wap.query.check.inhos.status";
            _serviceName = "检查病人是否能自助机结算";
        }
        /// <summary>
        /// 病人Id
        /// </summary>
        public string patientId { get; set; }
        /// <summary>
        /// 卡片类型
        /// </summary>
        public string cardType { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string cardNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            return dic;
        }

    }
    
    public class req自助出院预结算 : GatewayRequest
    {
        /// <summary>
        /// 自助出院预结算
        /// </summary>
        public req自助出院预结算()
        {
            service = "yuantu.wap.query.zy.pre.out.hos.self";
            _serviceName = "自助出院预结算";
        }
        /// <summary>
        /// 病人Id
        /// </summary>
        public string patientId { get; set; }
        /// <summary>
        /// 卡片类型
        /// </summary>
        public string cardType { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string cardNo { get; set; }
        /// <summary>
        /// 病人医保类型ID
        /// </summary>
        public string patientTypeId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientTypeId)] = patientTypeId;
            return dic;
        }

    }
    
    public class req自助出院结算 : GatewayRequest
    {
        /// <summary>
        /// 自助出院结算
        /// </summary>
        public req自助出院结算()
        {
            service = "yuantu.wap.query.zy.out.hos.self";
            _serviceName = "自助出院结算";
        }
        /// <summary>
        /// 病人Id
        /// </summary>
        public string patientId { get; set; }
        /// <summary>
        /// 卡片类型
        /// </summary>
        public string cardType { get; set; }
        /// <summary>
        /// 卡号
        /// </summary>
        public string cardNo { get; set; }
        /// <summary>
        /// 病人医保类型ID
        /// </summary>
        public string patientTypeId { get; set; }
        /// <summary>
        /// 充值方式(CA,DB,ZFB,WX)
        /// </summary>
        public string tradeMode { get; set; }
        /// <summary>
        /// 交易账户
        /// </summary>
        public string accountNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientTypeId)] = patientTypeId;
            dic[nameof(tradeMode)] = tradeMode;
            dic[nameof(accountNo)] = accountNo;
            return dic;
        }

    }
    
    public class req住院床位信息查询 : GatewayRequest
    {
        /// <summary>
        /// 住院床位信息查询
        /// </summary>
        public req住院床位信息查询()
        {
            service = "yuantu.wap.query.inhos.ward.beds";
            _serviceName = "住院床位信息查询";
        }
    }
    
    public class req检验基本信息查询 : GatewayRequest
    {
        /// <summary>
        /// 检验基本信息查询
        /// </summary>
        public req检验基本信息查询()
        {
            service = "yuantu.wap.query.lis.report";
            _serviceName = "检验基本信息查询";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        [Obsolete]
        public string patientHosNo { get; set; }
        [Obsolete]
        public string startTime { get; set; }
        [Obsolete]
        public string endTime { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        /// <summary>
        /// 1门诊号2住院号
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 患者姓名
        /// </summary>
        public string patientName { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(patientHosNo)] = patientHosNo;
            dic[nameof(startTime)] = startTime;
            dic[nameof(endTime)] = endTime;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            dic[nameof(type)] = type;
            dic[nameof(patientName)] = patientName;
            return dic;
        }

    }
    
    public class req检查结果查询 : GatewayRequest
    {
        /// <summary>
        /// 检查结果查询
        /// </summary>
        public req检查结果查询()
        {
            service = "yuantu.wap.query.pacs.check.result";
            _serviceName = "检查结果查询";
        }
        public string patientId { get; set; }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string platformId { get; set; }
        /// <summary>
        /// 1门诊号2住院号
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 1门诊2住院不传就全部
        /// </summary>
        public string visitFrom { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            dic[nameof(platformId)] = platformId;
            dic[nameof(type)] = type;
            dic[nameof(visitFrom)] = visitFrom;
            return dic;
        }

    }
    
    public class req影像诊断结果查询 : GatewayRequest
    {
        /// <summary>
        /// 影像诊断结果查询
        /// </summary>
        public req影像诊断结果查询()
        {
            service = "yuantu.wap.query.pacs.check.result";
            _serviceName = "影像诊断结果查询";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        public string type { get; set; }
        public string visitFrom { get; set; }
        public string platformId { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            dic[nameof(type)] = type;
            dic[nameof(visitFrom)] = visitFrom;
            dic[nameof(platformId)] = platformId;
            return dic;
        }

    }
    
    public class req医生信息查询 : GatewayRequest
    {
        /// <summary>
        /// 医生信息查询
        /// </summary>
        public req医生信息查询()
        {
            service = "yuantu.wap.query.hospital.doc";
            _serviceName = "医生信息查询";
        }
        public string doctCode { get; set; }
        public string deptCode { get; set; }
        public string doctName { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(doctName)] = doctName;
            return dic;
        }

    }
    
    public class req科室信息查询 : GatewayRequest
    {
        /// <summary>
        /// 科室信息查询
        /// </summary>
        public req科室信息查询()
        {
            service = "yuantu.wap.query.hospital.dep";
            _serviceName = "科室信息查询";
        }
        /// <summary>
        /// 0或空全部科室1特色科室
        /// </summary>
        public string deptType { get; set; }
        public string deptCode { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(deptType)] = deptType;
            dic[nameof(deptCode)] = deptCode;
            return dic;
        }

    }
    
    public class req药品项目查询 : GatewayRequest
    {
        /// <summary>
        /// 药品项目查询
        /// </summary>
        public req药品项目查询()
        {
            service = "yuantu.wap.query.medicines.info";
            _serviceName = "药品项目查询";
        }
        public string pinyinCode { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(pinyinCode)] = pinyinCode;
            return dic;
        }

    }
    
    public class req收费项目查询 : GatewayRequest
    {
        /// <summary>
        /// 收费项目查询
        /// </summary>
        public req收费项目查询()
        {
            service = "yuantu.wap.query.cost.info";
            _serviceName = "收费项目查询";
        }
        public string pinyinCode { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(pinyinCode)] = pinyinCode;
            return dic;
        }

    }
    
    public class req查询所有医生信息 : GatewayRequest
    {
        /// <summary>
        /// 查询所有医生信息
        /// </summary>
        public req查询所有医生信息()
        {
            service = "yuantu.wap.query.hospital.all.doc";
            _serviceName = "查询所有医生信息";
        }
        public string doctCode { get; set; }
        public string deptCode { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(deptCode)] = deptCode;
            return dic;
        }

    }
    
    public class req就诊情况记录查询 : GatewayRequest
    {
        /// <summary>
        /// 就诊情况记录查询
        /// </summary>
        public req就诊情况记录查询()
        {
            service = "yuantu.wap.query.medical.record";
            _serviceName = "就诊情况记录查询";
        }
        public string patientId { get; set; }
        public string cardType { get; set; }
        public string cardNo { get; set; }
        public string startDate { get; set; }
        public string endDate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(startDate)] = startDate;
            dic[nameof(endDate)] = endDate;
            return dic;
        }

    }
    
    public class req就诊满意度 : GatewayRequest
    {
        /// <summary>
        /// 就诊满意度
        /// </summary>
        public req就诊满意度()
        {
            service = "yuantu.wap.query.medical.record";
            _serviceName = "就诊满意度";
        }
        public string doctCode { get; set; }
        public string deptCode { get; set; }
        /// <summary>
        /// 满意 非常满意 不满意
        /// </summary>
        public string level { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(level)] = level;
            return dic;
        }

    }
    
    public class req系统签到 : GatewayRequest
    {
        /// <summary>
        /// 系统签到
        /// </summary>
        public req系统签到()
        {
            service = "yuantu.wap.monitor.service";
            _serviceName = "系统签到";
        }
        /// <summary>
        /// 调用方法名
        /// </summary>
        public string method { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string deviceNo { get; set; }
        /// <summary>
        /// 设备型号
        /// </summary>
        public string deviceType { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(method)] = method;
            dic[nameof(deviceNo)] = deviceNo;
            dic[nameof(deviceType)] = deviceType;
            return dic;
        }

    }
    
    public class req信息上报 : GatewayRequest
    {
        /// <summary>
        /// 信息上报
        /// </summary>
        public req信息上报()
        {
            service = "yuantu.wap.monitor.service";
            _serviceName = "信息上报";
        }
        /// <summary>
        /// 调用方法名
        /// </summary>
        public string method { get; set; }
        /// <summary>
        /// 设备编号
        /// </summary>
        public string deviceNo { get; set; }
        /// <summary>
        /// 异常编码
        /// </summary>
        public string errorCode { get; set; }
        /// <summary>
        /// 异常内容
        /// </summary>
        public string errorMsg { get; set; }
        /// <summary>
        /// 异常级别
        /// </summary>
        public string errorLevel { get; set; }
        /// <summary>
        /// 异常详情
        /// </summary>
        public string errorDetail { get; set; }
        /// <summary>
        /// 异常解决方案
        /// </summary>
        public string errorSolution { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(method)] = method;
            dic[nameof(deviceNo)] = deviceNo;
            dic[nameof(errorCode)] = errorCode;
            dic[nameof(errorMsg)] = errorMsg;
            dic[nameof(errorLevel)] = errorLevel;
            dic[nameof(errorDetail)] = errorDetail;
            dic[nameof(errorSolution)] = errorSolution;
            return dic;
        }

    }
    
    public class req清钱箱上报 : GatewayRequest
    {
        /// <summary>
        /// 清钱箱上报
        /// </summary>
        public req清钱箱上报()
        {
            service = "yuantu.wap.save.clean.money.log";
            _serviceName = "清钱箱上报";
        }
        /// <summary>
        /// 总计金额
        /// </summary>
        public string cash { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(cash)] = cash;
            return dic;
        }

    }
    
    public class req创建扫码订单 : GatewayRequest
    {
        /// <summary>
        /// 创建扫码订单
        /// </summary>
        public req创建扫码订单()
        {
            service = "yuantu.wap.sao.ma.create.order";
            _serviceName = "创建扫码订单";
        }
        /// <summary>
        /// 身份号
        /// </summary>
        public string idNo { get; set; }
        /// <summary>
        /// 证件类型
        /// </summary>
        public string idType { get; set; }
        /// <summary>
        /// 病人姓名
        /// </summary>
        public string patientName { get; set; }
        /// <summary>
        /// 监护人身份证号
        /// </summary>
        public string guarderId { get; set; }
        /// <summary>
        /// 医院用户门诊Id
        /// </summary>
        public string patientId { get; set; }
        /// <summary>
        /// 外键业务关联Id(去重选项)
        /// </summary>
        public string outId { get; set; }
        /// <summary>
        /// 缴费单编号(可空)
        /// </summary>
        public string billNo { get; set; }
        /// <summary>
        /// 金额(单位：分)
        /// </summary>
        public string fee { get; set; }
        /// <summary>
        /// 1:充值 2:缴费 3:挂号
        /// </summary>
        public string optType { get; set; }
        /// <summary>
        /// 业务描述
        /// </summary>
        public string subject { get; set; }
        /// <summary>
        /// 支付渠道，1:支付宝 2:微信
        /// </summary>
        public string feeChannel { get; set; }
        /// <summary>
        /// 来源
        /// </summary>
        public string source { get; set; }
        /// <summary>
        /// 扩展信息，存放额外可选数据
        /// </summary>
        public string extendBalanceInfo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(idNo)] = idNo;
            dic[nameof(idType)] = idType;
            dic[nameof(patientName)] = patientName;
            dic[nameof(guarderId)] = guarderId;
            dic[nameof(patientId)] = patientId;
            dic[nameof(outId)] = outId;
            dic[nameof(billNo)] = billNo;
            dic[nameof(fee)] = fee;
            dic[nameof(optType)] = optType;
            dic[nameof(subject)] = subject;
            dic[nameof(feeChannel)] = feeChannel;
            dic[nameof(source)] = source;
            dic[nameof(extendBalanceInfo)] = extendBalanceInfo;
            return dic;
        }

    }
    
    public class req取消扫码订单 : GatewayRequest
    {
        /// <summary>
        /// 取消扫码订单
        /// </summary>
        public req取消扫码订单()
        {
            service = "yuantu.wap.sao.ma.cancel.order";
            _serviceName = "取消扫码订单";
        }
        /// <summary>
        /// 用户平台订单号
        /// </summary>
        public string outTradeNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(outTradeNo)] = outTradeNo;
            return dic;
        }

    }
    
    public class req查询订单状态 : GatewayRequest
    {
        /// <summary>
        /// 查询订单状态
        /// </summary>
        public req查询订单状态()
        {
            service = "yuantu.wap.sao.ma.query.order";
            _serviceName = "查询订单状态";
        }
        /// <summary>
        /// 用户平台订单号
        /// </summary>
        public string outTradeNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(outTradeNo)] = outTradeNo;
            return dic;
        }

    }
    
    public class req操作成功状态上传 : GatewayRequest
    {
        /// <summary>
        /// 操作成功状态上传
        /// </summary>
        public req操作成功状态上传()
        {
            service = "yuantu.wap.sao.ma.success.order";
            _serviceName = "操作成功状态上传";
        }
        /// <summary>
        /// 用户平台订单号
        /// </summary>
        public string outTradeNo { get; set; }
        /// <summary>
        /// 业务处理状态200处理成功101处理失败
        /// </summary>
        public string status { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(outTradeNo)] = outTradeNo;
            dic[nameof(status)] = status;
            return dic;
        }

    }
    
    public class req查询网关状态 : GatewayRequest
    {
        /// <summary>
        /// 查询网关状态
        /// </summary>
        public req查询网关状态()
        {
            service = "yuantu.wap.gateway.status.service";
            _serviceName = "查询网关状态";
        }
    }
    
    public class req门诊挂号预结算 : GatewayRequest
    {
        /// <summary>
        /// 门诊挂号预结算
        /// </summary>
        public req门诊挂号预结算()
        {
            service = "yuantu.wap.pre.appoint.reg";
            _serviceName = "门诊挂号预结算";
        }
        public string patientId { get; set; }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string regMode { get; set; }
        public string regType { get; set; }
        public string medDate { get; set; }
        public string scheduleId { get; set; }
        public string deptCode { get; set; }
        public string doctCode { get; set; }
        public string medAmPm { get; set; }
        public string cash { get; set; }
        public string ybCardNo { get; set; }
        public string ybTradeType { get; set; }
        public string isZj { get; set; }
        public string cardHardInfo { get; set; }
        public string siPatientInfo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(regMode)] = regMode;
            dic[nameof(regType)] = regType;
            dic[nameof(medDate)] = medDate;
            dic[nameof(scheduleId)] = scheduleId;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(cash)] = cash;
            dic[nameof(ybCardNo)] = ybCardNo;
            dic[nameof(ybTradeType)] = ybTradeType;
            dic[nameof(isZj)] = isZj;
            dic[nameof(cardHardInfo)] = cardHardInfo;
            dic[nameof(siPatientInfo)] = siPatientInfo;
            return dic;
        }

    }
    
    public class req门诊挂号预结算结果确认 : GatewayRequest
    {
        /// <summary>
        /// 门诊挂号预结算结果确认
        /// </summary>
        public req门诊挂号预结算结果确认()
        {
            service = "yuantu.wap.pre.appoint.reg.confirm";
            _serviceName = "门诊挂号预结算结果确认";
        }
        public string patientId { get; set; }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string regMode { get; set; }
        public string regType { get; set; }
        public string medDate { get; set; }
        public string scheduleId { get; set; }
        public string deptCode { get; set; }
        public string doctCode { get; set; }
        public string medAmPm { get; set; }
        public string cash { get; set; }
        public string ybCardNo { get; set; }
        public string ybTradeType { get; set; }
        public string isZj { get; set; }
        public string insurFeeInfo { get; set; }
        public string cardHardInfo { get; set; }
        public string siPatientInfo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(regMode)] = regMode;
            dic[nameof(regType)] = regType;
            dic[nameof(medDate)] = medDate;
            dic[nameof(scheduleId)] = scheduleId;
            dic[nameof(deptCode)] = deptCode;
            dic[nameof(doctCode)] = doctCode;
            dic[nameof(medAmPm)] = medAmPm;
            dic[nameof(cash)] = cash;
            dic[nameof(ybCardNo)] = ybCardNo;
            dic[nameof(ybTradeType)] = ybTradeType;
            dic[nameof(isZj)] = isZj;
            dic[nameof(insurFeeInfo)] = insurFeeInfo;
            dic[nameof(cardHardInfo)] = cardHardInfo;
            dic[nameof(siPatientInfo)] = siPatientInfo;
            return dic;
        }

    }
    
    public class req门诊缴费预结算结果确认 : GatewayRequest
    {
        /// <summary>
        /// 门诊缴费预结算结果确认
        /// </summary>
        public req门诊缴费预结算结果确认()
        {
            service = "yuantu.wap.op.pay.confirm";
            _serviceName = "门诊缴费预结算结果确认";
        }
        public string patientId { get; set; }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string cash { get; set; }
        public string ybCardNo { get; set; }
        public string ybTradeType { get; set; }
        public string isZj { get; set; }
        public string insurFeeInfo { get; set; }
        public string cardHardInfo { get; set; }
        public string siPatientInfo { get; set; }
        public string billNo { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(patientId)] = patientId;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(cash)] = cash;
            dic[nameof(ybCardNo)] = ybCardNo;
            dic[nameof(ybTradeType)] = ybTradeType;
            dic[nameof(isZj)] = isZj;
            dic[nameof(insurFeeInfo)] = insurFeeInfo;
            dic[nameof(cardHardInfo)] = cardHardInfo;
            dic[nameof(siPatientInfo)] = siPatientInfo;
            dic[nameof(billNo)] = billNo;
            return dic;
        }

    }
    
    public class req拍照录像上传 : GatewayRequest
    {
        /// <summary>
        /// 拍照录像上传
        /// </summary>
        public req拍照录像上传()
        {
            service = "yuantu.wap.save.patient.video.log";
            _serviceName = "拍照录像上传";
        }
        /// <summary>
        /// 相对路径
        /// </summary>
        public string fileUrl { get; set; }
        /// <summary>
        /// 记录类型(1充值 2挂号 3预约 4取号 5结算 6住院充值 7住院结算)
        /// </summary>
        public string logType { get; set; }
        /// <summary>
        /// 0图片 1视频
        /// </summary>
        public string isVideo { get; set; }
        public string idNo { get; set; }
        public string name { get; set; }
        public string cardNo { get; set; }
        public string cardType { get; set; }
        public string macAddr { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public string gmtCreate { get; set; }
        
        public override Dictionary<string, string> GetParams()
        {
            var dic = base.GetParams();
            dic[nameof(fileUrl)] = fileUrl;
            dic[nameof(logType)] = logType;
            dic[nameof(isVideo)] = isVideo;
            dic[nameof(idNo)] = idNo;
            dic[nameof(name)] = name;
            dic[nameof(cardNo)] = cardNo;
            dic[nameof(cardType)] = cardType;
            dic[nameof(macAddr)] = macAddr;
            dic[nameof(gmtCreate)] = gmtCreate;
            return dic;
        }

    }


    public class res病人信息查询 : GatewayResponse
    {
        public List<病人信息> data { get; set; }
    }

    public class res病人建档发卡 : GatewayResponse
    {
        public 建档信息 data { get; set; }
    }

    public class res病人基本信息修改 : GatewayResponse
    {
        public 病人基本信息修改信息 data { get; set; }
    }

    public class res病人类别 : GatewayResponse
    {
        public List<病人类别信息> data { get; set; }
    }

    public class res医保科室 : GatewayResponse
    {
        public List<医保科室信息> data { get; set; }
    }

    public class res病人领卡查询 : GatewayResponse
    {
        public List<领卡信息> data { get; set; }
    }

    public class res诊疗卡账户修改密码 : GatewayResponse
    {
        public object data { get; set; }
    }

    public class res诊疗卡密码校验 : GatewayResponse
    {
        public object data { get; set; }
    }

    public class res对账 : GatewayResponse
    {
        public object data { get; set; }
    }

    public class res自助绑定银行卡 : GatewayResponse
    {
        public object data { get; set; }
    }

    public class res自助绑定银行卡解绑 : GatewayResponse
    {
        public object data { get; set; }
    }

    public class res排班科室信息查询 : GatewayResponse
    {
        public List<排班科室信息> data { get; set; }
    }

    public class res排班信息查询 : GatewayResponse
    {
        public List<排班信息> data { get; set; }
    }

    public class res号源明细查询 : GatewayResponse
    {
        public List<号源明细> data { get; set; }
    }

    public class res预约挂号预处理 : GatewayResponse
    {
        public 预约挂号预处理结果 data { get; set; }
    }

    public class res挂号锁号 : GatewayResponse
    {
        public 挂号锁号结果 data { get; set; }
    }

    public class res挂号解锁 : GatewayResponse
    {
        public 挂号解锁结果 data { get; set; }
    }

    public class res预约挂号 : GatewayResponse
    {
        public 挂号结果 data { get; set; }
    }

    public class res预约取号 : GatewayResponse
    {
        public 取号结果 data { get; set; }
    }

    public class res取消预约 : GatewayResponse
    {
        public 取消预约结果 data { get; set; }
    }

    public class res挂号预约记录查询 : GatewayResponse
    {
        public List<挂号预约记录> data { get; set; }
    }

    public class res获取缴费概要信息 : GatewayResponse
    {
        public List<缴费概要信息> data { get; set; }
    }

    public class res获取缴费明细信息 : GatewayResponse
    {
        public List<缴费明细信息> data { get; set; }
    }

    public class res缴费预结算 : GatewayResponse
    {
        public 预结算结果 data { get; set; }
    }

    public class res缴费结算 : GatewayResponse
    {
        public 结算结果 data { get; set; }
    }

    public class res获取已结算记录 : GatewayResponse
    {
        public List<已缴费概要信息> data { get; set; }
    }

    public class res获取已结算明细记录 : GatewayResponse
    {
        public List<结算记录> data { get; set; }
    }

    public class res虚拟账户开通 : GatewayResponse
    {
        public 虚拟账户开通结果 data { get; set; }
    }

    public class res预缴金充值 : GatewayResponse
    {
        public 充值结果 data { get; set; }
    }

    public class res充值数据同步到his系统 : GatewayResponse
    {
        public 充值同步his结果 data { get; set; }
    }

    public class res预约挂号记录同步到his系统 : GatewayResponse
    {
        public 预约挂号同步his结果 data { get; set; }
    }

    public class res交易记录同步到his系统 : GatewayResponse
    {
        public 交易记录同步his结果 data { get; set; }
    }

    public class res查询预缴金充值记录 : GatewayResponse
    {
        public List<充值记录> data { get; set; }
    }

    public class res查询预缴金账户余额 : GatewayResponse
    {
        public 账户余额 data { get; set; }
    }

    public class res预缴金消费 : GatewayResponse
    {
        public 预缴金消费结果 data { get; set; }
    }

    public class res预缴金消费冲正 : GatewayResponse
    {
        public 预缴金消费冲正结果 data { get; set; }
    }

    public class res住院患者信息查询 : GatewayResponse
    {
        public 住院患者信息 data { get; set; }
    }

    public class res住院患者费用明细查询 : GatewayResponse
    {
        public List<住院患者费用明细> data { get; set; }
    }

    public class res住院患者费用明细打印 : GatewayResponse
    {
        public object data { get; set; }
    }

    public class res住院预缴金充值 : GatewayResponse
    {
        public 住院充值结果 data { get; set; }
    }

    public class res住院预缴金充值记录查询 : GatewayResponse
    {
        public List<住院充值记录> data { get; set; }
    }

    public class res检查病人是否能自助机结算 : GatewayResponse
    {
        public 检查病人是否能自助机结算结果 data { get; set; }
    }

    public class res自助出院预结算 : GatewayResponse
    {
        public 自助出院预结算结果 data { get; set; }
    }

    public class res自助出院结算 : GatewayResponse
    {
        public 自助出院结算结果 data { get; set; }
    }

    public class res住院床位信息查询 : GatewayResponse
    {
        public List<床位信息> data { get; set; }
    }

    public class res检验基本信息查询 : GatewayResponse
    {
        public List<检验基本信息> data { get; set; }
    }

    public class res检查结果查询 : GatewayResponse
    {
        public List<检查结果> data { get; set; }
    }

    public class res影像诊断结果查询 : GatewayResponse
    {
        public List<影像诊断结果> data { get; set; }
    }

    public class res医生信息查询 : GatewayResponse
    {
        public List<医生信息> data { get; set; }
    }

    public class res科室信息查询 : GatewayResponse
    {
        public List<科室信息> data { get; set; }
    }

    public class res药品项目查询 : GatewayResponse
    {
        public List<药品项目信息> data { get; set; }
    }

    public class res收费项目查询 : GatewayResponse
    {
        public List<收费项目信息> data { get; set; }
    }

    public class res查询所有医生信息 : GatewayResponse
    {
        public List<医生介绍> data { get; set; }
    }

    public class res就诊情况记录查询 : GatewayResponse
    {
        public List<就诊情况记录> data { get; set; }
    }

    public class res就诊满意度 : GatewayResponse
    {
        public object data { get; set; }
    }

    public class res系统签到 : GatewayResponse
    {
        public 签到结果 data { get; set; }
    }

    public class res信息上报 : GatewayResponse
    {
        public 信息上报结果 data { get; set; }
    }

    public class res清钱箱上报 : GatewayResponse
    {
        public 清钱箱上报结果 data { get; set; }
    }

    public class res创建扫码订单 : GatewayResponse
    {
        public 订单扫码 data { get; set; }
    }

    public class res取消扫码订单 : GatewayResponse
    {
        public 取消订单 data { get; set; }
    }

    public class res查询订单状态 : GatewayResponse
    {
        public 订单状态 data { get; set; }
    }

    public class res操作成功状态上传 : GatewayResponse
    {
        public 状态上传结果 data { get; set; }
    }

    public class res查询网关状态 : GatewayResponse
    {
        public 网关状态 data { get; set; }
    }

    public class res门诊挂号预结算 : GatewayResponse
    {
        public 门诊挂号预结算结果 data { get; set; }
    }

    public class res门诊挂号预结算结果确认 : GatewayResponse
    {
        public 门诊挂号预结算结果确认结果 data { get; set; }
    }

    public class res门诊缴费预结算结果确认 : GatewayResponse
    {
        public 门诊缴费预结算结果确认结果 data { get; set; }
    }

    public class res拍照录像上传 : GatewayResponse
    {
        public 拍照录像上传结果 data { get; set; }
    }
}