using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PoolTicketManagementAPI.Migrations
{
    /// <inheritdoc />
    public partial class Url : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Tickets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Url",
                table: "Pools",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Url",
                table: "Tickets");

            migrationBuilder.DropColumn(
                name: "Url",
                table: "Pools");
        }
    }
}
