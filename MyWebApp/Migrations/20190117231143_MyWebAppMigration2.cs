using Microsoft.EntityFrameworkCore.Migrations;

namespace MyWebApp.Migrations
{
    public partial class MyWebAppMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Pedidos_Pedidos_Pedidoid",
                table: "Pedidos");

            migrationBuilder.DropIndex(
                name: "IX_Pedidos_Pedidoid",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "Pedidoid",
                table: "Pedidos");

            migrationBuilder.AddColumn<int>(
                name: "Pedidoid",
                table: "Itens",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Itens_Pedidoid",
                table: "Itens",
                column: "Pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Itens_Pedidos_Pedidoid",
                table: "Itens",
                column: "Pedidoid",
                principalTable: "Pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Itens_Pedidos_Pedidoid",
                table: "Itens");

            migrationBuilder.DropIndex(
                name: "IX_Itens_Pedidoid",
                table: "Itens");

            migrationBuilder.DropColumn(
                name: "Pedidoid",
                table: "Itens");

            migrationBuilder.AddColumn<int>(
                name: "Pedidoid",
                table: "Pedidos",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Pedidos_Pedidoid",
                table: "Pedidos",
                column: "Pedidoid");

            migrationBuilder.AddForeignKey(
                name: "FK_Pedidos_Pedidos_Pedidoid",
                table: "Pedidos",
                column: "Pedidoid",
                principalTable: "Pedidos",
                principalColumn: "id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
