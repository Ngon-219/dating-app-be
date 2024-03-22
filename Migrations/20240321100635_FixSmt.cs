using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DatingApp.Migrations
{
    /// <inheritdoc />
    public partial class FixSmt : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_userLike_user_UserId",
                table: "userLike");

            migrationBuilder.DropIndex(
                name: "IX_userLike_UserId",
                table: "userLike");

            migrationBuilder.DropPrimaryKey(
                name: "PK_user",
                table: "user");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "userLike");

            migrationBuilder.RenameTable(
                name: "user",
                newName: "User-Table");

            migrationBuilder.AddColumn<Guid>(
                name: "UserLikeId",
                table: "User-Table",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_User-Table",
                table: "User-Table",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User-Table_userLike_UserLikeId",
                table: "User-Table");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User-Table",
                table: "User-Table");

            migrationBuilder.DropIndex(
                name: "IX_User-Table_UserLikeId",
                table: "User-Table");

            migrationBuilder.DropColumn(
                name: "UserLikeId",
                table: "User-Table");

            migrationBuilder.RenameTable(
                name: "User-Table",
                newName: "user");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "userLike",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_user",
                table: "user",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_userLike_UserId",
                table: "userLike",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_userLike_user_UserId",
                table: "userLike",
                column: "UserId",
                principalTable: "user",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
