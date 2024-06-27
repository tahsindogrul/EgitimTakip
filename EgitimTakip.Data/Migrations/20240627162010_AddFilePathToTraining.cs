using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EgitimTakip.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFilePathToTraining : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserCompany_Users_UserId",
                table: "AppUserCompany");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "AppUserCompany",
                newName: "UsersId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserCompany_UserId",
                table: "AppUserCompany",
                newName: "IX_AppUserCompany_UsersId");

            migrationBuilder.AddColumn<string>(
                name: "FilePath",
                table: "Trainings",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserCompany_Users_UsersId",
                table: "AppUserCompany",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserCompany_Users_UsersId",
                table: "AppUserCompany");

            migrationBuilder.DropColumn(
                name: "FilePath",
                table: "Trainings");

            migrationBuilder.RenameColumn(
                name: "UsersId",
                table: "AppUserCompany",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserCompany_UsersId",
                table: "AppUserCompany",
                newName: "IX_AppUserCompany_UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserCompany_Users_UserId",
                table: "AppUserCompany",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
