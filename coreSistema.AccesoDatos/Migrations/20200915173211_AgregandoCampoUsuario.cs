using Microsoft.EntityFrameworkCore.Migrations;

namespace coreSistema.AccesoDatos.Migrations
{
    public partial class AgregandoCampoUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UsuarioId",
                table: "VPS",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_VPS_UsuarioId",
                table: "VPS",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_VPS_AspNetUsers_UsuarioId",
                table: "VPS",
                column: "UsuarioId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_VPS_AspNetUsers_UsuarioId",
                table: "VPS");

            migrationBuilder.DropIndex(
                name: "IX_VPS_UsuarioId",
                table: "VPS");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "VPS");
        }
    }
}
