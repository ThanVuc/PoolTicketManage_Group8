using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolTicketManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class additionInformation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "CloseTime",
                table: "Pools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Pools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "OpenTime",
                table: "Pools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 1,
                columns: new[] { "CloseTime", "Description", "OpenTime" },
                values: new object[] { "19:00", "The pool is for children with the clear and cold water", "7:30" });

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 2,
                columns: new[] { "CloseTime", "Description", "OpenTime" },
                values: new object[] { "19:00", "The pool is for Family with the clear and cold water", "7:30" });

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 3,
                columns: new[] { "CloseTime", "Description", "OpenTime" },
                values: new object[] { "19:00", "The Waterfall pool is the natural pool, it is very clear and the atmosphere is so fresh", "7:30" });

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 4,
                columns: new[] { "CloseTime", "Description", "OpenTime" },
                values: new object[] { "19:00", "The pool has the artifical wave as the beach but the waves is so lighlier than the beach", "7:30" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CloseTime",
                table: "Pools");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Pools");

            migrationBuilder.DropColumn(
                name: "OpenTime",
                table: "Pools");

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
        }
    }
}
