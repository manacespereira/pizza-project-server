using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaProject.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customizations",
                columns: new[] { "UId", "AdicionalTime", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { "1df4a9ef-7a31-472e-af05-c69933d81e37", 0, new DateTime(2019, 10, 30, 15, 44, 40, 931, DateTimeKind.Local).AddTicks(8600), "Bacon Extra", 3.0, null });

            migrationBuilder.InsertData(
                table: "Customizations",
                columns: new[] { "UId", "AdicionalTime", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { "a9eab6bc-81dc-4785-9dcb-17fdcad95790", 0, new DateTime(2019, 10, 30, 15, 44, 40, 931, DateTimeKind.Local).AddTicks(9730), "Sem Cebola", 0.0, null });

            migrationBuilder.InsertData(
                table: "Customizations",
                columns: new[] { "UId", "AdicionalTime", "CreatedAt", "Name", "Price", "UpdatedAt" },
                values: new object[] { "3f8649aa-14de-4647-9def-9617638857f3", 5, new DateTime(2019, 10, 30, 15, 44, 40, 931, DateTimeKind.Local).AddTicks(9770), "Borda Recheada", 5.0, null });

            migrationBuilder.InsertData(
                table: "Flavors",
                columns: new[] { "UId", "AdicionalTime", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { "a3c7c2f2-e3bc-4412-9c22-380f9fa2d20e", 0, new DateTime(2019, 10, 30, 15, 44, 40, 931, DateTimeKind.Local).AddTicks(6650), "Calabresa", null });

            migrationBuilder.InsertData(
                table: "Flavors",
                columns: new[] { "UId", "AdicionalTime", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { "0390e031-ce7a-41f2-89a8-523dda67223f", 0, new DateTime(2019, 10, 30, 15, 44, 40, 931, DateTimeKind.Local).AddTicks(7510), "Marguerita", null });

            migrationBuilder.InsertData(
                table: "Flavors",
                columns: new[] { "UId", "AdicionalTime", "CreatedAt", "Name", "UpdatedAt" },
                values: new object[] { "713c408d-4a95-4903-9d11-878f59dbf95e", 5, new DateTime(2019, 10, 30, 15, 44, 40, 931, DateTimeKind.Local).AddTicks(7540), "Portuguesa", null });

            migrationBuilder.InsertData(
                table: "PizzaSizes",
                columns: new[] { "UId", "CreatedAt", "Name", "Price", "TimeToPrepare", "UpdatedAt" },
                values: new object[] { "78cd8095-ea0e-47fc-8cf8-2f660c7c5a01", new DateTime(2019, 10, 30, 15, 44, 40, 923, DateTimeKind.Local).AddTicks(7210), "Pizza pequena", 20.0, 15, null });

            migrationBuilder.InsertData(
                table: "PizzaSizes",
                columns: new[] { "UId", "CreatedAt", "Name", "Price", "TimeToPrepare", "UpdatedAt" },
                values: new object[] { "01ac2df6-fda6-401a-af3e-4618da67f929", new DateTime(2019, 10, 30, 15, 44, 40, 930, DateTimeKind.Local).AddTicks(4670), "Pizza média", 30.0, 20, null });

            migrationBuilder.InsertData(
                table: "PizzaSizes",
                columns: new[] { "UId", "CreatedAt", "Name", "Price", "TimeToPrepare", "UpdatedAt" },
                values: new object[] { "4563c1b9-f973-40d4-8dc6-5f09fc14ca86", new DateTime(2019, 10, 30, 15, 44, 40, 930, DateTimeKind.Local).AddTicks(4730), "Pizza grande", 40.0, 25, null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customizations",
                keyColumn: "UId",
                keyValue: "1df4a9ef-7a31-472e-af05-c69933d81e37");

            migrationBuilder.DeleteData(
                table: "Customizations",
                keyColumn: "UId",
                keyValue: "3f8649aa-14de-4647-9def-9617638857f3");

            migrationBuilder.DeleteData(
                table: "Customizations",
                keyColumn: "UId",
                keyValue: "a9eab6bc-81dc-4785-9dcb-17fdcad95790");

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "UId",
                keyValue: "0390e031-ce7a-41f2-89a8-523dda67223f");

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "UId",
                keyValue: "713c408d-4a95-4903-9d11-878f59dbf95e");

            migrationBuilder.DeleteData(
                table: "Flavors",
                keyColumn: "UId",
                keyValue: "a3c7c2f2-e3bc-4412-9c22-380f9fa2d20e");

            migrationBuilder.DeleteData(
                table: "PizzaSizes",
                keyColumn: "UId",
                keyValue: "01ac2df6-fda6-401a-af3e-4618da67f929");

            migrationBuilder.DeleteData(
                table: "PizzaSizes",
                keyColumn: "UId",
                keyValue: "4563c1b9-f973-40d4-8dc6-5f09fc14ca86");

            migrationBuilder.DeleteData(
                table: "PizzaSizes",
                keyColumn: "UId",
                keyValue: "78cd8095-ea0e-47fc-8cf8-2f660c7c5a01");
        }
    }
}
