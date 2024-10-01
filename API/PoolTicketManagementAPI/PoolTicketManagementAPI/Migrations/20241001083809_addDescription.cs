using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolTicketManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class addDescription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "Description", "ValidFrom", "ValidUntil" },
                values: new object[] { "Trãi nghiệm hồ bơi trong lành và mát mẽ", new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(513), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(527) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "Description", "ValidFrom", "ValidUntil" },
                values: new object[] { "Trãi nghiệm hồ bơi trong lành và mát mẽ", new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(538), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(539) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "Description", "ValidFrom", "ValidUntil" },
                values: new object[] { "Trãi nghiệm hồ bơi trong lành và mát mẽ", new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(542), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(542) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "Description", "ValidFrom", "ValidUntil" },
                values: new object[] { "Trãi nghiệm hồ bơi trong lành và mát mẽ", new DateTime(2024, 10, 1, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(545), new DateTime(2024, 10, 9, 15, 38, 8, 393, DateTimeKind.Local).AddTicks(546) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Tickets");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1584), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1622) });
        }
    }
}
