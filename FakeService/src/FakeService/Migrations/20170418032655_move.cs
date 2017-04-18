using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeService.Migrations
{
    public partial class move : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "病人信息",
                columns: table => new
                {
                    patientId = table.Column<string>(nullable: false),
                    accBalance = table.Column<string>(nullable: true),
                    accountNo = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    birthday = table.Column<string>(nullable: true),
                    cardNo = table.Column<string>(nullable: true),
                    guardianNo = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    idNo = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    patientType = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    platformId = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_病人信息", x => x.patientId);
                });

            migrationBuilder.CreateTable(
                name: "充值记录",
                columns: table => new
                {
                    No = table.Column<string>(nullable: false),
                    accountNo = table.Column<string>(nullable: true),
                    cardNo = table.Column<string>(nullable: true),
                    cardType = table.Column<string>(nullable: true),
                    cash = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    operId = table.Column<string>(nullable: true),
                    optType = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    receiptNo = table.Column<string>(nullable: true),
                    tradeMode = table.Column<string>(nullable: true),
                    tradeTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_充值记录", x => x.No);
                });

            migrationBuilder.CreateTable(
                name: "床位信息",
                columns: table => new
                {
                    wardCode = table.Column<string>(nullable: false),
                    hospitalId = table.Column<string>(nullable: true),
                    leftBedNum = table.Column<string>(nullable: true),
                    totalBedNum = table.Column<string>(nullable: true),
                    wardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_床位信息", x => x.wardCode);
                });

            migrationBuilder.CreateTable(
                name: "挂号预约记录",
                columns: table => new
                {
                    regNo = table.Column<string>(nullable: false),
                    address = table.Column<string>(nullable: true),
                    appoFrom = table.Column<string>(nullable: true),
                    appoNo = table.Column<string>(nullable: true),
                    deptCode = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    doctCode = table.Column<string>(nullable: true),
                    doctName = table.Column<string>(nullable: true),
                    doctTech = table.Column<string>(nullable: true),
                    hospCode = table.Column<string>(nullable: true),
                    hospName = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    lockId = table.Column<string>(nullable: true),
                    medAmPm = table.Column<string>(nullable: true),
                    medDate = table.Column<string>(nullable: true),
                    medTime = table.Column<string>(nullable: true),
                    orderNo = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    payStatus = table.Column<string>(nullable: true),
                    regAmount = table.Column<string>(nullable: true),
                    regFee = table.Column<string>(nullable: true),
                    scheduleId = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    tradeTime = table.Column<string>(nullable: true),
                    treatFee = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_挂号预约记录", x => x.regNo);
                });

            migrationBuilder.CreateTable(
                name: "号源明细",
                columns: table => new
                {
                    appoNo = table.Column<string>(nullable: false),
                    hospitalId = table.Column<string>(nullable: true),
                    isEnable = table.Column<string>(nullable: true),
                    medBegtime = table.Column<string>(nullable: true),
                    medEndtime = table.Column<string>(nullable: true),
                    restNum = table.Column<string>(nullable: true),
                    scheduleId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_号源明细", x => x.appoNo);
                });

            migrationBuilder.CreateTable(
                name: "检验基本信息",
                columns: table => new
                {
                    reportId = table.Column<string>(nullable: false),
                    age = table.Column<string>(nullable: true),
                    auditDoc = table.Column<string>(nullable: true),
                    auditTime = table.Column<string>(nullable: true),
                    cardNo = table.Column<string>(nullable: true),
                    checkDoc = table.Column<string>(nullable: true),
                    checkPart = table.Column<string>(nullable: true),
                    examResult = table.Column<string>(nullable: true),
                    examType = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    inhospId = table.Column<string>(nullable: true),
                    inspectDoctor = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    patientName = table.Column<string>(nullable: true),
                    printTimes = table.Column<string>(nullable: true),
                    remark = table.Column<string>(nullable: true),
                    resultTime = table.Column<string>(nullable: true),
                    sampleType = table.Column<string>(nullable: true),
                    sendTime = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_检验基本信息", x => x.reportId);
                });

            migrationBuilder.CreateTable(
                name: "检验项目",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    hospitalId = table.Column<string>(nullable: true),
                    itemAbbr = table.Column<string>(nullable: true),
                    itemMark = table.Column<string>(nullable: true),
                    itemName = table.Column<string>(nullable: true),
                    itemRealValue = table.Column<string>(nullable: true),
                    itemRefRange = table.Column<string>(nullable: true),
                    itemUnits = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    quaResult = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_检验项目", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "建档信息",
                columns: table => new
                {
                    cardNo = table.Column<string>(nullable: false),
                    accBalance = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    patientCard = table.Column<string>(nullable: true),
                    patientid = table.Column<string>(nullable: true),
                    platformId = table.Column<string>(nullable: true),
                    securityNo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_建档信息", x => x.cardNo);
                });

            migrationBuilder.CreateTable(
                name: "缴费明细信息",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    billDate = table.Column<string>(nullable: true),
                    billFee = table.Column<string>(nullable: true),
                    billNo = table.Column<string>(nullable: true),
                    billSeq = table.Column<string>(nullable: true),
                    billType = table.Column<string>(nullable: true),
                    deptCode = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    diseaseCode = table.Column<string>(nullable: true),
                    doctCode = table.Column<string>(nullable: true),
                    doctName = table.Column<string>(nullable: true),
                    execDeptName = table.Column<string>(nullable: true),
                    hosFeeNo = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    itemCode = table.Column<string>(nullable: true),
                    itemLiquid = table.Column<string>(nullable: true),
                    itemName = table.Column<string>(nullable: true),
                    itemNo = table.Column<string>(nullable: true),
                    itemPrice = table.Column<string>(nullable: true),
                    itemQty = table.Column<string>(nullable: true),
                    itemSpecs = table.Column<string>(nullable: true),
                    itemUnits = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    productCode = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    tradeTime = table.Column<string>(nullable: true),
                    ybInfo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_缴费明细信息", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "结算记录",
                columns: table => new
                {
                    receiptNo = table.Column<string>(nullable: false),
                    billFee = table.Column<string>(nullable: true),
                    billNo = table.Column<string>(nullable: true),
                    billType = table.Column<string>(nullable: true),
                    cost = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    itemLiquid = table.Column<string>(nullable: true),
                    itemName = table.Column<string>(nullable: true),
                    itemPrice = table.Column<string>(nullable: true),
                    itemQty = table.Column<string>(nullable: true),
                    itemSpecs = table.Column<string>(nullable: true),
                    itemUnits = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    tradeTime = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_结算记录", x => x.receiptNo);
                });

            migrationBuilder.CreateTable(
                name: "科室信息",
                columns: table => new
                {
                    deptCode = table.Column<string>(nullable: false),
                    deptIntro = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    fullPy = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    parentDeptCode = table.Column<string>(nullable: true),
                    parentDeptName = table.Column<string>(nullable: true),
                    regMode = table.Column<string>(nullable: true),
                    regType = table.Column<string>(nullable: true),
                    regTypeName = table.Column<string>(nullable: true),
                    simplePy = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_科室信息", x => x.deptCode);
                });

            migrationBuilder.CreateTable(
                name: "排班信息",
                columns: table => new
                {
                    scheduleId = table.Column<string>(nullable: false),
                    deptCode = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    doctCode = table.Column<string>(nullable: true),
                    doctName = table.Column<string>(nullable: true),
                    doctTech = table.Column<string>(nullable: true),
                    hosRegType = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    medAmPm = table.Column<string>(nullable: true),
                    medDate = table.Column<string>(nullable: true),
                    parentDeptCode = table.Column<string>(nullable: true),
                    parentDeptName = table.Column<string>(nullable: true),
                    regAmount = table.Column<string>(nullable: true),
                    regMode = table.Column<string>(nullable: true),
                    regType = table.Column<string>(nullable: true),
                    regfee = table.Column<string>(nullable: true),
                    treatfee = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_排班信息", x => x.scheduleId);
                });

            migrationBuilder.CreateTable(
                name: "收费项目信息",
                columns: table => new
                {
                    itemCode = table.Column<string>(nullable: false),
                    hospitalId = table.Column<string>(nullable: true),
                    itemName = table.Column<string>(nullable: true),
                    medicalRatio = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    priceUnit = table.Column<string>(nullable: true),
                    producer = table.Column<string>(nullable: true),
                    specifications = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_收费项目信息", x => x.itemCode);
                });

            migrationBuilder.CreateTable(
                name: "药品项目信息",
                columns: table => new
                {
                    medicineCode = table.Column<string>(nullable: false),
                    hospitalId = table.Column<string>(nullable: true),
                    medicalRatio = table.Column<string>(nullable: true),
                    medicineName = table.Column<string>(nullable: true),
                    miniUnit = table.Column<string>(nullable: true),
                    packagingUnit = table.Column<string>(nullable: true),
                    price = table.Column<string>(nullable: true),
                    priceUnit = table.Column<string>(nullable: true),
                    producer = table.Column<string>(nullable: true),
                    specifications = table.Column<string>(nullable: true),
                    type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_药品项目信息", x => x.medicineCode);
                });

            migrationBuilder.CreateTable(
                name: "医保结算信息",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    accountMoney = table.Column<string>(nullable: true),
                    commonMoney = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    hospitalMoney = table.Column<string>(nullable: true),
                    lastBalance = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    selfMoney = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_医保结算信息", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "医保科室信息",
                columns: table => new
                {
                    HisDeptCode = table.Column<string>(nullable: false),
                    HisDeptName = table.Column<string>(nullable: true),
                    SiDeptCode = table.Column<string>(nullable: true),
                    SiDeptName = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_医保科室信息", x => x.HisDeptCode);
                });

            migrationBuilder.CreateTable(
                name: "医生介绍",
                columns: table => new
                {
                    doctCode = table.Column<string>(nullable: false),
                    corpCode = table.Column<string>(nullable: true),
                    deptCode = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    doctIntro = table.Column<string>(nullable: true),
                    doctLevel = table.Column<string>(nullable: true),
                    doctLogo = table.Column<string>(nullable: true),
                    doctName = table.Column<string>(nullable: true),
                    doctPY = table.Column<string>(nullable: true),
                    doctPhoneNum = table.Column<string>(nullable: true),
                    doctPictureIntranetUrl = table.Column<string>(nullable: true),
                    doctProfe = table.Column<string>(nullable: true),
                    doctSimplePY = table.Column<string>(nullable: true),
                    doctSpec = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_医生介绍", x => x.doctCode);
                });

            migrationBuilder.CreateTable(
                name: "影像诊断结果",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    age = table.Column<string>(nullable: true),
                    auditDate = table.Column<string>(nullable: true),
                    auditDoctCode = table.Column<string>(nullable: true),
                    auditDoctName = table.Column<string>(nullable: true),
                    cardNo = table.Column<string>(nullable: true),
                    checkDate = table.Column<string>(nullable: true),
                    checkDesc = table.Column<string>(nullable: true),
                    checkItem = table.Column<string>(nullable: true),
                    checkNo = table.Column<string>(nullable: true),
                    checkResult = table.Column<string>(nullable: true),
                    checkStatus = table.Column<string>(nullable: true),
                    diagnosis = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    idNo = table.Column<string>(nullable: true),
                    inspecDeptName = table.Column<string>(nullable: true),
                    inspecDoctCode = table.Column<string>(nullable: true),
                    inspecDoctName = table.Column<string>(nullable: true),
                    inspecTime = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    patientNo = table.Column<string>(nullable: true),
                    reportTime = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    suggestion = table.Column<string>(nullable: true),
                    wardBed = table.Column<string>(nullable: true),
                    wardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_影像诊断结果", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "住院充值记录",
                columns: table => new
                {
                    receiptNo = table.Column<string>(nullable: false),
                    cardNo = table.Column<string>(nullable: true),
                    cash = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    operId = table.Column<string>(nullable: true),
                    payerName = table.Column<string>(nullable: true),
                    tradeMode = table.Column<string>(nullable: true),
                    tradeTime = table.Column<string>(nullable: true),
                    visitId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_住院充值记录", x => x.receiptNo);
                });

            migrationBuilder.CreateTable(
                name: "住院患者费用明细",
                columns: table => new
                {
                    id = table.Column<string>(nullable: false),
                    cost = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    itemLiquid = table.Column<string>(nullable: true),
                    itemName = table.Column<string>(nullable: true),
                    itemPrice = table.Column<string>(nullable: true),
                    itemQty = table.Column<string>(nullable: true),
                    itemSpecs = table.Column<string>(nullable: true),
                    itemUnits = table.Column<string>(nullable: true),
                    patientHosId = table.Column<string>(nullable: true),
                    ratio = table.Column<string>(nullable: true),
                    tradeTime = table.Column<string>(nullable: true),
                    visited = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_住院患者费用明细", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "住院患者信息",
                columns: table => new
                {
                    patientHosId = table.Column<string>(nullable: false),
                    IsArrearage = table.Column<string>(nullable: true),
                    accBalance = table.Column<string>(nullable: true),
                    accountNo = table.Column<string>(nullable: true),
                    address = table.Column<string>(nullable: true),
                    area = table.Column<string>(nullable: true),
                    balance = table.Column<string>(nullable: true),
                    bedNo = table.Column<string>(nullable: true),
                    birthday = table.Column<string>(nullable: true),
                    cardNo = table.Column<string>(nullable: true),
                    cost = table.Column<string>(nullable: true),
                    createDate = table.Column<string>(nullable: true),
                    deptName = table.Column<string>(nullable: true),
                    guardianNo = table.Column<string>(nullable: true),
                    hosAccBalanceCount = table.Column<string>(nullable: true),
                    hospitalId = table.Column<string>(nullable: true),
                    idNo = table.Column<string>(nullable: true),
                    name = table.Column<string>(nullable: true),
                    outDate = table.Column<string>(nullable: true),
                    patientAccBalance = table.Column<string>(nullable: true),
                    patientId = table.Column<string>(nullable: true),
                    patientType = table.Column<string>(nullable: true),
                    phone = table.Column<string>(nullable: true),
                    securityBalance = table.Column<string>(nullable: true),
                    sex = table.Column<string>(nullable: true),
                    status = table.Column<string>(nullable: true),
                    visiteId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_住院患者信息", x => x.patientHosId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "病人信息");

            migrationBuilder.DropTable(
                name: "充值记录");

            migrationBuilder.DropTable(
                name: "床位信息");

            migrationBuilder.DropTable(
                name: "挂号预约记录");

            migrationBuilder.DropTable(
                name: "号源明细");

            migrationBuilder.DropTable(
                name: "检验基本信息");

            migrationBuilder.DropTable(
                name: "检验项目");

            migrationBuilder.DropTable(
                name: "建档信息");

            migrationBuilder.DropTable(
                name: "缴费明细信息");

            migrationBuilder.DropTable(
                name: "结算记录");

            migrationBuilder.DropTable(
                name: "科室信息");

            migrationBuilder.DropTable(
                name: "排班信息");

            migrationBuilder.DropTable(
                name: "收费项目信息");

            migrationBuilder.DropTable(
                name: "药品项目信息");

            migrationBuilder.DropTable(
                name: "医保结算信息");

            migrationBuilder.DropTable(
                name: "医保科室信息");

            migrationBuilder.DropTable(
                name: "医生介绍");

            migrationBuilder.DropTable(
                name: "影像诊断结果");

            migrationBuilder.DropTable(
                name: "住院充值记录");

            migrationBuilder.DropTable(
                name: "住院患者费用明细");

            migrationBuilder.DropTable(
                name: "住院患者信息");
        }
    }
}
