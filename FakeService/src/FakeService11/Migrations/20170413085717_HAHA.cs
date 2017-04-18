using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeService.Migrations
{
    public partial class HAHA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "billNo",
                table: "结算记录",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "billType",
                table: "结算记录",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tradeTime",
                table: "缴费明细信息",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "充值记录",
                columns: table => new
                {
                    No = table.Column<string>(nullable: false),
                    accountNo = table.Column<string>(nullable: true),
                    cardNo = table.Column<string>(nullable: true),
                    cardType = table.Column<string>(nullable: true),
                    cash = table.Column<string>(nullable: true),
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
                name: "住院充值记录",
                columns: table => new
                {
                    receiptNo = table.Column<string>(nullable: false),
                    cardNo = table.Column<string>(nullable: true),
                    cash = table.Column<string>(nullable: true),
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "充值记录");

            migrationBuilder.DropTable(
                name: "住院充值记录");

            migrationBuilder.DropColumn(
                name: "billNo",
                table: "结算记录");

            migrationBuilder.DropColumn(
                name: "billType",
                table: "结算记录");

            migrationBuilder.DropColumn(
                name: "tradeTime",
                table: "缴费明细信息");
        }
    }
}
