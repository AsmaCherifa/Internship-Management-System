using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Internship_Management_System.Migrations
{
    /// <inheritdoc />
    public partial class InitilazeData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    studentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    studentName = table.Column<string>(type: "varchar(50)", nullable: false),
                    ImageUser = table.Column<string>(type: "varchar(250)", nullable: true),
                    NationalId = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false),
                    email = table.Column<string>(type: "varchar(50)", nullable: true),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    phone = table.Column<string>(type: "varchar(8)", maxLength: 8, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.studentId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Student");
        }
    }
}
