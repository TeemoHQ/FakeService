using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeService.Migrations
{
    public partial class hos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "住院患者信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "住院患者费用明细",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "住院充值记录",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "影像诊断结果",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "医生介绍",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "医保科室信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "医保结算信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "药品项目信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "收费项目信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "排班信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "科室信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "结算记录",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "缴费明细信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "建档信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "检验项目",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "检验基本信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "号源明细",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "挂号预约记录",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "床位信息",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "充值记录",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "hospitalId",
                table: "病人信息",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "住院患者信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "住院患者费用明细");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "住院充值记录");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "影像诊断结果");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "医生介绍");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "医保科室信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "医保结算信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "药品项目信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "收费项目信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "排班信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "科室信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "结算记录");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "缴费明细信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "建档信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "检验项目");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "检验基本信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "号源明细");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "挂号预约记录");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "床位信息");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "充值记录");

            migrationBuilder.DropColumn(
                name: "hospitalId",
                table: "病人信息");
        }
    }
}
