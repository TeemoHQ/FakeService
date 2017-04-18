using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using DataBaseTables;

namespace FakeService.Migrations
{
    [DbContext(typeof(MyDBContext))]
    [Migration("20170418033119_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752");

            modelBuilder.Entity("DataBaseTables.病人信息", b =>
                {
                    b.Property<string>("patientId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("accBalance");

                    b.Property<string>("accountNo");

                    b.Property<string>("address");

                    b.Property<string>("birthday");

                    b.Property<string>("cardNo");

                    b.Property<string>("guardianNo");

                    b.Property<string>("hospitalId");

                    b.Property<string>("idNo");

                    b.Property<string>("name");

                    b.Property<string>("patientType");

                    b.Property<string>("phone");

                    b.Property<string>("platformId");

                    b.Property<string>("sex");

                    b.HasKey("patientId");

                    b.ToTable("病人信息");
                });

            modelBuilder.Entity("DataBaseTables.充值记录", b =>
                {
                    b.Property<string>("No")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("accountNo");

                    b.Property<string>("cardNo");

                    b.Property<string>("cardType");

                    b.Property<string>("cash");

                    b.Property<string>("hospitalId");

                    b.Property<string>("operId");

                    b.Property<string>("optType");

                    b.Property<string>("patientId");

                    b.Property<string>("receiptNo");

                    b.Property<string>("tradeMode");

                    b.Property<string>("tradeTime");

                    b.HasKey("No");

                    b.ToTable("充值记录");
                });

            modelBuilder.Entity("DataBaseTables.床位信息", b =>
                {
                    b.Property<string>("wardCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("hospitalId");

                    b.Property<string>("leftBedNum");

                    b.Property<string>("totalBedNum");

                    b.Property<string>("wardName");

                    b.HasKey("wardCode");

                    b.ToTable("床位信息");
                });

            modelBuilder.Entity("DataBaseTables.挂号预约记录", b =>
                {
                    b.Property<string>("regNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("address");

                    b.Property<string>("appoFrom");

                    b.Property<string>("appoNo");

                    b.Property<string>("deptCode");

                    b.Property<string>("deptName");

                    b.Property<string>("doctCode");

                    b.Property<string>("doctName");

                    b.Property<string>("doctTech");

                    b.Property<string>("hospCode");

                    b.Property<string>("hospName");

                    b.Property<string>("hospitalId");

                    b.Property<string>("lockId");

                    b.Property<string>("medAmPm");

                    b.Property<string>("medDate");

                    b.Property<string>("medTime");

                    b.Property<string>("orderNo");

                    b.Property<string>("patientId");

                    b.Property<string>("payStatus");

                    b.Property<string>("regAmount");

                    b.Property<string>("regFee");

                    b.Property<string>("scheduleId");

                    b.Property<string>("status");

                    b.Property<string>("tradeTime");

                    b.Property<string>("treatFee");

                    b.HasKey("regNo");

                    b.ToTable("挂号预约记录");
                });

            modelBuilder.Entity("DataBaseTables.号源明细", b =>
                {
                    b.Property<string>("appoNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("hospitalId");

                    b.Property<string>("isEnable");

                    b.Property<string>("medBegtime");

                    b.Property<string>("medEndtime");

                    b.Property<string>("restNum");

                    b.Property<string>("scheduleId");

                    b.Property<string>("temp");

                    b.HasKey("appoNo");

                    b.ToTable("号源明细");
                });

            modelBuilder.Entity("DataBaseTables.检验基本信息", b =>
                {
                    b.Property<string>("reportId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("age");

                    b.Property<string>("auditDoc");

                    b.Property<string>("auditTime");

                    b.Property<string>("cardNo");

                    b.Property<string>("checkDoc");

                    b.Property<string>("checkPart");

                    b.Property<string>("examResult");

                    b.Property<string>("examType");

                    b.Property<string>("hospitalId");

                    b.Property<string>("inhospId");

                    b.Property<string>("inspectDoctor");

                    b.Property<string>("patientId");

                    b.Property<string>("patientName");

                    b.Property<string>("printTimes");

                    b.Property<string>("remark");

                    b.Property<string>("resultTime");

                    b.Property<string>("sampleType");

                    b.Property<string>("sendTime");

                    b.Property<string>("sex");

                    b.HasKey("reportId");

                    b.ToTable("检验基本信息");
                });

            modelBuilder.Entity("DataBaseTables.检验项目", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("hospitalId");

                    b.Property<string>("itemAbbr");

                    b.Property<string>("itemMark");

                    b.Property<string>("itemName");

                    b.Property<string>("itemRealValue");

                    b.Property<string>("itemRefRange");

                    b.Property<string>("itemUnits");

                    b.Property<string>("patientId");

                    b.Property<string>("quaResult");

                    b.HasKey("id");

                    b.ToTable("检验项目");
                });

            modelBuilder.Entity("DataBaseTables.建档信息", b =>
                {
                    b.Property<string>("cardNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("accBalance");

                    b.Property<string>("hospitalId");

                    b.Property<string>("patientCard");

                    b.Property<string>("patientid");

                    b.Property<string>("platformId");

                    b.Property<string>("securityNo");

                    b.HasKey("cardNo");

                    b.ToTable("建档信息");
                });

            modelBuilder.Entity("DataBaseTables.缴费明细信息", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("billDate");

                    b.Property<string>("billFee");

                    b.Property<string>("billNo");

                    b.Property<string>("billSeq");

                    b.Property<string>("billType");

                    b.Property<string>("deptCode");

                    b.Property<string>("deptName");

                    b.Property<string>("diseaseCode");

                    b.Property<string>("doctCode");

                    b.Property<string>("doctName");

                    b.Property<string>("execDeptName");

                    b.Property<string>("hosFeeNo");

                    b.Property<string>("hospitalId");

                    b.Property<string>("itemCode");

                    b.Property<string>("itemLiquid");

                    b.Property<string>("itemName");

                    b.Property<string>("itemNo");

                    b.Property<string>("itemPrice");

                    b.Property<string>("itemQty");

                    b.Property<string>("itemSpecs");

                    b.Property<string>("itemUnits");

                    b.Property<string>("patientId");

                    b.Property<string>("productCode");

                    b.Property<string>("status");

                    b.Property<string>("tradeTime");

                    b.Property<string>("ybInfo");

                    b.HasKey("id");

                    b.ToTable("缴费明细信息");
                });

            modelBuilder.Entity("DataBaseTables.结算记录", b =>
                {
                    b.Property<string>("receiptNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("billFee");

                    b.Property<string>("billNo");

                    b.Property<string>("billType");

                    b.Property<string>("cost");

                    b.Property<string>("hospitalId");

                    b.Property<string>("itemLiquid");

                    b.Property<string>("itemName");

                    b.Property<string>("itemPrice");

                    b.Property<string>("itemQty");

                    b.Property<string>("itemSpecs");

                    b.Property<string>("itemUnits");

                    b.Property<string>("patientId");

                    b.Property<string>("tradeTime");

                    b.HasKey("receiptNo");

                    b.ToTable("结算记录");
                });

            modelBuilder.Entity("DataBaseTables.科室信息", b =>
                {
                    b.Property<string>("deptCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("deptIntro");

                    b.Property<string>("deptName");

                    b.Property<string>("fullPy");

                    b.Property<string>("hospitalId");

                    b.Property<string>("parentDeptCode");

                    b.Property<string>("parentDeptName");

                    b.Property<string>("regMode");

                    b.Property<string>("regType");

                    b.Property<string>("regTypeName");

                    b.Property<string>("simplePy");

                    b.HasKey("deptCode");

                    b.ToTable("科室信息");
                });

            modelBuilder.Entity("DataBaseTables.排班信息", b =>
                {
                    b.Property<string>("scheduleId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("deptCode");

                    b.Property<string>("deptName");

                    b.Property<string>("doctCode");

                    b.Property<string>("doctName");

                    b.Property<string>("doctTech");

                    b.Property<string>("hosRegType");

                    b.Property<string>("hospitalId");

                    b.Property<string>("medAmPm");

                    b.Property<string>("medDate");

                    b.Property<string>("parentDeptCode");

                    b.Property<string>("parentDeptName");

                    b.Property<string>("regAmount");

                    b.Property<string>("regMode");

                    b.Property<string>("regType");

                    b.Property<string>("regfee");

                    b.Property<string>("treatfee");

                    b.HasKey("scheduleId");

                    b.ToTable("排班信息");
                });

            modelBuilder.Entity("DataBaseTables.收费项目信息", b =>
                {
                    b.Property<string>("itemCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("hospitalId");

                    b.Property<string>("itemName");

                    b.Property<string>("medicalRatio");

                    b.Property<string>("price");

                    b.Property<string>("priceUnit");

                    b.Property<string>("producer");

                    b.Property<string>("specifications");

                    b.Property<string>("type");

                    b.HasKey("itemCode");

                    b.ToTable("收费项目信息");
                });

            modelBuilder.Entity("DataBaseTables.药品项目信息", b =>
                {
                    b.Property<string>("medicineCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("hospitalId");

                    b.Property<string>("medicalRatio");

                    b.Property<string>("medicineName");

                    b.Property<string>("miniUnit");

                    b.Property<string>("packagingUnit");

                    b.Property<string>("price");

                    b.Property<string>("priceUnit");

                    b.Property<string>("producer");

                    b.Property<string>("specifications");

                    b.Property<string>("type");

                    b.HasKey("medicineCode");

                    b.ToTable("药品项目信息");
                });

            modelBuilder.Entity("DataBaseTables.医保结算信息", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("accountMoney");

                    b.Property<string>("commonMoney");

                    b.Property<string>("hospitalId");

                    b.Property<string>("hospitalMoney");

                    b.Property<string>("lastBalance");

                    b.Property<string>("patientId");

                    b.Property<string>("selfMoney");

                    b.HasKey("id");

                    b.ToTable("医保结算信息");
                });

            modelBuilder.Entity("DataBaseTables.医保科室信息", b =>
                {
                    b.Property<string>("HisDeptCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HisDeptName");

                    b.Property<string>("SiDeptCode");

                    b.Property<string>("SiDeptName");

                    b.Property<string>("hospitalId");

                    b.HasKey("HisDeptCode");

                    b.ToTable("医保科室信息");
                });

            modelBuilder.Entity("DataBaseTables.医生介绍", b =>
                {
                    b.Property<string>("doctCode")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("corpCode");

                    b.Property<string>("deptCode");

                    b.Property<string>("deptName");

                    b.Property<string>("doctIntro");

                    b.Property<string>("doctLevel");

                    b.Property<string>("doctLogo");

                    b.Property<string>("doctName");

                    b.Property<string>("doctPY");

                    b.Property<string>("doctPhoneNum");

                    b.Property<string>("doctPictureIntranetUrl");

                    b.Property<string>("doctProfe");

                    b.Property<string>("doctSimplePY");

                    b.Property<string>("doctSpec");

                    b.Property<string>("hospitalId");

                    b.Property<string>("sex");

                    b.HasKey("doctCode");

                    b.ToTable("医生介绍");
                });

            modelBuilder.Entity("DataBaseTables.影像诊断结果", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("age");

                    b.Property<string>("auditDate");

                    b.Property<string>("auditDoctCode");

                    b.Property<string>("auditDoctName");

                    b.Property<string>("cardNo");

                    b.Property<string>("checkDate");

                    b.Property<string>("checkDesc");

                    b.Property<string>("checkItem");

                    b.Property<string>("checkNo");

                    b.Property<string>("checkResult");

                    b.Property<string>("checkStatus");

                    b.Property<string>("diagnosis");

                    b.Property<string>("hospitalId");

                    b.Property<string>("idNo");

                    b.Property<string>("inspecDeptName");

                    b.Property<string>("inspecDoctCode");

                    b.Property<string>("inspecDoctName");

                    b.Property<string>("inspecTime");

                    b.Property<string>("name");

                    b.Property<string>("patientId");

                    b.Property<string>("patientNo");

                    b.Property<string>("reportTime");

                    b.Property<string>("sex");

                    b.Property<string>("suggestion");

                    b.Property<string>("wardBed");

                    b.Property<string>("wardName");

                    b.HasKey("id");

                    b.ToTable("影像诊断结果");
                });

            modelBuilder.Entity("DataBaseTables.住院充值记录", b =>
                {
                    b.Property<string>("receiptNo")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cardNo");

                    b.Property<string>("cash");

                    b.Property<string>("hospitalId");

                    b.Property<string>("operId");

                    b.Property<string>("payerName");

                    b.Property<string>("tradeMode");

                    b.Property<string>("tradeTime");

                    b.Property<string>("visitId");

                    b.HasKey("receiptNo");

                    b.ToTable("住院充值记录");
                });

            modelBuilder.Entity("DataBaseTables.住院患者费用明细", b =>
                {
                    b.Property<string>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("cost");

                    b.Property<string>("deptName");

                    b.Property<string>("hospitalId");

                    b.Property<string>("itemLiquid");

                    b.Property<string>("itemName");

                    b.Property<string>("itemPrice");

                    b.Property<string>("itemQty");

                    b.Property<string>("itemSpecs");

                    b.Property<string>("itemUnits");

                    b.Property<string>("patientHosId");

                    b.Property<string>("ratio");

                    b.Property<string>("tradeTime");

                    b.Property<string>("visited");

                    b.HasKey("id");

                    b.ToTable("住院患者费用明细");
                });

            modelBuilder.Entity("DataBaseTables.住院患者信息", b =>
                {
                    b.Property<string>("patientHosId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("IsArrearage");

                    b.Property<string>("accBalance");

                    b.Property<string>("accountNo");

                    b.Property<string>("address");

                    b.Property<string>("area");

                    b.Property<string>("balance");

                    b.Property<string>("bedNo");

                    b.Property<string>("birthday");

                    b.Property<string>("cardNo");

                    b.Property<string>("cost");

                    b.Property<string>("createDate");

                    b.Property<string>("deptName");

                    b.Property<string>("guardianNo");

                    b.Property<string>("hosAccBalanceCount");

                    b.Property<string>("hospitalId");

                    b.Property<string>("idNo");

                    b.Property<string>("name");

                    b.Property<string>("outDate");

                    b.Property<string>("patientAccBalance");

                    b.Property<string>("patientId");

                    b.Property<string>("patientType");

                    b.Property<string>("phone");

                    b.Property<string>("securityBalance");

                    b.Property<string>("sex");

                    b.Property<string>("status");

                    b.Property<string>("visiteId");

                    b.HasKey("patientHosId");

                    b.ToTable("住院患者信息");
                });
        }
    }
}
