using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DVar.BLog.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Feedbacks",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FeedbackType = table.Column<int>(type: "integer", nullable: false),
                    MessageTitle = table.Column<string>(type: "text", nullable: false),
                    MessageBody = table.Column<string>(type: "text", nullable: false),
                    FeedbackCratedDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    UserFullName_Surname = table.Column<string>(type: "text", nullable: false),
                    UserFullName_FirstName = table.Column<string>(type: "text", nullable: false),
                    UserFullName_MiddleName = table.Column<string>(type: "text", nullable: true),
                    UserEmail = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackResponses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FeedbackId = table.Column<Guid>(type: "uuid", nullable: false),
                    Response = table.Column<string>(type: "text", nullable: false),
                    ResponseDateTime = table.Column<DateTime>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedbackResponses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FeedbackResponses_Feedbacks_FeedbackId",
                        column: x => x.FeedbackId,
                        principalTable: "Feedbacks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FeedbackResponses_FeedbackId",
                table: "FeedbackResponses",
                column: "FeedbackId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FeedbackResponses");

            migrationBuilder.DropTable(
                name: "Feedbacks");
        }
    }
}
