using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace SuperFact.Data.Data.Migrations
{
    public partial class InitialMigrate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Anexo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CdrSunat = table.Column<string>(nullable: true),
                    CodigoEstado = table.Column<string>(nullable: true),
                    DescripcionEstado = table.Column<string>(nullable: true),
                    EstadoEnvio = table.Column<short>(nullable: false),
                    FechaGeneracion = table.Column<DateTime>(nullable: false),
                    FechaRespuesta = table.Column<DateTime>(nullable: false),
                    RepresentacionImpresa = table.Column<string>(nullable: true),
                    XmlFirmado = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Anexo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DireccionesSunat",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 50, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DireccionesSunat", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModalidadTransportes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModalidadTransportes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Monedas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monedas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDatoAdicionales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDatoAdicionales", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoAnticipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentoAnticipos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoContribuyentes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentoContribuyentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentoRelacionados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentoRelacionados", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDocumentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoImpuestos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoImpuestos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoOperaciones",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoOperaciones", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "TipoPrecios",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoPrecios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ubigeos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 6, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ubigeos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UnidadMedidas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UnidadMedidas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoAnticipos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdMoneda = table.Column<int>(nullable: false),
                    IdTipoDocumento = table.Column<int>(nullable: false),
                    MontoAnticipo = table.Column<decimal>(nullable: false),
                    NroDocAnticipo = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoAnticipos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentoAnticipos_Monedas_IdMoneda",
                        column: x => x.IdMoneda,
                        principalTable: "Monedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DocumentoAnticipos_TipoDocumentos_IdTipoDocumento",
                        column: x => x.IdTipoDocumento,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TipoDiscrepancias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false),
                    IdTipoDocumento = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TipoDiscrepancias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TipoDiscrepancias_TipoDocumentos_IdTipoDocumento",
                        column: x => x.IdTipoDocumento,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Empresas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CorreoElectronico = table.Column<string>(nullable: true),
                    Direccion = table.Column<string>(nullable: true),
                    IdTipoDocumento = table.Column<int>(nullable: false),
                    IdUbigeo = table.Column<int>(nullable: false),
                    NombreComercial = table.Column<string>(nullable: true),
                    NombreLegal = table.Column<string>(nullable: true),
                    NroDocumento = table.Column<string>(nullable: true),
                    Urbanizacion = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empresas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Empresas_TipoDocumentoContribuyentes_IdTipoDocumento",
                        column: x => x.IdTipoDocumento,
                        principalTable: "TipoDocumentoContribuyentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Empresas_Ubigeos_IdUbigeo",
                        column: x => x.IdUbigeo,
                        principalTable: "Ubigeos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GuiaTransportistas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CodigoAutorizacion = table.Column<string>(nullable: true),
                    IdModoTransporte = table.Column<int>(nullable: false),
                    IdTipoDocTransportista = table.Column<int>(nullable: false),
                    IdUnidadMedida = table.Column<int>(nullable: false),
                    MarcaVehiculo = table.Column<string>(nullable: true),
                    ModalidadTransporteId = table.Column<int>(nullable: true),
                    NombreTransportista = table.Column<string>(nullable: true),
                    NroLicencia = table.Column<string>(nullable: true),
                    PesoBruto = table.Column<decimal>(nullable: false),
                    RucTransportista = table.Column<string>(nullable: true),
                    TipoDocTransportistaId = table.Column<int>(nullable: true),
                    UnidadMedidaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GuiaTransportistas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GuiaTransportistas_ModalidadTransportes_ModalidadTransporteId",
                        column: x => x.ModalidadTransporteId,
                        principalTable: "ModalidadTransportes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GuiaTransportistas_TipoDocumentoContribuyentes_TipoDocTransportistaId",
                        column: x => x.TipoDocTransportistaId,
                        principalTable: "TipoDocumentoContribuyentes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GuiaTransportistas_UnidadMedidas_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadMedidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Parametros",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CertificadoDigital = table.Column<string>(nullable: true),
                    ClaveCertificado = table.Column<string>(nullable: true),
                    ClaveSol = table.Column<string>(nullable: true),
                    ContribuyenteId = table.Column<int>(nullable: true),
                    IdContribuyente = table.Column<int>(nullable: false),
                    TasaDetraccion = table.Column<decimal>(nullable: false),
                    TasaIgv = table.Column<decimal>(nullable: false),
                    TasaIsc = table.Column<decimal>(nullable: false),
                    UsuarioSol = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parametros", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Parametros_Empresas_ContribuyenteId",
                        column: x => x.ContribuyenteId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CabeceraDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    AnexoId = table.Column<int>(nullable: true),
                    DescuentoGlobal = table.Column<decimal>(nullable: false),
                    DocumentoAnticipoId = table.Column<int>(nullable: true),
                    EmisorId = table.Column<int>(nullable: true),
                    EstadoDocumento = table.Column<string>(nullable: true),
                    Exoneradas = table.Column<decimal>(nullable: false),
                    Gratuitas = table.Column<decimal>(nullable: false),
                    Gravadas = table.Column<decimal>(nullable: false),
                    GuiaTransportistaId = table.Column<int>(nullable: true),
                    IdAnexo = table.Column<int>(nullable: true),
                    IdDocumento = table.Column<string>(nullable: true),
                    IdDocumentoAnticipo = table.Column<int>(nullable: true),
                    IdEmisor = table.Column<int>(nullable: false),
                    IdGuiaTransportista = table.Column<int>(nullable: true),
                    IdMoneda = table.Column<int>(nullable: false),
                    IdReceptor = table.Column<int>(nullable: false),
                    IdTipoDocumento = table.Column<int>(nullable: false),
                    IdTipoOperacion = table.Column<int>(nullable: false),
                    Inafectas = table.Column<decimal>(nullable: false),
                    MonedaId = table.Column<int>(nullable: true),
                    MontoDetraccion = table.Column<decimal>(nullable: false),
                    MontoEnLetras = table.Column<string>(nullable: true),
                    MontoPercepcion = table.Column<decimal>(nullable: false),
                    PlacaVehiculo = table.Column<string>(nullable: true),
                    ReceptorId = table.Column<int>(nullable: true),
                    TipoDocumentoId = table.Column<int>(nullable: true),
                    TipoOperacionId = table.Column<int>(nullable: true),
                    TotalIgv = table.Column<decimal>(nullable: false),
                    TotalIsc = table.Column<decimal>(nullable: false),
                    TotalOtrosTributos = table.Column<decimal>(nullable: false),
                    TotalVenta = table.Column<decimal>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CabeceraDocumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_Anexo_AnexoId",
                        column: x => x.AnexoId,
                        principalTable: "Anexo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_DocumentoAnticipos_DocumentoAnticipoId",
                        column: x => x.DocumentoAnticipoId,
                        principalTable: "DocumentoAnticipos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_Empresas_EmisorId",
                        column: x => x.EmisorId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_GuiaTransportistas_GuiaTransportistaId",
                        column: x => x.GuiaTransportistaId,
                        principalTable: "GuiaTransportistas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_Monedas_MonedaId",
                        column: x => x.MonedaId,
                        principalTable: "Monedas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_Empresas_ReceptorId",
                        column: x => x.ReceptorId,
                        principalTable: "Empresas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_TipoDocumentos_TipoDocumentoId",
                        column: x => x.TipoDocumentoId,
                        principalTable: "TipoDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CabeceraDocumentos_TipoOperaciones_TipoOperacionId",
                        column: x => x.TipoOperacionId,
                        principalTable: "TipoOperaciones",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DatosAdicionales",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Contenido = table.Column<string>(maxLength: 250, nullable: false),
                    IdCabeceraDocumento = table.Column<int>(nullable: false),
                    IdTipoDatoAdicional = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosAdicionales", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DatosAdicionales_CabeceraDocumentos_IdCabeceraDocumento",
                        column: x => x.IdCabeceraDocumento,
                        principalTable: "CabeceraDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DatosAdicionales_TipoDatoAdicionales_IdTipoDatoAdicional",
                        column: x => x.IdTipoDatoAdicional,
                        principalTable: "TipoDatoAdicionales",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DetalleDocumentos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CabeceraId = table.Column<int>(nullable: true),
                    Cantidad = table.Column<decimal>(nullable: false),
                    CodigoItem = table.Column<string>(nullable: true),
                    Descripcion = table.Column<string>(nullable: true),
                    Descuento = table.Column<decimal>(nullable: false),
                    IdCabeceraDocumento = table.Column<int>(nullable: false),
                    IdTipoPrecio = table.Column<int>(nullable: false),
                    IdUnidadMedida = table.Column<int>(nullable: false),
                    Impuesto = table.Column<decimal>(nullable: false),
                    ImpuestoSelectivo = table.Column<decimal>(nullable: false),
                    OtroImpuesto = table.Column<decimal>(nullable: false),
                    PrecioUnitario = table.Column<decimal>(nullable: false),
                    TipoPrecioId = table.Column<int>(nullable: true),
                    TotalVenta = table.Column<decimal>(nullable: false),
                    UnidadMedidaId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetalleDocumentos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetalleDocumentos_CabeceraDocumentos_CabeceraId",
                        column: x => x.CabeceraId,
                        principalTable: "CabeceraDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleDocumentos_TipoPrecios_TipoPrecioId",
                        column: x => x.TipoPrecioId,
                        principalTable: "TipoPrecios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetalleDocumentos_UnidadMedidas_UnidadMedidaId",
                        column: x => x.UnidadMedidaId,
                        principalTable: "UnidadMedidas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Discrepancias",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CabeceraDocumentoId = table.Column<int>(nullable: true),
                    Codigo = table.Column<string>(maxLength: 5, nullable: false),
                    Descripcion = table.Column<string>(maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discrepancias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Discrepancias_CabeceraDocumentos_CabeceraDocumentoId",
                        column: x => x.CabeceraDocumentoId,
                        principalTable: "CabeceraDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DocumentoRelacionados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    IdCabeceraDocumento = table.Column<int>(nullable: false),
                    NroDocumento = table.Column<string>(maxLength: 15, nullable: false),
                    TipoDocumento = table.Column<string>(maxLength: 2, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentoRelacionados", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DocumentoRelacionados_CabeceraDocumentos_IdCabeceraDocumento",
                        column: x => x.IdCabeceraDocumento,
                        principalTable: "CabeceraDocumentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_AnexoId",
                table: "CabeceraDocumentos",
                column: "AnexoId");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_DocumentoAnticipoId",
                table: "CabeceraDocumentos",
                column: "DocumentoAnticipoId");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_EmisorId",
                table: "CabeceraDocumentos",
                column: "EmisorId");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_GuiaTransportistaId",
                table: "CabeceraDocumentos",
                column: "GuiaTransportistaId");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_MonedaId",
                table: "CabeceraDocumentos",
                column: "MonedaId");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_ReceptorId",
                table: "CabeceraDocumentos",
                column: "ReceptorId");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_TipoDocumentoId",
                table: "CabeceraDocumentos",
                column: "TipoDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_CabeceraDocumentos_TipoOperacionId",
                table: "CabeceraDocumentos",
                column: "TipoOperacionId");

            migrationBuilder.CreateIndex(
                name: "IX_DatosAdicionales_IdCabeceraDocumento",
                table: "DatosAdicionales",
                column: "IdCabeceraDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_DatosAdicionales_IdTipoDatoAdicional",
                table: "DatosAdicionales",
                column: "IdTipoDatoAdicional");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDocumentos_CabeceraId",
                table: "DetalleDocumentos",
                column: "CabeceraId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDocumentos_TipoPrecioId",
                table: "DetalleDocumentos",
                column: "TipoPrecioId");

            migrationBuilder.CreateIndex(
                name: "IX_DetalleDocumentos_UnidadMedidaId",
                table: "DetalleDocumentos",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Discrepancias_CabeceraDocumentoId",
                table: "Discrepancias",
                column: "CabeceraDocumentoId");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoAnticipos_IdMoneda",
                table: "DocumentoAnticipos",
                column: "IdMoneda");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoAnticipos_IdTipoDocumento",
                table: "DocumentoAnticipos",
                column: "IdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_DocumentoRelacionados_IdCabeceraDocumento",
                table: "DocumentoRelacionados",
                column: "IdCabeceraDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_IdTipoDocumento",
                table: "Empresas",
                column: "IdTipoDocumento");

            migrationBuilder.CreateIndex(
                name: "IX_Empresas_IdUbigeo",
                table: "Empresas",
                column: "IdUbigeo");

            migrationBuilder.CreateIndex(
                name: "IX_GuiaTransportistas_ModalidadTransporteId",
                table: "GuiaTransportistas",
                column: "ModalidadTransporteId");

            migrationBuilder.CreateIndex(
                name: "IX_GuiaTransportistas_TipoDocTransportistaId",
                table: "GuiaTransportistas",
                column: "TipoDocTransportistaId");

            migrationBuilder.CreateIndex(
                name: "IX_GuiaTransportistas_UnidadMedidaId",
                table: "GuiaTransportistas",
                column: "UnidadMedidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Parametros_ContribuyenteId",
                table: "Parametros",
                column: "ContribuyenteId");

            migrationBuilder.CreateIndex(
                name: "IX_TipoDiscrepancias_IdTipoDocumento",
                table: "TipoDiscrepancias",
                column: "IdTipoDocumento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosAdicionales");

            migrationBuilder.DropTable(
                name: "DetalleDocumentos");

            migrationBuilder.DropTable(
                name: "DireccionesSunat");

            migrationBuilder.DropTable(
                name: "Discrepancias");

            migrationBuilder.DropTable(
                name: "DocumentoRelacionados");

            migrationBuilder.DropTable(
                name: "Parametros");

            migrationBuilder.DropTable(
                name: "TipoDiscrepancias");

            migrationBuilder.DropTable(
                name: "TipoDocumentoAnticipos");

            migrationBuilder.DropTable(
                name: "TipoDocumentoRelacionados");

            migrationBuilder.DropTable(
                name: "TipoImpuestos");

            migrationBuilder.DropTable(
                name: "TipoDatoAdicionales");

            migrationBuilder.DropTable(
                name: "TipoPrecios");

            migrationBuilder.DropTable(
                name: "CabeceraDocumentos");

            migrationBuilder.DropTable(
                name: "Anexo");

            migrationBuilder.DropTable(
                name: "DocumentoAnticipos");

            migrationBuilder.DropTable(
                name: "Empresas");

            migrationBuilder.DropTable(
                name: "GuiaTransportistas");

            migrationBuilder.DropTable(
                name: "TipoOperaciones");

            migrationBuilder.DropTable(
                name: "Monedas");

            migrationBuilder.DropTable(
                name: "TipoDocumentos");

            migrationBuilder.DropTable(
                name: "Ubigeos");

            migrationBuilder.DropTable(
                name: "ModalidadTransportes");

            migrationBuilder.DropTable(
                name: "TipoDocumentoContribuyentes");

            migrationBuilder.DropTable(
                name: "UnidadMedidas");
        }
    }
}
