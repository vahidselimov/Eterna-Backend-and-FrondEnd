using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class CreateSettingTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SettingsId",
                table: "HeaderSocialMedias",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SettingsId",
                table: "FooterSocialMedias",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Setting",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Gmail = table.Column<string>(nullable: true),
                    GmailIcon = table.Column<string>(nullable: true),
                    Phone = table.Column<string>(nullable: true),
                    PhoneIcon = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Setting", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HeaderSocialMedias_SettingsId",
                table: "HeaderSocialMedias",
                column: "SettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_FooterSocialMedias_SettingsId",
                table: "FooterSocialMedias",
                column: "SettingsId");

            migrationBuilder.AddForeignKey(
                name: "FK_FooterSocialMedias_Setting_SettingsId",
                table: "FooterSocialMedias",
                column: "SettingsId",
                principalTable: "Setting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_HeaderSocialMedias_Setting_SettingsId",
                table: "HeaderSocialMedias",
                column: "SettingsId",
                principalTable: "Setting",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FooterSocialMedias_Setting_SettingsId",
                table: "FooterSocialMedias");

            migrationBuilder.DropForeignKey(
                name: "FK_HeaderSocialMedias_Setting_SettingsId",
                table: "HeaderSocialMedias");

            migrationBuilder.DropTable(
                name: "Setting");

            migrationBuilder.DropIndex(
                name: "IX_HeaderSocialMedias_SettingsId",
                table: "HeaderSocialMedias");

            migrationBuilder.DropIndex(
                name: "IX_FooterSocialMedias_SettingsId",
                table: "FooterSocialMedias");

            migrationBuilder.DropColumn(
                name: "SettingsId",
                table: "HeaderSocialMedias");

            migrationBuilder.DropColumn(
                name: "SettingsId",
                table: "FooterSocialMedias");
        }
    }
}
