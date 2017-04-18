using System;
using System.Collections.Generic;
using DataModels.Base;
namespace DataModels
{
    #pragma warning disable 612
    public partial class 病人信息 : GatewayDataBase
    {
        public string patientId { get; set; }
        public string platformId { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public string idNo { get; set; }
        public string cardNo { get; set; }
        public string guardianNo { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string patientType { get; set; }
        public string accountNo { get; set; }
        public string accBalance { get; set; }
    }

    public partial class 建档信息 : GatewayDataBase
    {
        [Obsolete]
        public string cardNo { get; set; }
        public string securityNo { get; set; }
        public string patientid { get; set; }
        public string patientCard { get; set; }
        public string platformId { get; set; }
        /// <summary>
        /// 建档后余额
        /// </summary>
        public string accBalance { get; set; }
    }

    public partial class 领卡信息 : GatewayDataBase
    {
        public string patientId { get; set; }
        public string platformId { get; set; }
        public string name { get; set; }
        public string nation { get; set; }
        public string sex { get; set; }
        public string birthday { get; set; }
        public string idNo { get; set; }
        public string cardNo { get; set; }
        public string cardStatus { get; set; }
        public string guardianNo { get; set; }
        public string address { get; set; }
        public string phone { get; set; }
        public string patientType { get; set; }
        public string accBalance { get; set; }
        public string operId { get; set; }
        public string flowId { get; set; }
    }

    public partial class 病人基本信息修改信息 : GatewayDataBase
    {
        public string success { get; set; }
    }

    public partial class 病人类别信息 : GatewayDataBase
    {
        public string patientTypeId { get; set; }
        public string patientTypeName { get; set; }
    }

    public partial class 就诊情况记录 : GatewayDataBase
    {
        public string tradeTime { get; set; }
        public string deptName { get; set; }
        public string doctName { get; set; }
        public string info { get; set; }
        public string billNo { get; set; }
    }

    public partial class 缴费概要信息 : GatewayDataBase
    {
        public string billNo { get; set; }
        public string billDate { get; set; }
        public string billType { get; set; }
        public string billFee { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string doctCode { get; set; }
        public string doctName { get; set; }
        public string billGroupNo { get; set; }
        public string extendBalanceInfo { get; set; }
        public List<缴费明细信息> billItem { get; set; }
    }

    public partial class 已缴费概要信息 : GatewayDataBase
    {
        public string billNo { get; set; }
        public string billType { get; set; }
        public string billFee { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string doctCode { get; set; }
        public string doctName { get; set; }
        public string billGroupNo { get; set; }
        public string extendBalanceInfo { get; set; }
        public string tradeTime { get; set; }
        public string tradeMode { get; set; }
        public string receiptNo { get; set; }
        public string selfFee { get; set; }
        public string insurFee { get; set; }
        public string insurFeeInfo { get; set; }
        public string discountFee { get; set; }
        public string operId { get; set; }
        public List<结算记录> billItem { get; set; }
    }

    public partial class 缴费明细信息 : GatewayDataBase
    {
        public string billNo { get; set; }
        public string billDate { get; set; }
        public string billType { get; set; }
        public string billFee { get; set; }
        public string billSeq { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string doctCode { get; set; }
        public string doctName { get; set; }
        public string hosFeeNo { get; set; }
        public string diseaseCode { get; set; }
        public string itemNo { get; set; }
        public string productCode { get; set; }
        public string itemName { get; set; }
        public string itemSpecs { get; set; }
        public string itemLiquid { get; set; }
        public string itemUnits { get; set; }
        public string itemQty { get; set; }
        public string itemPrice { get; set; }
        public string itemCode { get; set; }
        public string execDeptName { get; set; }
        public string ybInfo { get; set; }
    }

    public partial class 预结算结果 : GatewayDataBase
    {
        public string selfFee { get; set; }
        public string insurFee { get; set; }
        public string insurFeeInfo { get; set; }
        public string payAccount { get; set; }
        public string billFee { get; set; }
        public string balBillNo { get; set; }
    }

    public partial class 结算结果 : GatewayDataBase
    {
        public string patientId { get; set; }
        public string selfFee { get; set; }
        public string insurFeeInfo { get; set; }
        public string insurFee { get; set; }
        public string receiptNo { get; set; }
        public string takeMedWin { get; set; }
        public string hasMoreFee { get; set; }
        public string testCode { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string transNo { get; set; }
        public List<缴费明细信息> billItem { get; set; }
    }

    public partial class 结算记录 : GatewayDataBase
    {
        public string tradeTime { get; set; }
        public string receiptNo { get; set; }
        public string billFee { get; set; }
        public string itemName { get; set; }
        public string itemSpecs { get; set; }
        public string itemLiquid { get; set; }
        public string itemUnits { get; set; }
        public string itemQty { get; set; }
        public string itemPrice { get; set; }
        public string cost { get; set; }
    }

    public partial class 充值结果 : GatewayDataBase
    {
        /// <summary>
        /// 订单号
        /// </summary>
        public string orderNo { get; set; }
        /// <summary>
        /// 余额
        /// </summary>
        public string cash { get; set; }
        /// <summary>
        /// 交易流水号
        /// </summary>
        public string sFlowId { get; set; }
    }

    public partial class 充值记录 : GatewayDataBase
    {
        public string tradeMode { get; set; }
        public string accountNo { get; set; }
        public string cash { get; set; }
        public string receiptNo { get; set; }
        public string tradeTime { get; set; }
        public string operId { get; set; }
        /// <summary>
        /// 交易类型(消费、充值)
        /// </summary>
        public string optType { get; set; }
    }

    public partial class 充值同步his结果 : GatewayDataBase
    {
        public string success { get; set; }
    }

    public partial class 预约挂号同步his结果 : GatewayDataBase
    {
        public string success { get; set; }
    }

    public partial class 交易记录同步his结果 : GatewayDataBase
    {
        public string success { get; set; }
    }

    public partial class 账户余额 : GatewayDataBase
    {
        public string receiptNo { get; set; }
        public string cash { get; set; }
    }

    public partial class 预缴金消费结果 : GatewayDataBase
    {
        /// <summary>
        /// 订单Id
        /// </summary>
        public string orderId { get; set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public string sFlowId { get; set; }
        /// <summary>
        /// 消费后余额
        /// </summary>
        public string cash { get; set; }
    }

    public partial class 预缴金消费冲正结果 : GatewayDataBase
    {
        /// <summary>
        /// 流水号
        /// </summary>
        public string logNo { get; set; }
        /// <summary>
        /// 金额
        /// </summary>
        public string cash { get; set; }
    }

    public partial class 排班科室信息 : GatewayDataBase
    {
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string parentDeptCode { get; set; }
        public string parentDeptName { get; set; }
        public string simplePy { get; set; }
        public string fullPy { get; set; }
        public string deptIntro { get; set; }
        public List<预约挂号配置列表> configList { get; set; }
    }

    public partial class 预约挂号配置列表 : GatewayDataBase
    {
        /// <summary>
        /// 挂号类别
        /// </summary>
        public string regType { get; set; }
        /// <summary>
        /// 挂号类别名称
        /// </summary>
        public string regTypeName { get; set; }
        /// <summary>
        /// 挂号方式
        /// </summary>
        public string regMode { get; set; }
    }

    public partial class 排班信息 : GatewayDataBase
    {
        public string medDate { get; set; }
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string parentDeptCode { get; set; }
        public string parentDeptName { get; set; }
        public string doctCode { get; set; }
        public string doctName { get; set; }
        public string doctTech { get; set; }
        public string medAmPm { get; set; }
        public string regfee { get; set; }
        public string treatfee { get; set; }
        public string regAmount { get; set; }
        public string scheduleId { get; set; }
        public string restnum { get; set; }
        /// <summary>
        /// 医院的挂号类别
        /// </summary>
        public string hosRegType { get; set; }
        public string regMode { get; set; }
        public string regType { get; set; }
    }

    public partial class 号源明细 : GatewayDataBase
    {
        public string appoNo { get; set; }
        public string medBegtime { get; set; }
        public string medEndtime { get; set; }
        public string restNum { get; set; }
    }

    public partial class 预约挂号预处理结果 : GatewayDataBase
    {
        public string regFee { get; set; }
        public string treatFee { get; set; }
        public string regAmount { get; set; }
    }

    public partial class 挂号锁号结果 : GatewayDataBase
    {
        /// <summary>
        /// 锁号ID
        /// </summary>
        public string lockId { get; set; }
        /// <summary>
        /// 预约收费模式,预约收费使用,0：不收费1：收费2：用户可选收费
        /// </summary>
        public string appointMode { get; set; }
    }

    public partial class 挂号结果 : GatewayDataBase
    {
        public string orderNo { get; set; }
        public string patientId { get; set; }
        public string deptName { get; set; }
        public string parentDeptName { get; set; }
        public string doctName { get; set; }
        public string regFee { get; set; }
        public string treatFee { get; set; }
        public string regAmount { get; set; }
        public string medDate { get; set; }
        public string address { get; set; }
        public string appoNo { get; set; }
        public string selfFee { get; set; }
        public string insurFee { get; set; }
        public string insurFeeInfo { get; set; }
        public string visitNo { get; set; }
        /// <summary>
        /// 扣费的交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string receiptNo { get; set; }
        /// <summary>
        /// HIS挂号产生的流水号
        /// </summary>
        public string regFlowId { get; set; }
    }

    public partial class 取号结果 : GatewayDataBase
    {
        public string deptName { get; set; }
        public string doctName { get; set; }
        public string regFee { get; set; }
        public string treatFee { get; set; }
        public string regAmount { get; set; }
        public string medDate { get; set; }
        public string address { get; set; }
        public string appoNo { get; set; }
        public string selfFee { get; set; }
        public string insurFee { get; set; }
        public string insurFeeInfo { get; set; }
        public string visitNo { get; set; }
        /// <summary>
        /// 扣费的交易流水号
        /// </summary>
        public string transNo { get; set; }
        /// <summary>
        /// 发票号
        /// </summary>
        public string receiptNo { get; set; }
    }

    public partial class 挂号预约记录 : GatewayDataBase
    {
        public string regNo { get; set; }
        /// <summary>
        /// 序号
        /// </summary>
        public string appoNo { get; set; }
        public string scheduleId { get; set; }
        public string tradeTime { get; set; }
        public string medDate { get; set; }
        public string medTime { get; set; }
        public string medAmPm { get; set; }
        public string hospCode { get; set; }
        public string hospName { get; set; }
        public string deptName { get; set; }
        public string doctName { get; set; }
        public string doctTech { get; set; }
        public string address { get; set; }
        public string appoFrom { get; set; }
        public string regFee { get; set; }
        public string treatFee { get; set; }
        public string regAmount { get; set; }
        /// <summary>
        /// 1预约成功 2取号成功 3取消成功 4已过期
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 取号密码
        /// </summary>
        public string orderNo { get; set; }
        public string doctCode { get; set; }
        public string deptCode { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public string payStatus { get; set; }
        /// <summary>
        /// 锁号ID
        /// </summary>
        public string lockId { get; set; }
    }

    public partial class 取消预约结果 : GatewayDataBase
    {
        public string success { get; set; }
    }

    public partial class 挂号解锁结果 : GatewayDataBase
    {
        public string success { get; set; }
    }

    public partial class 住院患者信息 : GatewayDataBase
    {
        /// <summary>
        /// 住院状态
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 入院时间
        /// </summary>
        public string createDate { get; set; }
        /// <summary>
        /// 出院时间
        /// </summary>
        public string outDate { get; set; }
        /// <summary>
        /// 住院号
        /// </summary>
        public string patientHosId { get; set; }
        /// <summary>
        /// 病区
        /// </summary>
        public string area { get; set; }
        /// <summary>
        /// 床号
        /// </summary>
        public string bedNo { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public string deptName { get; set; }
        /// <summary>
        /// 住院次数
        /// </summary>
        public string visiteId { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 生日
        /// </summary>
        public string birthday { get; set; }
        /// <summary>
        /// 身份证号
        /// </summary>
        public string idNo { get; set; }
        /// <summary>
        /// 诊疗卡号
        /// </summary>
        public string cardNo { get; set; }
        /// <summary>
        /// 监护人身份证号
        /// </summary>
        public string guardianNo { get; set; }
        /// <summary>
        /// 家庭地址
        /// </summary>
        public string address { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public string phone { get; set; }
        /// <summary>
        /// 病人类别
        /// </summary>
        public string patientType { get; set; }
        /// <summary>
        /// 交易账户号
        /// </summary>
        public string accountNo { get; set; }
        /// <summary>
        /// 住院预缴金余额凭证数量
        /// </summary>
        public string hosAccBalanceCount { get; set; }
        /// <summary>
        /// 欠款标志
        /// </summary>
        public string IsArrearage { get; set; }
        [Obsolete]
        public string patientId { get; set; }
        /// <summary>
        /// 住院预缴金余额
        /// </summary>
        public string accBalance { get; set; }
        /// <summary>
        /// 门诊预缴金余额
        /// </summary>
        public string patientAccBalance { get; set; }
        /// <summary>
        /// 累计自负费用
        /// </summary>
        public string cost { get; set; }
        /// <summary>
        /// 余款
        /// </summary>
        public string balance { get; set; }
        /// <summary>
        /// 担保金
        /// </summary>
        public string securityBalance { get; set; }
    }

    public partial class 住院患者费用明细 : GatewayDataBase
    {
        public string tradeTime { get; set; }
        public string itemName { get; set; }
        public string itemSpecs { get; set; }
        public string itemLiquid { get; set; }
        public string itemUnits { get; set; }
        public string itemQty { get; set; }
        public string itemPrice { get; set; }
        public string cost { get; set; }
        public string visited { get; set; }
        public string ratio { get; set; }
        public string deptName { get; set; }
    }

    public partial class 住院充值结果 : GatewayDataBase
    {
        public string receiptNo { get; set; }
        public string cash { get; set; }
        public string visitId { get; set; }
    }

    public partial class 住院充值记录 : GatewayDataBase
    {
        public string receiptNo { get; set; }
        public string tradeMode { get; set; }
        public string tradeTime { get; set; }
        public string cash { get; set; }
        public string visitId { get; set; }
        public string operId { get; set; }
        /// <summary>
        /// 操作人姓名
        /// </summary>
        public string payerName { get; set; }
    }

    public partial class 检查病人是否能自助机结算结果 : GatewayDataBase
    {
        public string status { get; set; }
        public string checkMsg { get; set; }
        public string patientTypeId { get; set; }
        public string ybInfo { get; set; }
    }

    public partial class 自助出院预结算结果 : GatewayDataBase
    {
        public string selfAmount { get; set; }
        public string insuranceAmount { get; set; }
        public string hosAccBalance { get; set; }
    }

    public partial class 自助出院结算结果 : GatewayDataBase
    {
        /// <summary>
        /// 收款员
        /// </summary>
        public string Operator { get; set; }
        /// <summary>
        /// 合计金额
        /// </summary>
        public string cash { get; set; }
        /// <summary>
        /// 科室
        /// </summary>
        public string deptName { get; set; }
        /// <summary>
        /// 入院时间
        /// </summary>
        public string inDate { get; set; }
        /// <summary>
        /// 票据号
        /// </summary>
        public string InvoiceNo { get; set; }
    }

    public partial class 床位信息 : GatewayDataBase
    {
        /// <summary>
        /// 病区编码
        /// </summary>
        public string wardCode { get; set; }
        /// <summary>
        /// 病区名称
        /// </summary>
        public string wardName { get; set; }
        /// <summary>
        /// 总床位数
        /// </summary>
        public string totalBedNum { get; set; }
        /// <summary>
        /// 剩余床位数
        /// </summary>
        public string leftBedNum { get; set; }
    }

    public partial class 虚拟账户开通结果 : GatewayDataBase
    {
        public string accountNo { get; set; }
        public string accountId { get; set; }
    }

    public partial class 检验基本信息 : GatewayDataBase
    {
        public string reportId { get; set; }
        public string patientId { get; set; }
        public string patientName { get; set; }
        public string age { get; set; }
        public string sex { get; set; }
        public string cardNo { get; set; }
        public string inhospId { get; set; }
        public string examType { get; set; }
        public string checkPart { get; set; }
        public string checkDoc { get; set; }
        public string sendTime { get; set; }
        public string resultTime { get; set; }
        /// <summary>
        /// 检验报告单审核日期
        /// </summary>
        public string auditTime { get; set; }
        public string printTimes { get; set; }
        public string remark { get; set; }
        /// <summary>
        /// 送检医生
        /// </summary>
        public string inspectDoctor { get; set; }
        public List<检验项目> examItem { get; set; }
        /// <summary>
        /// 核对医生
        /// </summary>
        public string auditDoc { get; set; }
        /// <summary>
        /// 临床诊断
        /// </summary>
        public string examResult { get; set; }
        /// <summary>
        /// 标本种类
        /// </summary>
        public string sampleType { get; set; }
    }

    public partial class 检验项目 : GatewayDataBase
    {
        public string itemName { get; set; }
        public string itemRealValue { get; set; }
        public string itemRefRange { get; set; }
        public string itemMark { get; set; }
        /// <summary>
        /// 单位
        /// </summary>
        public string itemUnits { get; set; }
        /// <summary>
        /// 定性结果
        /// </summary>
        public string quaResult { get; set; }
        /// <summary>
        /// 项目名称缩写
        /// </summary>
        public string itemAbbr { get; set; }
    }

    public partial class 检查结果 : GatewayDataBase
    {
        public string reportId { get; set; }
        public string patientId { get; set; }
        public string cardNo { get; set; }
        public string patientName { get; set; }
        public string rechkDt { get; set; }
        public string rechkUserName { get; set; }
        public string lastPrintDt { get; set; }
        public string reportDt { get; set; }
        public string printCount { get; set; }
        public string exprintCount { get; set; }
        public string unprintFlag { get; set; }
        public string unprintReason { get; set; }
    }

    public partial class 影像诊断结果 : GatewayDataBase
    {
        /// <summary>
        /// 卡号
        /// </summary>
        public string cardNo { get; set; }
        /// <summary>
        /// 送检医生工号
        /// </summary>
        public string inspecDoctCode { get; set; }
        /// <summary>
        /// 送检医生姓名
        /// </summary>
        public string inspecDoctName { get; set; }
        /// <summary>
        /// 送检时间
        /// </summary>
        public string inspecTime { get; set; }
        /// <summary>
        /// 检查日期
        /// </summary>
        public string checkDate { get; set; }
        /// <summary>
        /// 审核医生工号
        /// </summary>
        public string auditDoctCode { get; set; }
        /// <summary>
        /// 审核医生姓名
        /// </summary>
        public string auditDoctName { get; set; }
        /// <summary>
        /// 检查状态
        /// </summary>
        public string checkStatus { get; set; }
        /// <summary>
        /// 检查描述
        /// </summary>
        public string checkDesc { get; set; }
        /// <summary>
        /// 检查结果
        /// </summary>
        public string checkResult { get; set; }
        /// <summary>
        /// 审核日期
        /// </summary>
        public string auditDate { get; set; }
        /// <summary>
        /// 检查号码
        /// </summary>
        public string checkNo { get; set; }
        /// <summary>
        /// 病案号
        /// </summary>
        public string patientNo { get; set; }
        /// <summary>
        /// 病区名称
        /// </summary>
        public string wardName { get; set; }
        /// <summary>
        /// 病区床号
        /// </summary>
        public string wardBed { get; set; }
        /// <summary>
        /// 病人性别
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 病人年龄
        /// </summary>
        public string age { get; set; }
        /// <summary>
        /// 送检科室名称
        /// </summary>
        public string inspecDeptName { get; set; }
        /// <summary>
        /// 姓名
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 检查项目
        /// </summary>
        public string checkItem { get; set; }
        /// <summary>
        /// 身份证号码
        /// </summary>
        public string idNo { get; set; }
        /// <summary>
        /// 检查诊断
        /// </summary>
        public string diagnosis { get; set; }
        /// <summary>
        /// 检查建议
        /// </summary>
        public string suggestion { get; set; }
        /// <summary>
        /// 报告时间
        /// </summary>
        public string reportTime { get; set; }
    }

    public partial class 医生信息 : GatewayDataBase
    {
        public string doctCode { get; set; }
        public string doctName { get; set; }
        public string doctProfe { get; set; }
        public string doctIntro { get; set; }
        public string doctSpec { get; set; }
        public string sex { get; set; }
        public string deptName { get; set; }
    }

    public partial class 科室信息 : GatewayDataBase
    {
        public string deptCode { get; set; }
        public string deptName { get; set; }
        public string deptIntro { get; set; }
    }

    public partial class 药品项目信息 : GatewayDataBase
    {
        /// <summary>
        /// 药品编码
        /// </summary>
        public string medicineCode { get; set; }
        /// <summary>
        /// 药品名称
        /// </summary>
        public string medicineName { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string specifications { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public string price { get; set; }
        /// <summary>
        /// 包装单位
        /// </summary>
        public string packagingUnit { get; set; }
        /// <summary>
        /// 最小单位
        /// </summary>
        public string miniUnit { get; set; }
        /// <summary>
        /// 计价单位
        /// </summary>
        public string priceUnit { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        public string producer { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 医保报销比例
        /// </summary>
        public string medicalRatio { get; set; }
    }

    public partial class 收费项目信息 : GatewayDataBase
    {
        /// <summary>
        /// 项目编码
        /// </summary>
        public string itemCode { get; set; }
        /// <summary>
        /// 项目名称
        /// </summary>
        public string itemName { get; set; }
        /// <summary>
        /// 规格
        /// </summary>
        public string specifications { get; set; }
        /// <summary>
        /// 价格
        /// </summary>
        public string price { get; set; }
        /// <summary>
        /// 计价单位
        /// </summary>
        public string priceUnit { get; set; }
        /// <summary>
        /// 生产厂家
        /// </summary>
        public string producer { get; set; }
        /// <summary>
        /// 类型
        /// </summary>
        public string type { get; set; }
        /// <summary>
        /// 医保报销比例
        /// </summary>
        public string medicalRatio { get; set; }
    }

    public partial class 医生介绍 : GatewayDataBase
    {
        /// <summary>
        /// 医生代码
        /// </summary>
        public string doctCode { get; set; }
        /// <summary>
        /// 医生姓名
        /// </summary>
        public string doctName { get; set; }
        /// <summary>
        /// 科室名称的全拼
        /// </summary>
        public string doctPY { get; set; }
        /// <summary>
        /// 科室名称的简拼
        /// </summary>
        public string doctSimplePY { get; set; }
        /// <summary>
        /// 性别
        /// </summary>
        public string sex { get; set; }
        /// <summary>
        /// 医生头像短路径
        /// </summary>
        public string doctLogo { get; set; }
        /// <summary>
        /// 医生级别
        /// </summary>
        public string doctLevel { get; set; }
        /// <summary>
        /// 医生职称
        /// </summary>
        public string doctProfe { get; set; }
        /// <summary>
        /// 医生特长
        /// </summary>
        public string doctSpec { get; set; }
        /// <summary>
        /// 医生介绍
        /// </summary>
        public string doctIntro { get; set; }
        /// <summary>
        /// 医院id在排班系统中的编号
        /// </summary>
        public string corpCode { get; set; }
        /// <summary>
        /// 科室代码
        /// </summary>
        public string deptCode { get; set; }
        /// <summary>
        /// 科室名称
        /// </summary>
        public string deptName { get; set; }
        /// <summary>
        /// 医生电话
        /// </summary>
        public string doctPhoneNum { get; set; }
        /// <summary>
        /// 医生头像全路径
        /// </summary>
        public string doctPictureIntranetUrl { get; set; }
    }

    public partial class 订单扫码 : GatewayDataBase
    {
        /// <summary>
        /// 用户平台支付流水
        /// </summary>
        public string outTradeNo { get; set; }
        /// <summary>
        /// 二维码串
        /// </summary>
        public string qrCode { get; set; }
    }

    public partial class 取消订单 : GatewayDataBase
    {
        /// <summary>
        /// 用户平台支付流水
        /// </summary>
        public string outTradeNo { get; set; }
        /// <summary>
        /// 用户平台退款单号
        /// </summary>
        public string outRefundNo { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public string fee { get; set; }
    }

    public partial class 订单状态 : GatewayDataBase
    {
        /// <summary>
        /// 用户平台支付流水
        /// </summary>
        public string outTradeNo { get; set; }
        /// <summary>
        /// 退款金额
        /// </summary>
        public string fee { get; set; }
        /// <summary>
        /// 101:处理中 200:支付成功 201:支付失败 400:失效订单 500:退款成功 501:退款失败
        /// </summary>
        public string status { get; set; }
        /// <summary>
        /// 支付时间
        /// </summary>
        public string paymentTime { get; set; }
        public string outRefundNo { get; set; }
        /// <summary>
        /// 状态文本
        /// </summary>
        public string statusDes { get; set; }
        /// <summary>
        /// 第三方订单号
        /// </summary>
        public string outPayNo { get; set; }
        /// <summary>
        /// 支付账户
        /// </summary>
        public string buyerAccount { get; set; }
    }

    public partial class 状态上传结果 : GatewayDataBase
    {
        public string success { get; set; }
    }

    public partial class 医保科室信息 : GatewayDataBase
    {
        /// <summary>
        /// HIS科室编码
        /// </summary>
        public string HisDeptCode { get; set; }
        /// <summary>
        /// HIS科室名称
        /// </summary>
        public string  HisDeptName { get; set; }
        /// <summary>
        /// 医保科室编码
        /// </summary>
        public string SiDeptCode { get; set; }
        /// <summary>
        /// 医保科室名称
        /// </summary>
        public string SiDeptName { get; set; }
    }

    public partial class 医保结算信息 : GatewayDataBase
    {
        /// <summary>
        /// 自费金额
        /// </summary>
        public string selfMoney { get; set; }
        /// <summary>
        /// 统筹支付
        /// </summary>
        public string commonMoney { get; set; }
        /// <summary>
        /// 账户支付
        /// </summary>
        public string accountMoney { get; set; }
        /// <summary>
        /// 医保余额
        /// </summary>
        public string lastBalance { get; set; }
        /// <summary>
        /// 医院支付
        /// </summary>
        public string hospitalMoney { get; set; }
    }

    public partial class 网关状态 : GatewayDataBase
    {
        /// <summary>
        /// 排班系统状态true脱机状态false联机状态
        /// </summary>
        public string appo { get; set; }
        /// <summary>
        /// 结算平台状态true脱机状态false联机状态
        /// </summary>
        public string platform { get; set; }
    }

    public partial class 门诊挂号预结算结果 : GatewayDataBase
    {
        public string insurFeeInfo { get; set; }
    }

    public partial class 门诊挂号预结算结果确认结果 : GatewayDataBase
    {
        public string patientId { get; set; }
        public string deptName { get; set; }
        public string parentDeptName { get; set; }
        public string doctName { get; set; }
        public string regFee { get; set; }
        public string treatFee { get; set; }
        public string regAmount { get; set; }
        public string medDate { get; set; }
        public string insurFeeInfo { get; set; }
        public string selfFee { get; set; }
        public string insurFee { get; set; }
        public string transNo { get; set; }
    }

    public partial class 门诊缴费预结算结果确认结果 : GatewayDataBase
    {
        public string selfFee { get; set; }
        public string insurFee { get; set; }
        public string insurFeeInfo { get; set; }
        public string transNo { get; set; }
    }

    public partial class 签到结果 : GatewayDataBase
    {
        /// <summary>
        /// UTC当前时间
        /// </summary>
        public string currentDate { get; set; }
        /// <summary>
        /// 是否成功
        /// </summary>
        public string success { get; set; }
    }

    public partial class 信息上报结果 : GatewayDataBase
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public string success { get; set; }
    }

    public partial class 清钱箱上报结果 : GatewayDataBase
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public string success { get; set; }
    }

    public partial class 拍照录像上传结果 : GatewayDataBase
    {
        /// <summary>
        /// 是否成功
        /// </summary>
        public string success { get; set; }
    }

#pragma warning restore 612
}