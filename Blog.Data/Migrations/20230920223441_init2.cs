using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Blog.Data.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PostStatusId",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_PostStatusId",
                table: "Posts",
                column: "PostStatusId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_PostsStatus_PostStatusId",
                table: "Posts",
                column: "PostStatusId",
                principalTable: "PostsStatus",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_PostsStatus_PostStatusId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_PostStatusId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "PostStatusId",
                table: "Posts");
        }
    }
}
