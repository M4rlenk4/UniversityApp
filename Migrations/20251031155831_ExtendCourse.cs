using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace University.Migrations
{
    /// <inheritdoc />
    public partial class ExtendCourse : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateCreated",
                table: "Course",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateEdited",
                table: "Course",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerId",
                table: "Course",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Course_OwnerId",
                table: "Course",
                column: "OwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Course_AspNetUsers_OwnerId",
                table: "Course",
                column: "OwnerId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Course_AspNetUsers_OwnerId",
                table: "Course");

            migrationBuilder.DropIndex(
                name: "IX_Course_OwnerId",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "DateCreated",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "DateEdited",
                table: "Course");

            migrationBuilder.DropColumn(
                name: "OwnerId",
                table: "Course");
        }
    }
}
