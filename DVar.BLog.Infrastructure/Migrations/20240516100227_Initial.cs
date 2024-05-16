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
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FeedbackType = table.Column<int>(type: "INTEGER", nullable: false),
                    MessageTitle = table.Column<string>(type: "TEXT", nullable: false),
                    MessageBody = table.Column<string>(type: "TEXT", nullable: false),
                    FeedbackCratedDateTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    UserEmail = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedbacks", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeedbackResponses",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "TEXT", nullable: false),
                    FeedbackId = table.Column<Guid>(type: "TEXT", nullable: false),
                    Response = table.Column<string>(type: "TEXT", nullable: false),
                    ResponseDateTime = table.Column<DateTime>(type: "TEXT", nullable: false)
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
