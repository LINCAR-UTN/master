using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LINCAR_GESTION.Migrations
{
    /// <inheritdoc />
    public partial class modificado_Autoparte_sectorProduccion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppEmpleados_AppSectoresProduccion_SectorProduccionId",
                table: "AppEmpleados");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppEmpleados_EmpleadoId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppOrdenesProduccion_ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropIndex(
                name: "IX_AppEmpleados_SectorProduccionId",
                table: "AppEmpleados");

            migrationBuilder.DropColumn(
                name: "SectorProduccionId",
                table: "AppEmpleados");

            migrationBuilder.AlterColumn<int>(
                name: "ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "SolicitanteId",
                table: "AppOrdenesTrabajoAutoparte",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "EmpleadoSectorProduccion",
                columns: table => new
                {
                    EmpleadosId = table.Column<int>(type: "int", nullable: false),
                    SectorProduccionEmpleadoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmpleadoSectorProduccion", x => new { x.EmpleadosId, x.SectorProduccionEmpleadoId });
                    table.ForeignKey(
                        name: "FK_EmpleadoSectorProduccion_AppEmpleados_EmpleadosId",
                        column: x => x.EmpleadosId,
                        principalTable: "AppEmpleados",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EmpleadoSectorProduccion_AppSectoresProduccion_SectorProduccionEmpleadoId",
                        column: x => x.SectorProduccionEmpleadoId,
                        principalTable: "AppSectoresProduccion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppOrdenesTrabajoAutoparte_SolicitanteId",
                table: "AppOrdenesTrabajoAutoparte",
                column: "SolicitanteId");

            migrationBuilder.CreateIndex(
                name: "IX_EmpleadoSectorProduccion_SectorProduccionEmpleadoId",
                table: "EmpleadoSectorProduccion",
                column: "SectorProduccionEmpleadoId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppEmpleados_EmpleadoId",
                table: "AppOrdenesTrabajoAutoparte",
                column: "EmpleadoId",
                principalTable: "AppEmpleados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppEmpleados_SolicitanteId",
                table: "AppOrdenesTrabajoAutoparte",
                column: "SolicitanteId",
                principalTable: "AppEmpleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppOrdenesProduccion_ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte",
                column: "ordenProduccionId",
                principalTable: "AppOrdenesProduccion",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppEmpleados_EmpleadoId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppEmpleados_SolicitanteId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppOrdenesProduccion_ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropTable(
                name: "EmpleadoSectorProduccion");

            migrationBuilder.DropIndex(
                name: "IX_AppOrdenesTrabajoAutoparte_SolicitanteId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropColumn(
                name: "SolicitanteId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.AlterColumn<int>(
                name: "ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "SectorProduccionId",
                table: "AppEmpleados",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateIndex(
                name: "IX_AppEmpleados_SectorProduccionId",
                table: "AppEmpleados",
                column: "SectorProduccionId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppEmpleados_AppSectoresProduccion_SectorProduccionId",
                table: "AppEmpleados",
                column: "SectorProduccionId",
                principalTable: "AppSectoresProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppEmpleados_EmpleadoId",
                table: "AppOrdenesTrabajoAutoparte",
                column: "EmpleadoId",
                principalTable: "AppEmpleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppOrdenesProduccion_ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte",
                column: "ordenProduccionId",
                principalTable: "AppOrdenesProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
