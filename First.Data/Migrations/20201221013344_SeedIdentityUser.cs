using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace First.Data.Migrations
{
    public partial class SeedIdentityUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[] { new Guid("a517c144-1464-46ae-8441-f28cffc8bc26"), "e2009af8-af10-4320-be73-ef3aec5246d5", "Administrator role", "admin", "admin" });

            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { new Guid("a517c144-1464-46ae-8441-f28cffc8bc26"), new Guid("bfbf9f2c-c530-4f13-91bb-826b2b451787") });

            migrationBuilder.InsertData(
                table: "AppUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { new Guid("bfbf9f2c-c530-4f13-91bb-826b2b451787"), 0, "bf8dd935-102b-4e36-894e-da7a8ac907ff", new DateTime(2020, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "henri.deaaron@gmail.com", true, "Huy", "Vo", false, null, "henri.deaaron@gmail.com", "admin", "AQAAAAEAACcQAAAAEFhHJh8O3sdiqXbj0ChQWA20wDvclYFY1K9NnPFkPfNfmH6u/kf7NghnQitZeaC3eg==", null, false, "", false, "admin" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreated",
                value: new DateTime(2020, 12, 21, 8, 33, 41, 653, DateTimeKind.Local).AddTicks(6110));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("a517c144-1464-46ae-8441-f28cffc8bc26"));

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("a517c144-1464-46ae-8441-f28cffc8bc26"), new Guid("bfbf9f2c-c530-4f13-91bb-826b2b451787") });

            migrationBuilder.DeleteData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("bfbf9f2c-c530-4f13-91bb-826b2b451787"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataCreated",
                value: new DateTime(2020, 12, 16, 8, 11, 6, 811, DateTimeKind.Local).AddTicks(6304));
        }
    }
}
