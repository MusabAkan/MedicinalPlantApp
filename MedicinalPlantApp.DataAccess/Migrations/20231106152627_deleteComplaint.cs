using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MedicinalPlantApp.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class deleteComplaint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Plants_Complaints_ComplaintId",
                table: "Plants");

            migrationBuilder.DropTable(
                name: "Complaints");

            migrationBuilder.DropIndex(
                name: "IX_Plants_ComplaintId",
                table: "Plants");

            migrationBuilder.DropColumn(
                name: "ComplaintId",
                table: "Plants");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "ComplaintId",
                table: "Plants",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Complaints",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complaints", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Plants_ComplaintId",
                table: "Plants",
                column: "ComplaintId");

            migrationBuilder.AddForeignKey(
                name: "FK_Plants_Complaints_ComplaintId",
                table: "Plants",
                column: "ComplaintId",
                principalTable: "Complaints",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
