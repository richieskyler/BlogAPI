using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class AddedUserTypeIdToPostTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserTypeId",
                table: "Posts",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserTypeId",
                table: "Posts",
                column: "UserTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_UserTypes_UserTypeId",
                table: "Posts",
                column: "UserTypeId",
                principalTable: "UserTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_UserTypes_UserTypeId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserTypeId",
                table: "Posts");

            migrationBuilder.DropColumn(
                name: "UserTypeId",
                table: "Posts");
        }
    }
}
