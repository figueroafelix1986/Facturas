using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace factura.Migrations
{
    public partial class ManyToMany_ServiciosCotizacionDetalles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Telefono = table.Column<string>(nullable: true),
                    Representante = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    CodigoReup = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EstadoCotiz",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    EstadoCotizacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EstadoCotiz", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Moneda",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TipoMoneda = table.Column<string>(nullable: true),
                    Cambio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Moneda", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ServicioTCP",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Precio = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioTCP", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tcps",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Nombre = table.Column<string>(nullable: true),
                    Apellidos = table.Column<string>(nullable: true),
                    NIT = table.Column<string>(nullable: true),
                    Carnet = table.Column<string>(nullable: true),
                    NumLicencia = table.Column<string>(nullable: true),
                    Codigo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tcps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contrato",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    FechaFin = table.Column<DateTime>(nullable: false),
                    Activo = table.Column<bool>(nullable: false),
                    NumContrato = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contrato", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contrato_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cotizacion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroCotizacion = table.Column<string>(nullable: true),
                    FechaInicio = table.Column<DateTime>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    observa = table.Column<string>(nullable: true),
                    EmpresaId = table.Column<int>(nullable: false),
                    EstadoCotizId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cotizacion", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cotizacion_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cotizacion_EstadoCotiz_EstadoCotizId",
                        column: x => x.EstadoCotizId,
                        principalTable: "EstadoCotiz",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Cuentas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NumeroCuenta = table.Column<string>(nullable: true),
                    Banco = table.Column<string>(nullable: true),
                    TcpId = table.Column<int>(nullable: false),
                    EmpresaId = table.Column<int>(nullable: false),
                    MonedId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cuentas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Cuentas_Empresas_EmpresaId",
                        column: x => x.EmpresaId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cuentas_Moneda_MonedId",
                        column: x => x.MonedId,
                        principalTable: "Moneda",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Cuentas_Tcps_TcpId",
                        column: x => x.TcpId,
                        principalTable: "Tcps",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CotizacionServ",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Cantidad = table.Column<decimal>(nullable: false),
                    Precio = table.Column<decimal>(nullable: false),
                    Observa = table.Column<string>(nullable: true),
                    CotizacionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CotizacionServ", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CotizacionServ_Cotizacion_CotizacionId",
                        column: x => x.CotizacionId,
                        principalTable: "Cotizacion",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ServicioCotizacion",
                columns: table => new
                {
                    ServicioId = table.Column<int>(nullable: false),
                    CotizacionDetalleId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ServicioCotizacion", x => new { x.ServicioId, x.CotizacionDetalleId });
                    table.ForeignKey(
                        name: "FK_ServicioCotizacion_CotizacionServ_CotizacionDetalleId",
                        column: x => x.CotizacionDetalleId,
                        principalTable: "CotizacionServ",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ServicioCotizacion_ServicioTCP_ServicioId",
                        column: x => x.ServicioId,
                        principalTable: "ServicioTCP",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "EstadoCotiz",
                columns: new[] { "Id", "EstadoCotizacion" },
                values: new object[] { 1, "Sin Facturar" });

            migrationBuilder.InsertData(
                table: "EstadoCotiz",
                columns: new[] { "Id", "EstadoCotizacion" },
                values: new object[] { 2, "Facturada" });

            migrationBuilder.InsertData(
                table: "EstadoCotiz",
                columns: new[] { "Id", "EstadoCotizacion" },
                values: new object[] { 3, "Cancelar" });

            migrationBuilder.InsertData(
                table: "Moneda",
                columns: new[] { "Id", "Cambio", "TipoMoneda" },
                values: new object[] { 1, 1m, "CUP" });

            migrationBuilder.InsertData(
                table: "Moneda",
                columns: new[] { "Id", "Cambio", "TipoMoneda" },
                values: new object[] { 2, 130m, "MLC" });

            migrationBuilder.InsertData(
                table: "Tcps",
                columns: new[] { "Id", "Apellidos", "Carnet", "Codigo", "NIT", "Nombre", "NumLicencia" },
                values: new object[] { 1, "Cruz ", "62121", "631", "8100-7612-. Playa", "DEKEKEE", "C364" });

            migrationBuilder.CreateIndex(
                name: "IX_Contrato_EmpresaId",
                table: "Contrato",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_EmpresaId",
                table: "Cotizacion",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cotizacion_EstadoCotizId",
                table: "Cotizacion",
                column: "EstadoCotizId");

            migrationBuilder.CreateIndex(
                name: "IX_CotizacionServ_CotizacionId",
                table: "CotizacionServ",
                column: "CotizacionId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_EmpresaId",
                table: "Cuentas",
                column: "EmpresaId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_MonedId",
                table: "Cuentas",
                column: "MonedId");

            migrationBuilder.CreateIndex(
                name: "IX_Cuentas_TcpId",
                table: "Cuentas",
                column: "TcpId");

            migrationBuilder.CreateIndex(
                name: "IX_ServicioCotizacion_CotizacionDetalleId",
                table: "ServicioCotizacion",
                column: "CotizacionDetalleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contrato");

            migrationBuilder.DropTable(
                name: "Cuentas");

            migrationBuilder.DropTable(
                name: "ServicioCotizacion");

            migrationBuilder.DropTable(
                name: "Moneda");

            migrationBuilder.DropTable(
                name: "Tcps");

            migrationBuilder.DropTable(
                name: "CotizacionServ");

            migrationBuilder.DropTable(
                name: "ServicioTCP");

            migrationBuilder.DropTable(
                name: "Cotizacion");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "EstadoCotiz");
        }
    }
}
