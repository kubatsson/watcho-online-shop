using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace e_comm.Migrations
{
    public partial class newmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ChangePasswordCode_ChangePasswordId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChangePasswordCode",
                table: "ChangePasswordCode");

            migrationBuilder.RenameTable(
                name: "ChangePasswordCode",
                newName: "ChangePasswords");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChangePasswords",
                table: "ChangePasswords",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2021, 3, 31, 14, 33, 18, 612, DateTimeKind.Utc).AddTicks(1048), new DateTime(2021, 3, 31, 14, 33, 18, 612, DateTimeKind.Utc).AddTicks(1048) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2021, 3, 31, 14, 33, 18, 612, DateTimeKind.Utc).AddTicks(3092), new DateTime(2021, 3, 31, 14, 33, 18, 612, DateTimeKind.Utc).AddTicks(3092) });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ChangePasswords_ChangePasswordId",
                table: "Users",
                column: "ChangePasswordId",
                principalTable: "ChangePasswords",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Users_ChangePasswords_ChangePasswordId",
                table: "Users");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ChangePasswords",
                table: "ChangePasswords");

            migrationBuilder.RenameTable(
                name: "ChangePasswords",
                newName: "ChangePasswordCode");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ChangePasswordCode",
                table: "ChangePasswordCode",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2021, 3, 31, 14, 15, 13, 923, DateTimeKind.Utc).AddTicks(3079), new DateTime(2021, 3, 31, 14, 15, 13, 923, DateTimeKind.Utc).AddTicks(3079) });

            migrationBuilder.UpdateData(
                table: "Genders",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "ModifedAt" },
                values: new object[] { new DateTime(2021, 3, 31, 14, 15, 13, 923, DateTimeKind.Utc).AddTicks(4397), new DateTime(2021, 3, 31, 14, 15, 13, 923, DateTimeKind.Utc).AddTicks(4397) });

            migrationBuilder.AddForeignKey(
                name: "FK_Users_ChangePasswordCode_ChangePasswordId",
                table: "Users",
                column: "ChangePasswordId",
                principalTable: "ChangePasswordCode",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
