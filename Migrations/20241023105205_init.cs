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
                    bconfirmpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bstatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandRegistrationMst", x => x.id);
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
                    uconfirmemail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    upassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uconfirmpassword = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrandCategoryMst");

            migrationBuilder.DropTable(
                name: "BrandRegistrationMst");

            migrationBuilder.DropTable(
                name: "UserMsts");
        }
    }
}
