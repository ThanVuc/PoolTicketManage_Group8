using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoolTicketManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class FixDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PoolOwnerId",
                table: "Pools",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 1,
                column: "PoolOwnerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 2,
                column: "PoolOwnerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 3,
                column: "PoolOwnerId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 4,
                column: "PoolOwnerId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(751), new DateTime(2024, 10, 9, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(764) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(773), new DateTime(2024, 10, 9, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(774) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(777), new DateTime(2024, 10, 9, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(777) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(780), new DateTime(2024, 10, 9, 20, 49, 8, 613, DateTimeKind.Local).AddTicks(780) });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "UserId", "CreatedDate", "Email", "Password", "PhoneNumber", "UserName" },
                values: new object[,]
                {
                    { 1, "22/12/2004", "User1@gmail.com", "123", "0000005", "User 1" },
                    { 2, "10/10/2004", "User2@gmail.com", "123", "0002305", "User 2" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pools_PoolOwnerId",
                table: "Pools",
                column: "PoolOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Pools_Users_PoolOwnerId",
                table: "Pools",
                column: "PoolOwnerId",
                principalTable: "Users",
                principalColumn: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pools_Users_PoolOwnerId",
                table: "Pools");

            migrationBuilder.DropIndex(
                name: "IX_Pools_PoolOwnerId",
                table: "Pools");

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PoolOwnerId",
                table: "Pools");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(513), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(546) });
        }
    }
}
