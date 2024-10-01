using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolTicketManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class fullUrl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 1,
                column: "Url",
                value: "http://localhost:5051/images/ho-boi-cho-tre-em.jpeg");

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 2,
                column: "Url",
                value: "http://localhost:5051/images/hoboigiadinh.jpg");

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 3,
                column: "Url",
                value: "http://localhost:5051/images/thac-nuoc-trang-tri-ho-boi-11.jpg");

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 4,
                column: "Url",
                value: "http://localhost:5051/images/songnhantao.jpg");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "http://localhost:5051/images/ho-boi-cho-tre-em.jpeg", new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1584), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1601) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "http://localhost:5051/images/hoboigiadinh.jpg", new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1615), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1616) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "http://localhost:5051/images/thac-nuoc-trang-tri-ho-boi-11.jpg", new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1618), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1619) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "http://localhost:5051/images/songnhantao.jpg", new DateTime(2024, 10, 1, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1621), new DateTime(2024, 10, 9, 15, 23, 8, 592, DateTimeKind.Local).AddTicks(1622) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 1,
                column: "Url",
                value: "/images/ho-boi-cho-tre-em.jpeg");

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 2,
                column: "Url",
                value: "/images/hoboigiadinh.jpg");

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 3,
                column: "Url",
                value: "/images/thac-nuoc-trang-tri-ho-boi-11.jpg");

            migrationBuilder.UpdateData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 4,
                column: "Url",
                value: "/images/songnhantao.jpg");

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "/images/ho-boi-cho-tre-em.jpeg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "/images/hoboigiadinh.jpg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4228), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4229) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "/images/thac-nuoc-trang-tri-ho-boi-11.jpg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4233) });

            migrationBuilder.UpdateData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4,
                columns: new[] { "Url", "ValidFrom", "ValidUntil" },
                values: new object[] { "/images/songnhantao.jpg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4235), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4236) });
        }
    }
}
