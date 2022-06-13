using Microsoft.EntityFrameworkCore.Migrations;

namespace Eterna.Migrations
{
    public partial class CreateAnotherSettingsAndHeaderSocialAndFooterIconAndFooterSocialMediasAndHeaderSocialMediasTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "FooterIcons",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IconUrl = table.Column<string>(nullable: true),
                    FooterIconUrl = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterIcons", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Key = table.Column<string>(nullable: true),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FooterSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FooterSocialMediasUrl = table.Column<string>(nullable: true),
                    AnotherSettingsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FooterSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FooterSocialMedias_Settings_AnotherSettingsId",
                        column: x => x.AnotherSettingsId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "HeaderSocialMedias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SocialUrl = table.Column<string>(nullable: true),
                    AnotherSettingsId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HeaderSocialMedias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HeaderSocialMedias_Settings_AnotherSettingsId",
                        column: x => x.AnotherSettingsId,
                        principalTable: "Settings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FooterSocialMedias_AnotherSettingsId",
                table: "FooterSocialMedias",
                column: "AnotherSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_HeaderSocialMedias_AnotherSettingsId",
                table: "HeaderSocialMedias",
                column: "AnotherSettingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Settings_Key",
                table: "Settings",
                column: "Key",
                unique: true,
                filter: "[Key] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FooterIcons");

            migrationBuilder.DropTable(
                name: "FooterSocialMedias");

            migrationBuilder.DropTable(
                name: "HeaderSocialMedias");

            migrationBuilder.DropTable(
                name: "Settings");
        }
    }
}
