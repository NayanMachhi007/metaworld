using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Meta_Ads_World.Migrations
{
    /// <inheritdoc />
    public partial class instagrambudget : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "InstaPostBudgetMst");
        }
    }
}
