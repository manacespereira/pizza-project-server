using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaProject.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customizations",
                columns: table => new
                {
                    UId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    AdicionalTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customizations", x => x.UId);
                });

            migrationBuilder.CreateTable(
                name: "Flavors",
                columns: table => new
                {
                    UId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    AdicionalTime = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Flavors", x => x.UId);
                });

            migrationBuilder.CreateTable(
                name: "PizzaSizes",
                columns: table => new
                {
                    UId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Price = table.Column<double>(nullable: false),
                    TimeToPrepare = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaSizes", x => x.UId);
                });

            migrationBuilder.CreateTable(
                name: "Pizzas",
                columns: table => new
                {
                    UId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    SizeUId = table.Column<string>(nullable: false),
                    FlavorUId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pizzas", x => x.UId);
                    table.ForeignKey(
                        name: "FlavorUId",
                        column: x => x.FlavorUId,
                        principalTable: "Flavors",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "PizzaSizeUId",
                        column: x => x.SizeUId,
                        principalTable: "PizzaSizes",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    UId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    PizzaUId = table.Column<string>(nullable: true),
                    TimeToPrepare = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.UId);
                    table.ForeignKey(
                        name: "FK_Orders_Pizzas_PizzaUId",
                        column: x => x.PizzaUId,
                        principalTable: "Pizzas",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PizzaCustomizations",
                columns: table => new
                {
                    UId = table.Column<string>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    PizzaUId = table.Column<string>(nullable: true),
                    CustomizationUId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PizzaCustomizations", x => x.UId);
                    table.ForeignKey(
                        name: "FK_PizzaCustomizations_Customizations_CustomizationUId",
                        column: x => x.CustomizationUId,
                        principalTable: "Customizations",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PizzaCustomizations_Pizzas_PizzaUId",
                        column: x => x.PizzaUId,
                        principalTable: "Pizzas",
                        principalColumn: "UId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Orders_PizzaUId",
                table: "Orders",
                column: "PizzaUId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaCustomizations_CustomizationUId",
                table: "PizzaCustomizations",
                column: "CustomizationUId");

            migrationBuilder.CreateIndex(
                name: "IX_PizzaCustomizations_PizzaUId",
                table: "PizzaCustomizations",
                column: "PizzaUId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_FlavorUId",
                table: "Pizzas",
                column: "FlavorUId");

            migrationBuilder.CreateIndex(
                name: "IX_Pizzas_SizeUId",
                table: "Pizzas",
                column: "SizeUId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "PizzaCustomizations");

            migrationBuilder.DropTable(
                name: "Customizations");

            migrationBuilder.DropTable(
                name: "Pizzas");

            migrationBuilder.DropTable(
                name: "Flavors");

            migrationBuilder.DropTable(
                name: "PizzaSizes");
        }
    }
}
