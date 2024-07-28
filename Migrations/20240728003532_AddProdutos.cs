using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EcommerceApi.Migrations
{
    /// <inheritdoc />
    public partial class AddProdutos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantidade",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Preco",
                table: "Produtos",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Produtos",
                newName: "Name");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Produtos",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Produtos");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "Produtos",
                newName: "Preco");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Produtos",
                newName: "Nome");

            migrationBuilder.AddColumn<int>(
                name: "Quantidade",
                table: "Produtos",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }
    }
}
