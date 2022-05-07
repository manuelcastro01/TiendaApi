using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TiendaServicios.Api.Autor.Migrations
{
    public partial class EliminarRelacion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GradosAcademicos_AutoresLibros_AutorLibroIdAutorLibro",
                table: "GradosAcademicos");

            migrationBuilder.DropIndex(
                name: "IX_GradosAcademicos_AutorLibroIdAutorLibro",
                table: "GradosAcademicos");

            migrationBuilder.DropColumn(
                name: "AutorLibroIdAutorLibro",
                table: "GradosAcademicos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AutorLibroIdAutorLibro",
                table: "GradosAcademicos",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_GradosAcademicos_AutorLibroIdAutorLibro",
                table: "GradosAcademicos",
                column: "AutorLibroIdAutorLibro");

            migrationBuilder.AddForeignKey(
                name: "FK_GradosAcademicos_AutoresLibros_AutorLibroIdAutorLibro",
                table: "GradosAcademicos",
                column: "AutorLibroIdAutorLibro",
                principalTable: "AutoresLibros",
                principalColumn: "IdAutorLibro",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
