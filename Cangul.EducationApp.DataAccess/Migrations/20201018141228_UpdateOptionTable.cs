using Microsoft.EntityFrameworkCore.Migrations;

namespace Cangul.EducationApp.DataAccess.Migrations
{
    public partial class UpdateOptionTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Question_AnswerQuestionId",
                table: "Option");

            migrationBuilder.DropIndex(
                name: "IX_Option_AnswerQuestionId",
                table: "Option");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Option_AnswerQuestionId",
                table: "Option",
                column: "AnswerQuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Option_Question_AnswerQuestionId",
                table: "Option",
                column: "AnswerQuestionId",
                principalTable: "Question",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
