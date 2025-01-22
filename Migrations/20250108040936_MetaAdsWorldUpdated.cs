using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meta_Ads_World.Migrations
{
    /// <inheritdoc />
    public partial class MetaAdsWorldUpdated : Migration
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
                name: "QrMst",
                columns: table => new
                {
                    qrid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    qrpath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QrMst", x => x.qrid);
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
                name: "InstaPostMsts",
                columns: table => new
                {
                    instapostid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    instaposttotallike = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instapostcomment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instapostshare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instapostsave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instapoststartingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    instapostendingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    instapostlikestatus = table.Column<bool>(type: "bit", nullable: false),
                    instapostcommentstatus = table.Column<bool>(type: "bit", nullable: false),
                    instagrampostsharestatus = table.Column<bool>(type: "bit", nullable: false),
                    instapostsavestatus = table.Column<bool>(type: "bit", nullable: false),
                    instaposturl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    posttotalbudget = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instapoststatus = table.Column<bool>(type: "bit", nullable: false),
                    instabranduserid = table.Column<int>(type: "int", nullable: false),
                    counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstaPostMsts", x => x.instapostid);
                    table.ForeignKey(
                        name: "FK_InstaPostMsts_BrandRegistrationMst_instabranduserid",
                        column: x => x.instabranduserid,
                        principalTable: "BrandRegistrationMst",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "YouTubePostMst",
                columns: table => new
                {
                    youtubepostid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    youtubeposttotallike = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubepostcomment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubepostshare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubepostsave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubepoststartingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    youtubepostendingdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    youtubepostlikestatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubepostcommentstatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubepostsharestatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubepostsavestatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubeposturl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubepoststatus = table.Column<bool>(type: "bit", nullable: false),
                    youtubeposttotalbudget = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubebranduserid = table.Column<int>(type: "int", nullable: false),
                    counter = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_YouTubePostMst", x => x.youtubepostid);
                    table.ForeignKey(
                        name: "FK_YouTubePostMst_BrandRegistrationMst_youtubebranduserid",
                        column: x => x.youtubebranduserid,
                        principalTable: "BrandRegistrationMst",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "BrandPaymentTransactionMsts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentrecipt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transcationid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paymentbranduserid = table.Column<int>(type: "int", nullable: false),
                    paymentinstaid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandPaymentTransactionMsts", x => x.id);
                    table.ForeignKey(
                        name: "FK_BrandPaymentTransactionMsts_BrandRegistrationMst_paymentbranduserid",
                        column: x => x.paymentbranduserid,
                        principalTable: "BrandRegistrationMst",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BrandPaymentTransactionMsts_InstaPostMsts_paymentinstaid",
                        column: x => x.paymentinstaid,
                        principalTable: "InstaPostMsts",
                        principalColumn: "instapostid",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "UserInstaPostHandlerMsts",
                columns: table => new
                {
                    userhandlerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(type: "int", nullable: false),
                    instapostid = table.Column<int>(type: "int", nullable: false),
                    instalike = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instacomment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    instashare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    instasave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userhandlertime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInstaPostHandlerMsts", x => x.userhandlerid);
                    table.ForeignKey(
                        name: "FK_UserInstaPostHandlerMsts_InstaPostMsts_instapostid",
                        column: x => x.instapostid,
                        principalTable: "InstaPostMsts",
                        principalColumn: "instapostid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserInstaPostHandlerMsts_UserMsts_userid",
                        column: x => x.userid,
                        principalTable: "UserMsts",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "brandYouTubePaymentTransactionMsts",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    paymentrecipt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    transcationid = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    contactno = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    paymentbranduserid = table.Column<int>(type: "int", nullable: false),
                    paymentyoutubeid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_brandYouTubePaymentTransactionMsts", x => x.id);
                    table.ForeignKey(
                        name: "FK_brandYouTubePaymentTransactionMsts_BrandRegistrationMst_paymentbranduserid",
                        column: x => x.paymentbranduserid,
                        principalTable: "BrandRegistrationMst",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_brandYouTubePaymentTransactionMsts_YouTubePostMst_paymentyoutubeid",
                        column: x => x.paymentyoutubeid,
                        principalTable: "YouTubePostMst",
                        principalColumn: "youtubepostid",
                        onDelete: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "userYoutubePostHandlerMsts",
                columns: table => new
                {
                    userhandlerid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userid = table.Column<int>(type: "int", nullable: false),
                    youtubeid = table.Column<int>(type: "int", nullable: false),
                    youtubelike = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    youtubecomment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    youtubeshare = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    youtubesave = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    userhandlertime = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_userYoutubePostHandlerMsts", x => x.userhandlerid);
                    table.ForeignKey(
                        name: "FK_userYoutubePostHandlerMsts_UserMsts_userid",
                        column: x => x.userid,
                        principalTable: "UserMsts",
                        principalColumn: "userid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_userYoutubePostHandlerMsts_YouTubePostMst_youtubeid",
                        column: x => x.youtubeid,
                        principalTable: "YouTubePostMst",
                        principalColumn: "youtubepostid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrandPaymentTransactionMsts_paymentbranduserid",
                table: "BrandPaymentTransactionMsts",
                column: "paymentbranduserid");

            migrationBuilder.CreateIndex(
                name: "IX_BrandPaymentTransactionMsts_paymentinstaid",
                table: "BrandPaymentTransactionMsts",
                column: "paymentinstaid");

            migrationBuilder.CreateIndex(
                name: "IX_brandYouTubePaymentTransactionMsts_paymentbranduserid",
                table: "brandYouTubePaymentTransactionMsts",
                column: "paymentbranduserid");

            migrationBuilder.CreateIndex(
                name: "IX_brandYouTubePaymentTransactionMsts_paymentyoutubeid",
                table: "brandYouTubePaymentTransactionMsts",
                column: "paymentyoutubeid");

            migrationBuilder.CreateIndex(
                name: "IX_InstaPostMsts_instabranduserid",
                table: "InstaPostMsts",
                column: "instabranduserid");

            migrationBuilder.CreateIndex(
                name: "IX_StateMsts_CityMstcityid",
                table: "StateMsts",
                column: "CityMstcityid");

            migrationBuilder.CreateIndex(
                name: "IX_UserInstaPostHandlerMsts_instapostid",
                table: "UserInstaPostHandlerMsts",
                column: "instapostid");

            migrationBuilder.CreateIndex(
                name: "IX_UserInstaPostHandlerMsts_userid",
                table: "UserInstaPostHandlerMsts",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_userYoutubePostHandlerMsts_userid",
                table: "userYoutubePostHandlerMsts",
                column: "userid");

            migrationBuilder.CreateIndex(
                name: "IX_userYoutubePostHandlerMsts_youtubeid",
                table: "userYoutubePostHandlerMsts",
                column: "youtubeid");

            migrationBuilder.CreateIndex(
                name: "IX_YouTubePostMst_youtubebranduserid",
                table: "YouTubePostMst",
                column: "youtubebranduserid");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AreaMsts");

            migrationBuilder.DropTable(
                name: "BrandCategoryMst");

            migrationBuilder.DropTable(
                name: "BrandPaymentTransactionMsts");

            migrationBuilder.DropTable(
                name: "brandYouTubePaymentTransactionMsts");

            migrationBuilder.DropTable(
                name: "InstaPostBudgetMst");

            migrationBuilder.DropTable(
                name: "QrMst");

            migrationBuilder.DropTable(
                name: "StateMsts");

            migrationBuilder.DropTable(
                name: "UserInstaPostHandlerMsts");

            migrationBuilder.DropTable(
                name: "userYoutubePostHandlerMsts");

            migrationBuilder.DropTable(
                name: "youTubePostBudgetMsts");

            migrationBuilder.DropTable(
                name: "CityMsts");

            migrationBuilder.DropTable(
                name: "InstaPostMsts");

            migrationBuilder.DropTable(
                name: "UserMsts");

            migrationBuilder.DropTable(
                name: "YouTubePostMst");

            migrationBuilder.DropTable(
                name: "BrandRegistrationMst");
        }
    }
}
