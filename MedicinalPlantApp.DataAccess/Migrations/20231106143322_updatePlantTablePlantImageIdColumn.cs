using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicinalPlantApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class updatePlantTablePlantImageIdColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Plants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ImageId",
                table: "Plants",
                type: "uniqueidentifier",
                nullable: true);
        }
    }
}
