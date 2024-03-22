using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class FixAll : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User-Table_userLike_UserLikeId",
                table: "User-Table");

            migrationBuilder.DropIndex(
                name: "IX_User-Table_UserLikeId",
                table: "User-Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_userLike",
                table: "userLike");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "userLike");

            migrationBuilder.RenameTable(
                name: "userLike",
                newName: "user-like");

            migrationBuilder.AddPrimaryKey(
                name: "PK_user-like",
                table: "user-like",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_user-like",
                table: "user-like");

            migrationBuilder.RenameTable(
                name: "user-like",
                newName: "userLike");

            migrationBuilder.AddColumn<int>(
                name: "Email",
                table: "userLike",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_userLike",
                table: "userLike",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_User-Table_UserLikeId",
                table: "User-Table",
                column: "UserLikeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_User-Table_userLike_UserLikeId",
                table: "User-Table",
                column: "UserLikeId",
                principalTable: "userLike",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
