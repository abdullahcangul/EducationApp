using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Cangul.EducationApp.DataAccess.Migrations
{
    public partial class initialcreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Student",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    Surname = table.Column<string>(maxLength: 100, nullable: false),
                    Tel = table.Column<string>(maxLength: 20, nullable: false),
                    ParentTel = table.Column<string>(maxLength: 20, nullable: false),
                    StudentNumber = table.Column<string>(maxLength: 100, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Student", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Test",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 100, nullable: false),
                    ExamDate = table.Column<DateTime>(nullable: false),
                    Description = table.Column<string>(maxLength: 200, nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Test", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Topic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topic", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StudentTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentID = table.Column<int>(nullable: false),
                    TestID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentTest_Student_StudentID",
                        column: x => x.StudentID,
                        principalTable: "Student",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentTest_Test_TestID",
                        column: x => x.TestID,
                        principalTable: "Test",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Anwer = table.Column<string>(nullable: true),
                    AnswerId = table.Column<int>(nullable: false),
                    TopicId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Question_Topic_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Image",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(nullable: true),
                    QuestionId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Image", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Image_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Option",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(maxLength: 500, nullable: false),
                    Description = table.Column<string>(maxLength: 500, nullable: true),
                    AnswerQuestionId = table.Column<int>(nullable: false),
                    QuestionId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Option", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Option_Question_AnswerQuestionId",
                        column: x => x.AnswerQuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Option_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTest",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QuestionId = table.Column<int>(nullable: false),
                    TestId = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTest", x => x.Id);
                    table.ForeignKey(
                        name: "FK_QuestionTest_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionTest_Test_TestId",
                        column: x => x.TestId,
                        principalTable: "Test",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StudentAnswer",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentTestId = table.Column<int>(nullable: false),
                    AnswerId = table.Column<int>(nullable: true),
                    IsCorrect = table.Column<int>(nullable: false),
                    IsActive = table.Column<bool>(nullable: false),
                    TestId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_StudentAnswer_Option_AnswerId",
                        column: x => x.AnswerId,
                        principalTable: "Option",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_StudentAnswer_StudentTest_StudentTestId",
                        column: x => x.StudentTestId,
                        principalTable: "StudentTest",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentAnswer_Test_TestId",
                        column: x => x.TestId,
                        principalTable: "Test",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Image_QuestionId",
                table: "Image",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_AnswerQuestionId",
                table: "Option",
                column: "AnswerQuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Option_QuestionId",
                table: "Option",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_Question_AnswerId",
                table: "Question",
                column: "AnswerId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Question_TopicId",
                table: "Question",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTest_QuestionId",
                table: "QuestionTest",
                column: "QuestionId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionTest_TestId",
                table: "QuestionTest",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswer_AnswerId",
                table: "StudentAnswer",
                column: "AnswerId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswer_StudentTestId",
                table: "StudentAnswer",
                column: "StudentTestId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentAnswer_TestId",
                table: "StudentAnswer",
                column: "TestId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTest_StudentID",
                table: "StudentTest",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentTest_TestID",
                table: "StudentTest",
                column: "TestID");

            migrationBuilder.AddForeignKey(
                name: "FK_Question_Option_AnswerId",
                table: "Question",
                column: "AnswerId",
                principalTable: "Option",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Option_Question_AnswerQuestionId",
                table: "Option");

            migrationBuilder.DropForeignKey(
                name: "FK_Option_Question_QuestionId",
                table: "Option");

            migrationBuilder.DropTable(
                name: "Image");

            migrationBuilder.DropTable(
                name: "QuestionTest");

            migrationBuilder.DropTable(
                name: "StudentAnswer");

            migrationBuilder.DropTable(
                name: "StudentTest");

            migrationBuilder.DropTable(
                name: "Student");

            migrationBuilder.DropTable(
                name: "Test");

            migrationBuilder.DropTable(
                name: "Question");

            migrationBuilder.DropTable(
                name: "Option");

            migrationBuilder.DropTable(
                name: "Topic");
        }
    }
}
