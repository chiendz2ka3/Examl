using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Migrations
{
    /// <inheritdoc />
    public partial class AddNewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "SubjectExam");

            migrationBuilder.DropColumn(
                name: "SubJectName",
                table: "SubjectExam");

            migrationBuilder.CreateTable(
                name: "ClassRoom",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectExamid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClassRoom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ClassRoom_SubjectExam_SubjectExamid",
                        column: x => x.SubjectExamid,
                        principalTable: "SubjectExam",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Faculty",
                columns: table => new
                {
                    id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    SubjectExamid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faculty", x => x.id);
                    table.ForeignKey(
                        name: "FK_Faculty_SubjectExam_SubjectExamid",
                        column: x => x.SubjectExamid,
                        principalTable: "SubjectExam",
                        principalColumn: "id");
                });

            migrationBuilder.CreateTable(
                name: "Subject",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubjectName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SubjectExamid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subject", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Subject_SubjectExam_SubjectExamid",
                        column: x => x.SubjectExamid,
                        principalTable: "SubjectExam",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_SubjectExamid",
                table: "ClassRoom",
                column: "SubjectExamid");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_SubjectExamid",
                table: "Faculty",
                column: "SubjectExamid");

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectExamid",
                table: "Subject",
                column: "SubjectExamid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ClassRoom");

            migrationBuilder.DropTable(
                name: "Faculty");

            migrationBuilder.DropTable(
                name: "Subject");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "SubjectExam",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubJectName",
                table: "SubjectExam",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
