using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Adminservice.Migrations
{
    public partial class alter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           

            migrationBuilder.AddColumn<bool>(
                name: "RoundTrip",
                table: "Flight",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RoundTrip",
                table: "Flight");

            migrationBuilder.CreateTable(
                name: "test",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PNR = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "test1",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    PNR = table.Column<string>(nullable: true, computedColumnSql: "N'PNR'+ RIGHT('00000'+CAST(ID AS VARCHAR(5)),5)")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_test1", x => x.ID);
                });
        }
    }
}
