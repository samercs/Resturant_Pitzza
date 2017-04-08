using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Resturant_Pitza.Data.Migrations
{
    public partial class AddApplicationModel_02 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Beverages",
                columns: table => new
                {
                    BeverageId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Cold = table.Column<bool>(nullable: false),
                    Diet = table.Column<bool>(nullable: false),
                    FoodId = table.Column<int>(nullable: false),
                    FoodType = table.Column<int>(nullable: false),
                    Prices = table.Column<decimal>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Beverages", x => x.BeverageId);
                });

            migrationBuilder.CreateTable(
                name: "Desserts",
                columns: table => new
                {
                    DessertId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    FoodId = table.Column<int>(nullable: false),
                    FoodType = table.Column<int>(nullable: false),
                    Prices = table.Column<decimal>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Type = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Desserts", x => x.DessertId);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    PizzaId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ExtraCheese = table.Column<string>(nullable: true),
                    FoodId = table.Column<int>(nullable: false),
                    FoodType = table.Column<int>(nullable: false),
                    Prices = table.Column<decimal>(nullable: false),
                    Size = table.Column<string>(nullable: true),
                    Thickness = table.Column<string>(nullable: true),
                    Topping1 = table.Column<string>(nullable: true),
                    Topping2 = table.Column<string>(nullable: true),
                    Topping3 = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.PizzaId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressId = table.Column<int>(nullable: false),
                    BeverageId = table.Column<int>(nullable: false),
                    DessertId = table.Column<int>(nullable: false),
                    PersonId = table.Column<string>(maxLength: 450, nullable: true),
                    PitzzaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Orders_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "AddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Beverages_BeverageId",
                        column: x => x.BeverageId,
                        principalTable: "Beverages",
                        principalColumn: "BeverageId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_Desserts_DessertId",
                        column: x => x.DessertId,
                        principalTable: "Desserts",
                        principalColumn: "DessertId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_PersonId",
                        column: x => x.PersonId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Orders_Pizzas_PitzzaId",
                        column: x => x.PitzzaId,
                        principalTable: "Pizzas",
                        principalColumn: "PizzaId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_AddressId",
                table: "Orders",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_BeverageId",
                table: "Orders",
                column: "BeverageId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_DessertId",
                table: "Orders",
                column: "DessertId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PersonId",
                table: "Orders",
                column: "PersonId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PitzzaId",
                table: "Orders",
                column: "PitzzaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Beverages");

            migrationBuilder.DropTable(
                name: "Desserts");

            migrationBuilder.DropTable(
                name: "Pizzas");
        }
    }
}
