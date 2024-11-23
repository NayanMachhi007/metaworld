using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meta_Ads_World.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BrandCategoryMst",
                columns: table => new
                {
                    bcategoryid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bcategoryname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bcategorystatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandCategoryMst", x => x.bcategoryid);
                });

            migrationBuilder.CreateTable(
                name: "BrandRegistrationMst",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    bname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bcontactno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bcountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bstate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bcity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bstatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandRegistrationMst", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "InstaPostBudgetMst",
                columns: table => new
                {
                    instapostbudgetid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    instalikebudget = table.Column<int>(type: "int", nullable: false),
                    instacommentbudget = table.Column<int>(type: "int", nullable: false),
                    instasharebudget = table.Column<int>(type: "int", nullable: false),
                    instasavebudget = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstaPostBudgetMst", x => x.instapostbudgetid);
                });

            migrationBuilder.CreateTable(
                name: "InstaPostMsts",
                columns: table => new
                {
                    instapostid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    instaposttotallike = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instapostcomment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instapostshare = table.Column<bool>(type: "bit", nullable: false),
                    instapostsave = table.Column<bool>(type: "bit", nullable: false),
                    instapoststartingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    instapostendingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    instapostlikestatus = table.Column<bool>(type: "bit", nullable: false),
                    instapostcommentstatus = table.Column<bool>(type: "bit", nullable: false),
                    instagrampostsharestatus = table.Column<bool>(type: "bit", nullable: false),
                    instapostsavestatus = table.Column<bool>(type: "bit", nullable: false),
                    instaposturl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    posttotalbudget = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstaPostMsts", x => x.instapostid);
                });

            migrationBuilder.CreateTable(
                name: "UserMsts",
                columns: table => new
                {
                    userid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ufname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ulname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    upassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ucountry = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ustate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ucity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false),
                    urefreallid = table.Column<int>(type: "int", nullable: false),
                    urefreallcode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserMsts", x => x.userid);
                });

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
                name: "BrandCategoryMst");

            migrationBuilder.DropTable(
                name: "BrandRegistrationMst");

            migrationBuilder.DropTable(
                name: "InstaPostBudgetMst");

            migrationBuilder.DropTable(
                name: "InstaPostMsts");

            migrationBuilder.DropTable(
                name: "UserMsts");

            migrationBuilder.DropTable(
                name: "youTubePostBudgetMsts");

            migrationBuilder.DropTable(
                name: "YouTubePostMst");
        }
    }
}
