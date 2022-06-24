using Microsoft.EntityFrameworkCore.Migrations;

namespace Adminservice.Migrations
{
    public partial class mmm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PNR",
                table: "test1",
                nullable: true,
                computedColumnSql: "N'PNR'+ RIGHT('00000'+CAST(ID AS VARCHAR(5)),5)",
                oldClrType: typeof(string),
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PNR",
                table: "test1",
                nullable: true,
                oldClrType: typeof(string),
                oldNullable: true,
                oldComputedColumnSql: "N'PNR'+ RIGHT('00000'+CAST(ID AS VARCHAR(5)),5)");
        }
    }
}
