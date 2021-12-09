using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class Added_To : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_OrderForm",
                table: "tb_OrderForm");

            migrationBuilder.RenameTable(
                name: "tb_OrderForm",
                newName: "tb _OrderForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb _OrderForm",
                table: "tb _OrderForm",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb _OrderForm",
                table: "tb _OrderForm");

            migrationBuilder.RenameTable(
                name: "tb _OrderForm",
                newName: "tb_OrderForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_OrderForm",
                table: "tb_OrderForm",
                column: "Id");
        }
    }
}
