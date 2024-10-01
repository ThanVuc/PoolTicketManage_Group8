using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PoolTicketManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSampleData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Pools",
                columns: new[] { "PoolId", "Capacity", "Location", "PoolName", "Url" },
                values: new object[,]
                {
                    { 1, 75000, "Dien Bien Phu", "Children Pool", "/images/ho-boi-cho-tre-em.jpeg" },
                    { 2, 75000, "Ha Huy Tap", "Family Pool", "/images/hoboigiadinh.jpg" },
                    { 3, 75000, "Hoa Cuong 9", "WaterFall Pool", "/images/thac-nuoc-trang-tri-ho-boi-11.jpg" },
                    { 4, 75000, "Ha Huy Tap", "Artificial Wave Pool", "/images/songnhantao.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "TicketId", "PoolId", "Price", "TicketName", "Url", "ValidFrom", "ValidUntil" },
                values: new object[,]
                {
                    { 1, 1, 99999m, "Children Pool Ticket", "/images/ho-boi-cho-tre-em.jpeg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4200), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4217) },
                    { 2, 2, 99999m, "Family Pool", "/images/hoboigiadinh.jpg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4228), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4229) },
                    { 3, 3, 99999m, "Waterfall Pool Ticket", "/images/thac-nuoc-trang-tri-ho-boi-11.jpg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4232), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4233) },
                    { 4, 4, 99999m, "Artifical Wave Pool Ticket", "/images/songnhantao.jpg", new DateTime(2024, 10, 1, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4235), new DateTime(2024, 10, 9, 12, 22, 22, 517, DateTimeKind.Local).AddTicks(4236) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tickets",
                keyColumn: "TicketId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Pools",
                keyColumn: "PoolId",
                keyValue: 4);
        }
    }
}
