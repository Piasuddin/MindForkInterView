using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace server.Migrations
{
    public partial class initrre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BlogUsers",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(200)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogUserId = table.Column<long>(nullable: false),
                    Post = table.Column<string>(maxLength: 500, nullable: false),
                    PostDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogPosts_BlogUsers_BlogUserId",
                        column: x => x.BlogUserId,
                        principalTable: "BlogUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BlogComments",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogPostId = table.Column<long>(nullable: false),
                    CommentDate = table.Column<DateTime>(nullable: false),
                    BlogUserId = table.Column<long>(nullable: false),
                    Comment = table.Column<string>(maxLength: 300, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogComments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogPosts_BlogPostId",
                        column: x => x.BlogPostId,
                        principalTable: "BlogPosts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogComments_BlogUsers_BlogUserId",
                        column: x => x.BlogUserId,
                        principalTable: "BlogUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "BlogCommentLikeAndDislikes",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BlogCommentId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false),
                    IsLike = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogCommentLikeAndDislikes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BlogCommentLikeAndDislikes_BlogComments_BlogCommentId",
                        column: x => x.BlogCommentId,
                        principalTable: "BlogComments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BlogCommentLikeAndDislikes_BlogUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "BlogUsers",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "BlogUsers",
                columns: new[] { "Id", "UserName" },
                values: new object[,]
                {
                    { 1L, "User 1" },
                    { 2L, "User 2" },
                    { 3L, "User 3" },
                    { 4L, "User 4" },
                    { 5L, "User 5" },
                    { 6L, "User 6" }
                });

            migrationBuilder.InsertData(
                table: "BlogPosts",
                columns: new[] { "Id", "BlogUserId", "Post", "PostDate" },
                values: new object[,]
                {
                    { 2L, 1L, "Blog 2", new DateTime(2021, 6, 5, 13, 21, 24, 433, DateTimeKind.Local).AddTicks(4909) },
                    { 1L, 3L, "Blog 1", new DateTime(2021, 6, 7, 13, 21, 24, 431, DateTimeKind.Local).AddTicks(8867) },
                    { 3L, 4L, "Blog 3", new DateTime(2021, 6, 6, 13, 21, 24, 433, DateTimeKind.Local).AddTicks(5093) },
                    { 4L, 5L, "Blog 4", new DateTime(2021, 6, 6, 13, 21, 24, 433, DateTimeKind.Local).AddTicks(5103) }
                });

            migrationBuilder.InsertData(
                table: "BlogComments",
                columns: new[] { "Id", "BlogPostId", "BlogUserId", "Comment", "CommentDate" },
                values: new object[,]
                {
                    { 4L, 2L, 3L, "Comment 4", new DateTime(2021, 6, 5, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1792) },
                    { 5L, 2L, 4L, "Comment 5", new DateTime(2021, 6, 7, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1801) },
                    { 1L, 1L, 1L, "Comment 1", new DateTime(2021, 6, 6, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(416) },
                    { 2L, 1L, 2L, "Comment 2", new DateTime(2021, 6, 7, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1750) },
                    { 3L, 1L, 1L, "Comment 3", new DateTime(2021, 6, 5, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1788) },
                    { 6L, 3L, 5L, "Comment 6", new DateTime(2021, 6, 7, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1807) },
                    { 7L, 3L, 6L, "Comment 7", new DateTime(2021, 6, 6, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1813) },
                    { 8L, 3L, 4L, "Comment 8", new DateTime(2021, 6, 7, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1818) },
                    { 9L, 4L, 6L, "Comment 9", new DateTime(2021, 6, 6, 13, 21, 24, 434, DateTimeKind.Local).AddTicks(1821) }
                });

            migrationBuilder.InsertData(
                table: "BlogCommentLikeAndDislikes",
                columns: new[] { "Id", "BlogCommentId", "IsLike", "UserId" },
                values: new object[,]
                {
                    { 20L, 4L, true, 1L },
                    { 14L, 3L, true, 2L },
                    { 16L, 3L, false, 3L },
                    { 17L, 3L, true, 4L },
                    { 18L, 3L, false, 5L },
                    { 19L, 3L, true, 6L },
                    { 32L, 6L, true, 1L },
                    { 33L, 6L, true, 2L },
                    { 34L, 6L, false, 3L },
                    { 35L, 6L, true, 4L },
                    { 36L, 6L, false, 5L },
                    { 37L, 6L, true, 6L },
                    { 38L, 7L, true, 1L },
                    { 39L, 7L, true, 2L },
                    { 40L, 7L, false, 3L },
                    { 41L, 7L, false, 4L },
                    { 42L, 7L, false, 5L },
                    { 43L, 7L, true, 6L },
                    { 44L, 8L, false, 3L },
                    { 45L, 8L, false, 4L },
                    { 13L, 3L, true, 1L },
                    { 12L, 2L, true, 6L },
                    { 11L, 2L, false, 5L },
                    { 10L, 2L, true, 4L },
                    { 21L, 4L, true, 2L },
                    { 22L, 4L, false, 3L },
                    { 23L, 4L, true, 4L },
                    { 24L, 4L, false, 5L },
                    { 25L, 4L, true, 6L },
                    { 26L, 5L, true, 1L },
                    { 27L, 5L, true, 2L },
                    { 28L, 5L, false, 3L },
                    { 29L, 5L, true, 4L },
                    { 46L, 9L, false, 5L },
                    { 30L, 5L, false, 5L },
                    { 1L, 1L, true, 1L },
                    { 2L, 1L, true, 2L },
                    { 3L, 1L, false, 3L },
                    { 4L, 1L, false, 4L },
                    { 5L, 1L, false, 5L },
                    { 6L, 1L, true, 6L },
                    { 7L, 2L, true, 1L },
                    { 8L, 2L, true, 2L },
                    { 9L, 2L, false, 3L },
                    { 31L, 5L, true, 6L },
                    { 47L, 9L, true, 6L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogCommentLikeAndDislikes_BlogCommentId",
                table: "BlogCommentLikeAndDislikes",
                column: "BlogCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogCommentLikeAndDislikes_UserId",
                table: "BlogCommentLikeAndDislikes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogPostId",
                table: "BlogComments",
                column: "BlogPostId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogComments_BlogUserId",
                table: "BlogComments",
                column: "BlogUserId");

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_BlogUserId",
                table: "BlogPosts",
                column: "BlogUserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogCommentLikeAndDislikes");

            migrationBuilder.DropTable(
                name: "BlogComments");

            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "BlogUsers");
        }
    }
}
