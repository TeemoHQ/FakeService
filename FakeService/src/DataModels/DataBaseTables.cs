using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace DataBaseTables
{
    #region model
    public partial class 医院信息
    {
		[Key] 
        public string id { get; set; }
				 
	    public string name { get; set; }
		 
	    public string coder { get; set; }
		 
	    public string extend { get; set; }
    }

    public partial class 病人信息
    {
		[Key] 
        public string patientId { get; set; }
				 
	    public string hospitalId { get; set; }
		 
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

    public partial class 建档信息
    {
		[Key] 
        public string cardNo { get; set; }
				 
	    public string hospitalId { get; set; }
		 
	    public string securityNo { get; set; }
		 
	    public string patientid { get; set; }
		 
	    public string patientCard { get; set; }
		 
	    public string platformId { get; set; }
        /// <summary>
        /// 建档后余额
        /// </summary>
		 
	    public string accBalance { get; set; }
    }

    public partial class 缴费明细信息
    {
		[Key] 
        public string id { get; set; }
				 
	    public string billNo { get; set; }
		 
	    public string hospitalId { get; set; }
		 
	    public string patientId { get; set; }
		 
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
        /// <summary>
        /// 1未结算 2已结算
        /// </summary>
		 
	    public string status { get; set; }
		 
	    public string tradeTime { get; set; }
    }

    public partial class 结算记录
    {
		[Key] 
        public string receiptNo { get; set; }
				 
	    public string hospitalId { get; set; }
		 
	    public string billNo { get; set; }
		 
	    public string patientId { get; set; }
		 
	    public string tradeTime { get; set; }
		 
	    public string billFee { get; set; }
		 
	    public string itemName { get; set; }
		 
	    public string itemSpecs { get; set; }
		 
	    public string itemLiquid { get; set; }
		 
	    public string itemUnits { get; set; }
		 
	    public string itemQty { get; set; }
		 
	    public string itemPrice { get; set; }
		 
	    public string cost { get; set; }
		 
	    public string billType { get; set; }
    }

    public partial class 科室信息
    {
		[Key] 
        public string deptCode { get; set; }
				 
	    public string hospitalId { get; set; }
		 
	    public string deptName { get; set; }
		 
	    public string parentDeptCode { get; set; }
		 
	    public string parentDeptName { get; set; }
		 
	    public string simplePy { get; set; }
		 
	    public string fullPy { get; set; }
		 
	    public string deptIntro { get; set; }
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

    public partial class 医生介绍
    {
        /// <summary>
        /// 医生代码
        /// </summary>
		[Key] 
        public string doctCode { get; set; }
				 
	    public string hospitalId { get; set; }
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

    public partial class 排班信息
    {
		[Key] 
        public string scheduleId { get; set; }
				 
	    public string hospitalId { get; set; }
		 
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
        /// <summary>
        /// 医院的挂号类别
        /// </summary>
		 
	    public string hosRegType { get; set; }
		 
	    public string regMode { get; set; }
		 
	    public string regType { get; set; }
    }

    public partial class 号源明细
    {
		[Key] 
        public string appoNo { get; set; }
				 
	    public string hospitalId { get; set; }
		 
	    public string scheduleId { get; set; }
		 
	    public string medBegtime { get; set; }
		 
	    public string medEndtime { get; set; }
		 
	    public string restNum { get; set; }
		 
	    public string isEnable { get; set; }
		 
	    public string temp { get; set; }
    }

    public partial class 挂号预约记录
    {
		[Key] 
        public string regNo { get; set; }
		        /// <summary>
        /// 序号
        /// </summary>
		 
	    public string appoNo { get; set; }
		 
	    public string scheduleId { get; set; }
		 
	    public string hospitalId { get; set; }
		 
	    public string patientId { get; set; }
		 
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

    public partial class 充值记录
    {
		[Key] 
        public string No { get; set; }
				 
	    public string hospitalId { get; set; }
		 
	    public string cardNo { get; set; }
		 
	    public string cardType { get; set; }
		 
	    public string patientId { get; set; }
		 
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

    public partial class 住院患者信息
    {
        /// <summary>
        /// 住院号
        /// </summary>
		[Key] 
        public string patientHosId { get; set; }
				 
	    public string hospitalId { get; set; }
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

    public partial class 住院患者费用明细
    {
		[Key] 
        public string id { get; set; }
				 
	    public string hospitalId { get; set; }
        /// <summary>
        /// 住院号
        /// </summary>
		 
	    public string patientHosId { get; set; }
		 
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

    public partial class 住院充值记录
    {
		[Key] 
        public string receiptNo { get; set; }
				 
	    public string hospitalId { get; set; }
		 
	    public string cardNo { get; set; }
		 
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

    public partial class 床位信息
    {
        /// <summary>
        /// 病区编码
        /// </summary>
		[Key] 
        public string wardCode { get; set; }
				 
	    public string hospitalId { get; set; }
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

    public partial class 检验基本信息
    {
		[Key] 
        public string reportId { get; set; }
				 
	    public string hospitalId { get; set; }
		 
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

    public partial class 检验项目
    {
		[Key] 
        public string id { get; set; }
				 
	    public string patientId { get; set; }
		 
	    public string hospitalId { get; set; }
		 
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

    public partial class 影像诊断结果
    {
		[Key] 
        public string id { get; set; }
				 
	    public string patientId { get; set; }
		 
	    public string hospitalId { get; set; }
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

    public partial class 药品项目信息
    {
        /// <summary>
        /// 药品编码
        /// </summary>
		[Key] 
        public string medicineCode { get; set; }
				 
	    public string hospitalId { get; set; }
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

    public partial class 收费项目信息
    {
        /// <summary>
        /// 项目编码
        /// </summary>
		[Key] 
        public string itemCode { get; set; }
				 
	    public string hospitalId { get; set; }
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

    public partial class 医保科室信息
    {
        /// <summary>
        /// HIS科室编码
        /// </summary>
		[Key] 
        public string HisDeptCode { get; set; }
				 
	    public string hospitalId { get; set; }
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

    public partial class 医保结算信息
    {
		[Key] 
        public string id { get; set; }
				 
	    public string patientId { get; set; }
		 
	    public string hospitalId { get; set; }
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

    #endregion 
	//dotnet ef migrations add MyFirstMigration
    //dotnet ef database update
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions<MyDBContext> options) : base(options)
        {

        }
	    #region DbContext
		public DbSet<医院信息> 医院信息 { get; set; }
        public DbSet<病人信息> 病人信息 { get; set; }
        public DbSet<建档信息> 建档信息 { get; set; }
        public DbSet<缴费明细信息> 缴费明细信息 { get; set; }
        public DbSet<结算记录> 结算记录 { get; set; }
        public DbSet<科室信息> 科室信息 { get; set; }
        public DbSet<医生介绍> 医生介绍 { get; set; }
        public DbSet<排班信息> 排班信息 { get; set; }
        public DbSet<号源明细> 号源明细 { get; set; }
        public DbSet<挂号预约记录> 挂号预约记录 { get; set; }
        public DbSet<充值记录> 充值记录 { get; set; }
        public DbSet<住院患者信息> 住院患者信息 { get; set; }
        public DbSet<住院患者费用明细> 住院患者费用明细 { get; set; }
        public DbSet<住院充值记录> 住院充值记录 { get; set; }
        public DbSet<床位信息> 床位信息 { get; set; }
        public DbSet<检验基本信息> 检验基本信息 { get; set; }
        public DbSet<检验项目> 检验项目 { get; set; }
        public DbSet<影像诊断结果> 影像诊断结果 { get; set; }
        public DbSet<药品项目信息> 药品项目信息 { get; set; }
        public DbSet<收费项目信息> 收费项目信息 { get; set; }
        public DbSet<医保科室信息> 医保科室信息 { get; set; }
        public DbSet<医保结算信息> 医保结算信息 { get; set; }
        #endregion
	}

}