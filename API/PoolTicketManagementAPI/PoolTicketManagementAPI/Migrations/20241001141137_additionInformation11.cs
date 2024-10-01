using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolTicketManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class additionInformation11 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(248), new DateTime(2024, 10, 9, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(265) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(276), new DateTime(2024, 10, 9, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(276) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(279), new DateTime(2024, 10, 9, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(279) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(282), new DateTime(2024, 10, 9, 21, 11, 36, 614, DateTimeKind.Local).AddTicks(282) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5312), new DateTime(2024, 10, 9, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5328) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5338), new DateTime(2024, 10, 9, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5339) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5341), new DateTime(2024, 10, 9, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5342) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "ValidFrom", "ValidUntil" },
                values: new object[] { new DateTime(2024, 10, 1, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5345), new DateTime(2024, 10, 9, 21, 4, 28, 876, DateTimeKind.Local).AddTicks(5345) });
        }
    }
}
