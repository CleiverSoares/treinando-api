using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace projetoMaroto.Migrations
{
    /// <inheritdoc />
    public partial class criacaoInicial2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "pessoa_id",
                table: "endereco",
                type: "integer",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "pessoa_id",
                table: "endereco");
        }
    }
}
