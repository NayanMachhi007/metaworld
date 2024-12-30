using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meta_Ads_World.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedFiled : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AreaMsts",
                columns: table => new
                {
                    areaid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    areaname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    cityid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AreaMsts", x => x.areaid);
                });

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
                    areacode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bstatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandRegistrationMst", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "CityMsts",
                columns: table => new
                {
                    cityid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cityname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    stateid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityMsts", x => x.cityid);
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
                    instasavebudget = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
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
                    uemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    upassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    areadcode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    profilepicture = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    youtubesavebudget = table.Column<int>(type: "int", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
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

            migrationBuilder.CreateTable(
                name: "StateMsts",
                columns: table => new
                {
                    stateid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    statename = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CityMstcityid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StateMsts", x => x.stateid);
                    table.ForeignKey(
                        name: "FK_StateMsts_CityMsts_CityMstcityid",
                        column: x => x.CityMstcityid,
                        principalTable: "CityMsts",
                        principalColumn: "cityid");
                });

            migrationBuilder.CreateIndex(
                name: "IX_StateMsts_CityMstcityid",
                table: "StateMsts",
                column: "CityMstcityid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaMsts");

            migrationBuilder.DropTable(
                name: "BrandCategoryMst");

            migrationBuilder.DropTable(
                name: "BrandRegistrationMst");

            migrationBuilder.DropTable(
                name: "InstaPostBudgetMst");

            migrationBuilder.DropTable(
                name: "InstaPostMsts");

            migrationBuilder.DropTable(
                name: "StateMsts");

            migrationBuilder.DropTable(
                name: "UserMsts");

            migrationBuilder.DropTable(
                name: "youTubePostBudgetMsts");

            migrationBuilder.DropTable(
                name: "YouTubePostMst");

            migrationBuilder.DropTable(
                name: "CityMsts");
        }
    }
}
