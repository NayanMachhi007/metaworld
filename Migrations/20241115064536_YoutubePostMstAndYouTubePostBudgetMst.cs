using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meta_Ads_World.Migrations
{
    /// <inheritdoc />
    public partial class YoutubePostMstAndYouTubePostBudgetMst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "youTubePostBudgetMsts",
                columns: table => new
                {
                    youtubepostbudgetid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    youtubelikebudget = table.Column<int>(type: "int", nullable: false),
                    youtubecommentbudget = table.Column<int>(type: "int", nullable: false),
                    youtubesharebudget = table.Column<int>(type: "int", nullable: false),
                    youtubesavebudget = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_youTubePostBudgetMsts", x => x.youtubepostbudgetid);
                });

            migrationBuilder.CreateTable(
                name: "YouTubePostMst",
                columns: table => new
                {
                    youtubepostid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    youtubeposttotallike = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubepostcomment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubepostshare = table.Column<bool>(type: "bit", nullable: false),
                    youtubepostsave = table.Column<bool>(type: "bit", nullable: false),
                    youtubepoststartingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    youtubepostendingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    youtubepostlikestatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubepostcommentstatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubepostsharestatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubepostsavestatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubeposturl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubeposttotalbudget = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YouTubePostMst", x => x.youtubepostid);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "youTubePostBudgetMsts");

            migrationBuilder.DropTable(
                name: "YouTubePostMst");
        }
    }
}
