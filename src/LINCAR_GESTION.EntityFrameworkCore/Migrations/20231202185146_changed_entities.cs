using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LINCAR_GESTION.Migrations
{
    /// <inheritdoc />
    public partial class changed_entities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atributo_Autoparte_AutoparteId",
                table: "Atributo");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteModeloProducto_Autoparte_AutopartesId",
                table: "AutoparteModeloProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteModeloProducto_ModeloProducto_ModelosProduccionId",
                table: "AutoparteModeloProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteSectorProduccion_Autoparte_AutopartesId",
                table: "AutoparteSectorProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteSectorProduccion_SectorProduccion_SectoresProduccionId",
                table: "AutoparteSectorProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleado_SectorProduccion_SectorProduccionId",
                table: "Empleado");

            migrationBuilder.DropForeignKey(
                name: "FK_EstadoOrdenProduccion_OrdenProduccion_OrdenId",
                table: "EstadoOrdenProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_Observaciones_Autoparte_AutoparteId",
                table: "Observaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Observaciones_OrdenProduccion_OrdenProduccionId",
                table: "Observaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_Observaciones_OrdenTrabajoAutoparte_OrdenTrabajoAutoparteId",
                table: "Observaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenProduccion_Cliente_ClienteId",
                table: "OrdenProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenProduccion_ModeloProducto_ModeloProductoId",
                table: "OrdenProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenTrabajoAutoparte_Autoparte_AutoparteId",
                table: "OrdenTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenTrabajoAutoparte_Empleado_EmpleadoId",
                table: "OrdenTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_OrdenTrabajoAutoparte_OrdenProduccion_ordenProduccionId",
                table: "OrdenTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_SectorProduccion_Empleado_EncargadoId",
                table: "SectorProduccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_SectorProduccion",
                table: "SectorProduccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenTrabajoAutoparte",
                table: "OrdenTrabajoAutoparte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrdenProduccion",
                table: "OrdenProduccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Observaciones",
                table: "Observaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ModeloProducto",
                table: "ModeloProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Autoparte",
                table: "Autoparte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Atributo",
                table: "Atributo");

            migrationBuilder.RenameTable(
                name: "SectorProduccion",
                newName: "AppSectoresProduccion");

            migrationBuilder.RenameTable(
                name: "OrdenTrabajoAutoparte",
                newName: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.RenameTable(
                name: "OrdenProduccion",
                newName: "AppOrdenesProduccion");

            migrationBuilder.RenameTable(
                name: "Observaciones",
                newName: "AppObservaciones");

            migrationBuilder.RenameTable(
                name: "ModeloProducto",
                newName: "AppModelosProducto");

            migrationBuilder.RenameTable(
                name: "Empleado",
                newName: "AppEmpleados");

            migrationBuilder.RenameTable(
                name: "Cliente",
                newName: "AppClientes");

            migrationBuilder.RenameTable(
                name: "Autoparte",
                newName: "AppAutopartes");

            migrationBuilder.RenameTable(
                name: "Atributo",
                newName: "AppAtributos");

            migrationBuilder.RenameColumn(
                name: "OrdenId",
                table: "EstadoOrdenProduccion",
                newName: "OrdenProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_EstadoOrdenProduccion_OrdenId",
                table: "EstadoOrdenProduccion",
                newName: "IX_EstadoOrdenProduccion_OrdenProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_SectorProduccion_EncargadoId",
                table: "AppSectoresProduccion",
                newName: "IX_AppSectoresProduccion_EncargadoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenTrabajoAutoparte_ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte",
                newName: "IX_AppOrdenesTrabajoAutoparte_ordenProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenTrabajoAutoparte_EmpleadoId",
                table: "AppOrdenesTrabajoAutoparte",
                newName: "IX_AppOrdenesTrabajoAutoparte_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenTrabajoAutoparte_AutoparteId",
                table: "AppOrdenesTrabajoAutoparte",
                newName: "IX_AppOrdenesTrabajoAutoparte_AutoparteId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenProduccion_ModeloProductoId",
                table: "AppOrdenesProduccion",
                newName: "IX_AppOrdenesProduccion_ModeloProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_OrdenProduccion_ClienteId",
                table: "AppOrdenesProduccion",
                newName: "IX_AppOrdenesProduccion_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_Observaciones_OrdenTrabajoAutoparteId",
                table: "AppObservaciones",
                newName: "IX_AppObservaciones_OrdenTrabajoAutoparteId");

            migrationBuilder.RenameIndex(
                name: "IX_Observaciones_OrdenProduccionId",
                table: "AppObservaciones",
                newName: "IX_AppObservaciones_OrdenProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_Observaciones_AutoparteId",
                table: "AppObservaciones",
                newName: "IX_AppObservaciones_AutoparteId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleado_SectorProduccionId",
                table: "AppEmpleados",
                newName: "IX_AppEmpleados_SectorProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_Atributo_AutoparteId",
                table: "AppAtributos",
                newName: "IX_AppAtributos_AutoparteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppSectoresProduccion",
                table: "AppSectoresProduccion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppOrdenesTrabajoAutoparte",
                table: "AppOrdenesTrabajoAutoparte",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppOrdenesProduccion",
                table: "AppOrdenesProduccion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppObservaciones",
                table: "AppObservaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppModelosProducto",
                table: "AppModelosProducto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppEmpleados",
                table: "AppEmpleados",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppClientes",
                table: "AppClientes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAutopartes",
                table: "AppAutopartes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppAtributos",
                table: "AppAtributos",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "AppEstadosOrdenTrabajoAutoparte",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<int>(type: "int", nullable: false),
                    FechaHoraHasta = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrdenTrabajoAutoparteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppEstadosOrdenTrabajoAutoparte", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AppEstadosOrdenTrabajoAutoparte_AppOrdenesTrabajoAutoparte_OrdenTrabajoAutoparteId",
                        column: x => x.OrdenTrabajoAutoparteId,
                        principalTable: "AppOrdenesTrabajoAutoparte",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AppEstadosOrdenTrabajoAutoparte_OrdenTrabajoAutoparteId",
                table: "AppEstadosOrdenTrabajoAutoparte",
                column: "OrdenTrabajoAutoparteId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppAtributos_AppAutopartes_AutoparteId",
                table: "AppAtributos",
                column: "AutoparteId",
                principalTable: "AppAutopartes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppEmpleados_AppSectoresProduccion_SectorProduccionId",
                table: "AppEmpleados",
                column: "SectorProduccionId",
                principalTable: "AppSectoresProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppObservaciones_AppAutopartes_AutoparteId",
                table: "AppObservaciones",
                column: "AutoparteId",
                principalTable: "AppAutopartes",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppObservaciones_AppOrdenesProduccion_OrdenProduccionId",
                table: "AppObservaciones",
                column: "OrdenProduccionId",
                principalTable: "AppOrdenesProduccion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppObservaciones_AppOrdenesTrabajoAutoparte_OrdenTrabajoAutoparteId",
                table: "AppObservaciones",
                column: "OrdenTrabajoAutoparteId",
                principalTable: "AppOrdenesTrabajoAutoparte",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesProduccion_AppClientes_ClienteId",
                table: "AppOrdenesProduccion",
                column: "ClienteId",
                principalTable: "AppClientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesProduccion_AppModelosProducto_ModeloProductoId",
                table: "AppOrdenesProduccion",
                column: "ModeloProductoId",
                principalTable: "AppModelosProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppAutopartes_AutoparteId",
                table: "AppOrdenesTrabajoAutoparte",
                column: "AutoparteId",
                principalTable: "AppAutopartes",
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

            migrationBuilder.AddForeignKey(
                name: "FK_AppSectoresProduccion_AppEmpleados_EncargadoId",
                table: "AppSectoresProduccion",
                column: "EncargadoId",
                principalTable: "AppEmpleados",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteModeloProducto_AppAutopartes_AutopartesId",
                table: "AutoparteModeloProducto",
                column: "AutopartesId",
                principalTable: "AppAutopartes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteModeloProducto_AppModelosProducto_ModelosProduccionId",
                table: "AutoparteModeloProducto",
                column: "ModelosProduccionId",
                principalTable: "AppModelosProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteSectorProduccion_AppAutopartes_AutopartesId",
                table: "AutoparteSectorProduccion",
                column: "AutopartesId",
                principalTable: "AppAutopartes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteSectorProduccion_AppSectoresProduccion_SectoresProduccionId",
                table: "AutoparteSectorProduccion",
                column: "SectoresProduccionId",
                principalTable: "AppSectoresProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoOrdenProduccion_AppOrdenesProduccion_OrdenProduccionId",
                table: "EstadoOrdenProduccion",
                column: "OrdenProduccionId",
                principalTable: "AppOrdenesProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppAtributos_AppAutopartes_AutoparteId",
                table: "AppAtributos");

            migrationBuilder.DropForeignKey(
                name: "FK_AppEmpleados_AppSectoresProduccion_SectorProduccionId",
                table: "AppEmpleados");

            migrationBuilder.DropForeignKey(
                name: "FK_AppObservaciones_AppAutopartes_AutoparteId",
                table: "AppObservaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_AppObservaciones_AppOrdenesProduccion_OrdenProduccionId",
                table: "AppObservaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_AppObservaciones_AppOrdenesTrabajoAutoparte_OrdenTrabajoAutoparteId",
                table: "AppObservaciones");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesProduccion_AppClientes_ClienteId",
                table: "AppOrdenesProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesProduccion_AppModelosProducto_ModeloProductoId",
                table: "AppOrdenesProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppAutopartes_AutoparteId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppEmpleados_EmpleadoId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_AppOrdenesTrabajoAutoparte_AppOrdenesProduccion_ordenProduccionId",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropForeignKey(
                name: "FK_AppSectoresProduccion_AppEmpleados_EncargadoId",
                table: "AppSectoresProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteModeloProducto_AppAutopartes_AutopartesId",
                table: "AutoparteModeloProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteModeloProducto_AppModelosProducto_ModelosProduccionId",
                table: "AutoparteModeloProducto");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteSectorProduccion_AppAutopartes_AutopartesId",
                table: "AutoparteSectorProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_AutoparteSectorProduccion_AppSectoresProduccion_SectoresProduccionId",
                table: "AutoparteSectorProduccion");

            migrationBuilder.DropForeignKey(
                name: "FK_EstadoOrdenProduccion_AppOrdenesProduccion_OrdenProduccionId",
                table: "EstadoOrdenProduccion");

            migrationBuilder.DropTable(
                name: "AppEstadosOrdenTrabajoAutoparte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppSectoresProduccion",
                table: "AppSectoresProduccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppOrdenesTrabajoAutoparte",
                table: "AppOrdenesTrabajoAutoparte");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppOrdenesProduccion",
                table: "AppOrdenesProduccion");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppObservaciones",
                table: "AppObservaciones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppModelosProducto",
                table: "AppModelosProducto");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppEmpleados",
                table: "AppEmpleados");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppClientes",
                table: "AppClientes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAutopartes",
                table: "AppAutopartes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppAtributos",
                table: "AppAtributos");

            migrationBuilder.RenameTable(
                name: "AppSectoresProduccion",
                newName: "SectorProduccion");

            migrationBuilder.RenameTable(
                name: "AppOrdenesTrabajoAutoparte",
                newName: "OrdenTrabajoAutoparte");

            migrationBuilder.RenameTable(
                name: "AppOrdenesProduccion",
                newName: "OrdenProduccion");

            migrationBuilder.RenameTable(
                name: "AppObservaciones",
                newName: "Observaciones");

            migrationBuilder.RenameTable(
                name: "AppModelosProducto",
                newName: "ModeloProducto");

            migrationBuilder.RenameTable(
                name: "AppEmpleados",
                newName: "Empleado");

            migrationBuilder.RenameTable(
                name: "AppClientes",
                newName: "Cliente");

            migrationBuilder.RenameTable(
                name: "AppAutopartes",
                newName: "Autoparte");

            migrationBuilder.RenameTable(
                name: "AppAtributos",
                newName: "Atributo");

            migrationBuilder.RenameColumn(
                name: "OrdenProduccionId",
                table: "EstadoOrdenProduccion",
                newName: "OrdenId");

            migrationBuilder.RenameIndex(
                name: "IX_EstadoOrdenProduccion_OrdenProduccionId",
                table: "EstadoOrdenProduccion",
                newName: "IX_EstadoOrdenProduccion_OrdenId");

            migrationBuilder.RenameIndex(
                name: "IX_AppSectoresProduccion_EncargadoId",
                table: "SectorProduccion",
                newName: "IX_SectorProduccion_EncargadoId");

            migrationBuilder.RenameIndex(
                name: "IX_AppOrdenesTrabajoAutoparte_ordenProduccionId",
                table: "OrdenTrabajoAutoparte",
                newName: "IX_OrdenTrabajoAutoparte_ordenProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppOrdenesTrabajoAutoparte_EmpleadoId",
                table: "OrdenTrabajoAutoparte",
                newName: "IX_OrdenTrabajoAutoparte_EmpleadoId");

            migrationBuilder.RenameIndex(
                name: "IX_AppOrdenesTrabajoAutoparte_AutoparteId",
                table: "OrdenTrabajoAutoparte",
                newName: "IX_OrdenTrabajoAutoparte_AutoparteId");

            migrationBuilder.RenameIndex(
                name: "IX_AppOrdenesProduccion_ModeloProductoId",
                table: "OrdenProduccion",
                newName: "IX_OrdenProduccion_ModeloProductoId");

            migrationBuilder.RenameIndex(
                name: "IX_AppOrdenesProduccion_ClienteId",
                table: "OrdenProduccion",
                newName: "IX_OrdenProduccion_ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_AppObservaciones_OrdenTrabajoAutoparteId",
                table: "Observaciones",
                newName: "IX_Observaciones_OrdenTrabajoAutoparteId");

            migrationBuilder.RenameIndex(
                name: "IX_AppObservaciones_OrdenProduccionId",
                table: "Observaciones",
                newName: "IX_Observaciones_OrdenProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppObservaciones_AutoparteId",
                table: "Observaciones",
                newName: "IX_Observaciones_AutoparteId");

            migrationBuilder.RenameIndex(
                name: "IX_AppEmpleados_SectorProduccionId",
                table: "Empleado",
                newName: "IX_Empleado_SectorProduccionId");

            migrationBuilder.RenameIndex(
                name: "IX_AppAtributos_AutoparteId",
                table: "Atributo",
                newName: "IX_Atributo_AutoparteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_SectorProduccion",
                table: "SectorProduccion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenTrabajoAutoparte",
                table: "OrdenTrabajoAutoparte",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrdenProduccion",
                table: "OrdenProduccion",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Observaciones",
                table: "Observaciones",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ModeloProducto",
                table: "ModeloProducto",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleado",
                table: "Empleado",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Cliente",
                table: "Cliente",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Autoparte",
                table: "Autoparte",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Atributo",
                table: "Atributo",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Atributo_Autoparte_AutoparteId",
                table: "Atributo",
                column: "AutoparteId",
                principalTable: "Autoparte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteModeloProducto_Autoparte_AutopartesId",
                table: "AutoparteModeloProducto",
                column: "AutopartesId",
                principalTable: "Autoparte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteModeloProducto_ModeloProducto_ModelosProduccionId",
                table: "AutoparteModeloProducto",
                column: "ModelosProduccionId",
                principalTable: "ModeloProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteSectorProduccion_Autoparte_AutopartesId",
                table: "AutoparteSectorProduccion",
                column: "AutopartesId",
                principalTable: "Autoparte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AutoparteSectorProduccion_SectorProduccion_SectoresProduccionId",
                table: "AutoparteSectorProduccion",
                column: "SectoresProduccionId",
                principalTable: "SectorProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleado_SectorProduccion_SectorProduccionId",
                table: "Empleado",
                column: "SectorProduccionId",
                principalTable: "SectorProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_EstadoOrdenProduccion_OrdenProduccion_OrdenId",
                table: "EstadoOrdenProduccion",
                column: "OrdenId",
                principalTable: "OrdenProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Observaciones_Autoparte_AutoparteId",
                table: "Observaciones",
                column: "AutoparteId",
                principalTable: "Autoparte",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Observaciones_OrdenProduccion_OrdenProduccionId",
                table: "Observaciones",
                column: "OrdenProduccionId",
                principalTable: "OrdenProduccion",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Observaciones_OrdenTrabajoAutoparte_OrdenTrabajoAutoparteId",
                table: "Observaciones",
                column: "OrdenTrabajoAutoparteId",
                principalTable: "OrdenTrabajoAutoparte",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenProduccion_Cliente_ClienteId",
                table: "OrdenProduccion",
                column: "ClienteId",
                principalTable: "Cliente",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenProduccion_ModeloProducto_ModeloProductoId",
                table: "OrdenProduccion",
                column: "ModeloProductoId",
                principalTable: "ModeloProducto",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenTrabajoAutoparte_Autoparte_AutoparteId",
                table: "OrdenTrabajoAutoparte",
                column: "AutoparteId",
                principalTable: "Autoparte",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenTrabajoAutoparte_Empleado_EmpleadoId",
                table: "OrdenTrabajoAutoparte",
                column: "EmpleadoId",
                principalTable: "Empleado",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_OrdenTrabajoAutoparte_OrdenProduccion_ordenProduccionId",
                table: "OrdenTrabajoAutoparte",
                column: "ordenProduccionId",
                principalTable: "OrdenProduccion",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SectorProduccion_Empleado_EncargadoId",
                table: "SectorProduccion",
                column: "EncargadoId",
                principalTable: "Empleado",
                principalColumn: "Id");
        }
    }
}
