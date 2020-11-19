using Microsoft.EntityFrameworkCore.Migrations;

namespace Cangul.EducationApp.DataAccess.Migrations
{
    public partial class UpdateQuestionTestFk : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Topic_TopicId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_AnswerId",
                table: "Question");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Question",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnswerId",
                table: "Question",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "AnswerQuestionId",
                table: "Option",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Question_AnswerId",
                table: "Question",
                column: "AnswerId",
                unique: true,
                filter: "[AnswerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Topic_TopicId",
                table: "Question",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Question_Topic_TopicId",
                table: "Question");

            migrationBuilder.DropIndex(
                name: "IX_Question_AnswerId",
                table: "Question");

            migrationBuilder.AlterColumn<int>(
                name: "TopicId",
                table: "Question",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnswerId",
                table: "Question",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "AnswerQuestionId",
                table: "Option",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_AnswerId",
                table: "Question",
                column: "AnswerId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Topic_TopicId",
                table: "Question",
                column: "TopicId",
                principalTable: "Topic",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
