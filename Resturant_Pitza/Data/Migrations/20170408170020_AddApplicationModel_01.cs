using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Resturant_Pitza.Data.Migrations
{
    public partial class AddApplicationModel_01 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.AddColumn<string>(
                name: "FName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LName",
                table: "AspNetUsers",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PaymentInfoId",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Area = table.Column<string>(nullable: true),
                    Block = table.Column<int>(nullable: false),
                    BuildingNumber = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    FlatNo = table.Column<string>(nullable: true),
                    Street = table.Column<string>(nullable: true),
                    ZipCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.AddressId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentInfos",
                columns: table => new
                {
                    PaymentInfoId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    CreditCardNo = table.Column<string>(nullable: true),
                    CreditCardType = table.Column<string>(nullable: true),
                    ExpireDate = table.Column<DateTime>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SecurityCode = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInfos", x => x.PaymentInfoId);
                    table.ForeignKey(
                        name: "FK_PaymentInfos_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PaymentInfoId",
                table: "AspNetUsers",
                column: "PaymentInfoId");

            migrationBuilder.CreateIndex(
                name: "IX_PaymentInfos_AddressId",
                table: "PaymentInfos",
                column: "AddressId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_PaymentInfos_PaymentInfoId",
                table: "AspNetUsers",
                column: "PaymentInfoId",
                principalTable: "PaymentInfos",
                principalColumn: "PaymentInfoId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_PaymentInfos_PaymentInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "PaymentInfos");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_PaymentInfoId",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "FName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "PaymentInfoId",
                table: "AspNetUsers");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_UserId",
                table: "AspNetUserRoles",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName");
        }
    }
}
