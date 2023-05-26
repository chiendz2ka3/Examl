using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Exam.Migrations
{
    /// <inheritdoc />
    public partial class Update : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ClassRoom_SubjectExam_SubjectExamid",
                table: "ClassRoom");

            migrationBuilder.DropForeignKey(
                name: "FK_Faculty_SubjectExam_SubjectExamid",
                table: "Faculty");

            migrationBuilder.DropForeignKey(
                name: "FK_Subject_SubjectExam_SubjectExamid",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Subject_SubjectExamid",
                table: "Subject");

            migrationBuilder.DropIndex(
                name: "IX_Faculty_SubjectExamid",
                table: "Faculty");

            migrationBuilder.DropIndex(
                name: "IX_ClassRoom_SubjectExamid",
                table: "ClassRoom");

            migrationBuilder.DropColumn(
                name: "SubjectExamid",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "SubjectExamid",
                table: "Faculty");

            migrationBuilder.DropColumn(
                name: "SubjectExamid",
                table: "ClassRoom");

            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "SubjectExam",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "SubJectName",
                table: "SubjectExam",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "classroom",
                table: "SubjectExam",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "SubjectExam");

            migrationBuilder.DropColumn(
                name: "SubJectName",
                table: "SubjectExam");

            migrationBuilder.DropColumn(
                name: "classroom",
                table: "SubjectExam");

            migrationBuilder.AddColumn<int>(
                name: "SubjectExamid",
                table: "Subject",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectExamid",
                table: "Faculty",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SubjectExamid",
                table: "ClassRoom",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Subject_SubjectExamid",
                table: "Subject",
                column: "SubjectExamid");

            migrationBuilder.CreateIndex(
                name: "IX_Faculty_SubjectExamid",
                table: "Faculty",
                column: "SubjectExamid");

            migrationBuilder.CreateIndex(
                name: "IX_ClassRoom_SubjectExamid",
                table: "ClassRoom",
                column: "SubjectExamid");

            migrationBuilder.AddForeignKey(
                name: "FK_ClassRoom_SubjectExam_SubjectExamid",
                table: "ClassRoom",
                column: "SubjectExamid",
                principalTable: "SubjectExam",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Faculty_SubjectExam_SubjectExamid",
                table: "Faculty",
                column: "SubjectExamid",
                principalTable: "SubjectExam",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Subject_SubjectExam_SubjectExamid",
                table: "Subject",
                column: "SubjectExamid",
                principalTable: "SubjectExam",
                principalColumn: "id");
        }
    }
}
