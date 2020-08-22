using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectManager.Data.Migrations
{
    public partial class InitialCreation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Persona",
                columns: table => new
                {
                    Identificacion = table.Column<string>(type: "nvarchar(25)", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Apellido = table.Column<string>(type: "nvarchar(100)", nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Programa = table.Column<string>(type: "nvarchar(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persona", x => x.Identificacion);
                });

            migrationBuilder.CreateTable(
                name: "Proyecto",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Tipo = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Estado = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Tutor = table.Column<int>(nullable: false),
                    Equipo = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Proyecto", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "nvarchar(50)", nullable: true),
                    Descripcion = table.Column<string>(type: "nvarchar(500)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(10)", nullable: true),
                    Proyecto = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.Codigo);
                });

            migrationBuilder.CreateTable(
                name: "Actividad",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Descripcion = table.Column<string>(nullable: true),
                    Tipo = table.Column<int>(nullable: false),
                    Nota = table.Column<double>(nullable: false),
                    ProyectoCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actividad", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Actividad_Proyecto_ProyectoCodigo",
                        column: x => x.ProyectoCodigo,
                        principalTable: "Proyecto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Documento",
                columns: table => new
                {
                    Codigo = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ruta = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    ProyectoCodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documento", x => x.Codigo);
                    table.ForeignKey(
                        name: "FK_Documento_Proyecto_ProyectoCodigo",
                        column: x => x.ProyectoCodigo,
                        principalTable: "Proyecto",
                        principalColumn: "Codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actividad_ProyectoCodigo",
                table: "Actividad",
                column: "ProyectoCodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Documento_ProyectoCodigo",
                table: "Documento",
                column: "ProyectoCodigo");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Actividad");

            migrationBuilder.DropTable(
                name: "Documento");

            migrationBuilder.DropTable(
                name: "Persona");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Proyecto");
        }
    }
}
