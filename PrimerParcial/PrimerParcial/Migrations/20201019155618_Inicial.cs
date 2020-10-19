using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace PrimerParcial.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TipoTarea",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(nullable: true),
                    tipoId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoTarea", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "Usuario",
                columns: table => new
                {
                    codigo = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: false),
                    clave = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuario", x => x.codigo);
                });

            migrationBuilder.CreateTable(
                name: "Recurso",
                columns: table => new
                {
                    idRecurso = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    nombre = table.Column<string>(nullable: true),
                    usuariocodigo = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recurso", x => x.idRecurso);
                    table.ForeignKey(
                        name: "FK_Recurso_Usuario_usuariocodigo",
                        column: x => x.usuariocodigo,
                        principalTable: "Usuario",
                        principalColumn: "codigo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Tarea",
                columns: table => new
                {
                    idTarea = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    titulo = table.Column<string>(nullable: true),
                    vencimiento = table.Column<DateTime>(nullable: false),
                    estimacion = table.Column<int>(nullable: false),
                    responsableidRecurso = table.Column<int>(nullable: true),
                    estado = table.Column<bool>(nullable: false),
                    tipoid = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tarea", x => x.idTarea);
                    table.ForeignKey(
                        name: "FK_Tarea_Recurso_responsableidRecurso",
                        column: x => x.responsableidRecurso,
                        principalTable: "Recurso",
                        principalColumn: "idRecurso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Tarea_TipoTarea_tipoid",
                        column: x => x.tipoid,
                        principalTable: "TipoTarea",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Detalle",
                columns: table => new
                {
                    idDetalle = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    fecha = table.Column<DateTime>(nullable: false),
                    Tiempo = table.Column<string>(nullable: true),
                    recursoidRecurso = table.Column<int>(nullable: true),
                    tareaidTarea = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detalle", x => x.idDetalle);
                    table.ForeignKey(
                        name: "FK_Detalle_Recurso_recursoidRecurso",
                        column: x => x.recursoidRecurso,
                        principalTable: "Recurso",
                        principalColumn: "idRecurso",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Detalle_Tarea_tareaidTarea",
                        column: x => x.tareaidTarea,
                        principalTable: "Tarea",
                        principalColumn: "idTarea",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_recursoidRecurso",
                table: "Detalle",
                column: "recursoidRecurso");

            migrationBuilder.CreateIndex(
                name: "IX_Detalle_tareaidTarea",
                table: "Detalle",
                column: "tareaidTarea");

            migrationBuilder.CreateIndex(
                name: "IX_Recurso_usuariocodigo",
                table: "Recurso",
                column: "usuariocodigo");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_responsableidRecurso",
                table: "Tarea",
                column: "responsableidRecurso");

            migrationBuilder.CreateIndex(
                name: "IX_Tarea_tipoid",
                table: "Tarea",
                column: "tipoid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Detalle");

            migrationBuilder.DropTable(
                name: "Tarea");

            migrationBuilder.DropTable(
                name: "Recurso");

            migrationBuilder.DropTable(
                name: "TipoTarea");

            migrationBuilder.DropTable(
                name: "Usuario");
        }
    }
}
