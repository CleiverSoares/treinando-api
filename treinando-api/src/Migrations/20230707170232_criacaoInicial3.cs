using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace projetoMaroto.Migrations
{
    /// <inheritdoc />
    public partial class criacaoInicial3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_endereco_pessoa_id_endereco",
                table: "endereco");

            migrationBuilder.AlterColumn<int>(
                name: "id_endereco",
                table: "endereco",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.CreateIndex(
                name: "IX_endereco_pessoa_id",
                table: "endereco",
                column: "pessoa_id");

            migrationBuilder.AddForeignKey(
                name: "FK_endereco_pessoa_pessoa_id",
                table: "endereco",
                column: "pessoa_id",
                principalTable: "pessoa",
                principalColumn: "id_pessoa",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_endereco_pessoa_pessoa_id",
                table: "endereco");

            migrationBuilder.DropIndex(
                name: "IX_endereco_pessoa_id",
                table: "endereco");

            migrationBuilder.AlterColumn<int>(
                name: "id_endereco",
                table: "endereco",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "integer")
                .OldAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            migrationBuilder.AddForeignKey(
                name: "FK_endereco_pessoa_id_endereco",
                table: "endereco",
                column: "id_endereco",
                principalTable: "pessoa",
                principalColumn: "id_pessoa",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
