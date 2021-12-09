using Microsoft.EntityFrameworkCore.Migrations;

namespace Business.Migrations
{
    public partial class create_table : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderForm",
                table: "OrderForm");

            migrationBuilder.RenameTable(
                name: "OrderForm",
                newName: "tb_OrderForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tb_OrderForm",
                table: "tb_OrderForm",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tb_OrderForm",
                table: "tb_OrderForm");

            migrationBuilder.RenameTable(
                name: "tb_OrderForm",
                newName: "OrderForm");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderForm",
                table: "OrderForm",
                column: "Id");
        }
    }
}
