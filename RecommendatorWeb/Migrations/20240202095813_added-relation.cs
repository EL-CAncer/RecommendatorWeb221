using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RecommendatorWeb.Migrations
{
    public partial class addedrelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ManyPic",
                table: "Services",
                newName: "ManyPics");

            migrationBuilder.AddColumn<int>(
                name: "ServiceId1",
                table: "UserRatingServices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "ServiceUserComments",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_UserRatingServices_AppUserId",
                table: "UserRatingServices",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRatingServices_ServiceId1",
                table: "UserRatingServices",
                column: "ServiceId1");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceUserComments_AppUserId",
                table: "ServiceUserComments",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_ServiceUserComments_ServiceId",
                table: "ServiceUserComments",
                column: "ServiceId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceUserComments_AspNetUsers_AppUserId",
                table: "ServiceUserComments",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ServiceUserComments_Services_ServiceId",
                table: "ServiceUserComments",
                column: "ServiceId",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatingServices_AspNetUsers_AppUserId",
                table: "UserRatingServices",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserRatingServices_Services_ServiceId1",
                table: "UserRatingServices",
                column: "ServiceId1",
                principalTable: "Services",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServiceUserComments_AspNetUsers_AppUserId",
                table: "ServiceUserComments");

            migrationBuilder.DropForeignKey(
                name: "FK_ServiceUserComments_Services_ServiceId",
                table: "ServiceUserComments");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRatingServices_AspNetUsers_AppUserId",
                table: "UserRatingServices");

            migrationBuilder.DropForeignKey(
                name: "FK_UserRatingServices_Services_ServiceId1",
                table: "UserRatingServices");

            migrationBuilder.DropIndex(
                name: "IX_UserRatingServices_AppUserId",
                table: "UserRatingServices");

            migrationBuilder.DropIndex(
                name: "IX_UserRatingServices_ServiceId1",
                table: "UserRatingServices");

            migrationBuilder.DropIndex(
                name: "IX_ServiceUserComments_AppUserId",
                table: "ServiceUserComments");

            migrationBuilder.DropIndex(
                name: "IX_ServiceUserComments_ServiceId",
                table: "ServiceUserComments");

            migrationBuilder.DropColumn(
                name: "ServiceId1",
                table: "UserRatingServices");

            migrationBuilder.RenameColumn(
                name: "ManyPics",
                table: "Services",
                newName: "ManyPic");

            migrationBuilder.AlterColumn<string>(
                name: "AppUserId",
                table: "ServiceUserComments",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }
    }
}
