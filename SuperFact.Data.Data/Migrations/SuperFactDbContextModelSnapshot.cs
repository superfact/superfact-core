﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using SuperFact.Data.Data;
using System;

namespace SuperFact.Data.Data.Migrations
{
    [DbContext(typeof(SuperFactDbContext))]
    partial class SuperFactDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125");

            modelBuilder.Entity("SuperFact.Entity.Model.Anexo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CdrSunat");

                    b.Property<string>("CodigoEstado");

                    b.Property<string>("DescripcionEstado");

                    b.Property<short>("EstadoEnvio");

                    b.Property<DateTime>("FechaGeneracion");

                    b.Property<DateTime>("FechaRespuesta");

                    b.Property<string>("RepresentacionImpresa");

                    b.Property<string>("XmlFirmado");

                    b.HasKey("Id");

                    b.ToTable("Anexo");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.CabeceraDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AnexoId");

                    b.Property<decimal>("DescuentoGlobal");

                    b.Property<int?>("DocumentoAnticipoId");

                    b.Property<int?>("EmisorId");

                    b.Property<string>("EstadoDocumento");

                    b.Property<decimal>("Exoneradas");

                    b.Property<decimal>("Gratuitas");

                    b.Property<decimal>("Gravadas");

                    b.Property<int?>("GuiaTransportistaId");

                    b.Property<int?>("IdAnexo");

                    b.Property<string>("IdDocumento");

                    b.Property<int?>("IdDocumentoAnticipo");

                    b.Property<int>("IdEmisor");

                    b.Property<int?>("IdGuiaTransportista");

                    b.Property<int>("IdMoneda");

                    b.Property<int>("IdReceptor");

                    b.Property<int>("IdTipoDocumento");

                    b.Property<int>("IdTipoOperacion");

                    b.Property<decimal>("Inafectas");

                    b.Property<int?>("MonedaId");

                    b.Property<decimal>("MontoDetraccion");

                    b.Property<string>("MontoEnLetras");

                    b.Property<decimal>("MontoPercepcion");

                    b.Property<string>("PlacaVehiculo");

                    b.Property<int?>("ReceptorId");

                    b.Property<int?>("TipoDocumentoId");

                    b.Property<int?>("TipoOperacionId");

                    b.Property<decimal>("TotalIgv");

                    b.Property<decimal>("TotalIsc");

                    b.Property<decimal>("TotalOtrosTributos");

                    b.Property<decimal>("TotalVenta");

                    b.HasKey("Id");

                    b.HasIndex("AnexoId");

                    b.HasIndex("DocumentoAnticipoId");

                    b.HasIndex("EmisorId");

                    b.HasIndex("GuiaTransportistaId");

                    b.HasIndex("MonedaId");

                    b.HasIndex("ReceptorId");

                    b.HasIndex("TipoDocumentoId");

                    b.HasIndex("TipoOperacionId");

                    b.ToTable("CabeceraDocumentos");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DatoAdicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Contenido")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("IdCabeceraDocumento");

                    b.Property<int>("IdTipoDatoAdicional");

                    b.HasKey("Id");

                    b.HasIndex("IdCabeceraDocumento");

                    b.HasIndex("IdTipoDatoAdicional");

                    b.ToTable("DatosAdicionales");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DireccionSunat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("DireccionesSunat");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DiscrepanciaDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CabeceraDocumentoId");

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.HasIndex("CabeceraDocumentoId");

                    b.ToTable("Discrepancias");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DocumentoAnticipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdMoneda");

                    b.Property<int>("IdTipoDocumento");

                    b.Property<decimal>("MontoAnticipo");

                    b.Property<string>("NroDocAnticipo")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("IdMoneda");

                    b.HasIndex("IdTipoDocumento");

                    b.ToTable("DocumentoAnticipos");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DocumentoDetalle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CabeceraId");

                    b.Property<decimal>("Cantidad");

                    b.Property<string>("CodigoItem");

                    b.Property<string>("Descripcion");

                    b.Property<decimal>("Descuento");

                    b.Property<int>("IdCabeceraDocumento");

                    b.Property<int>("IdTipoPrecio");

                    b.Property<int>("IdUnidadMedida");

                    b.Property<decimal>("Impuesto");

                    b.Property<decimal>("ImpuestoSelectivo");

                    b.Property<decimal>("OtroImpuesto");

                    b.Property<decimal>("PrecioUnitario");

                    b.Property<int?>("TipoPrecioId");

                    b.Property<decimal>("TotalVenta");

                    b.Property<int?>("UnidadMedidaId");

                    b.HasKey("Id");

                    b.HasIndex("CabeceraId");

                    b.HasIndex("TipoPrecioId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("DetalleDocumentos");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DocumentoRelacionado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("IdCabeceraDocumento");

                    b.Property<string>("NroDocumento")
                        .IsRequired()
                        .HasMaxLength(15);

                    b.Property<string>("TipoDocumento")
                        .IsRequired()
                        .HasMaxLength(2);

                    b.HasKey("Id");

                    b.HasIndex("IdCabeceraDocumento");

                    b.ToTable("DocumentoRelacionados");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.Empresa", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AliasEmpresa");

                    b.Property<string>("CorreoElectronico");

                    b.Property<string>("Direccion");

                    b.Property<int>("IdTipoDocumento");

                    b.Property<int>("IdUbigeo");

                    b.Property<string>("NombreComercial");

                    b.Property<string>("NombreLegal");

                    b.Property<string>("NroDocumento");

                    b.Property<string>("Urbanizacion");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoDocumento");

                    b.HasIndex("IdUbigeo");

                    b.ToTable("Empresas");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.GuiaTransportista", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CodigoAutorizacion");

                    b.Property<int>("IdModoTransporte");

                    b.Property<int>("IdTipoDocTransportista");

                    b.Property<int>("IdUnidadMedida");

                    b.Property<string>("MarcaVehiculo");

                    b.Property<int?>("ModalidadTransporteId");

                    b.Property<string>("NombreTransportista");

                    b.Property<string>("NroLicencia");

                    b.Property<decimal>("PesoBruto");

                    b.Property<string>("RucTransportista");

                    b.Property<int?>("TipoDocTransportistaId");

                    b.Property<int?>("UnidadMedidaId");

                    b.HasKey("Id");

                    b.HasIndex("ModalidadTransporteId");

                    b.HasIndex("TipoDocTransportistaId");

                    b.HasIndex("UnidadMedidaId");

                    b.ToTable("GuiaTransportistas");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.ModalidadTransporte", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("ModalidadTransportes");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.Moneda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Monedas");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.ParametroConfiguracion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CertificadoDigital");

                    b.Property<string>("ClaveCertificado");

                    b.Property<string>("ClaveSol");

                    b.Property<int?>("ContribuyenteId");

                    b.Property<int>("IdContribuyente");

                    b.Property<decimal>("TasaDetraccion");

                    b.Property<decimal>("TasaIgv");

                    b.Property<decimal>("TasaIsc");

                    b.Property<string>("UsuarioSol");

                    b.HasKey("Id");

                    b.HasIndex("ContribuyenteId");

                    b.ToTable("Parametros");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoDatoAdicional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoDatoAdicionales");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoDiscrepancia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("IdTipoDocumento");

                    b.HasKey("Id");

                    b.HasIndex("IdTipoDocumento");

                    b.ToTable("TipoDiscrepancias");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoDocumento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentos");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoDocumentoAnticipo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentoAnticipos");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoDocumentoContribuyente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentoContribuyentes");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoDocumentoRelacionado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoDocumentoRelacionados");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoImpuesto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoImpuestos");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoOperacion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoOperaciones");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoPrecio", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("TipoPrecios");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.Ubigeo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(6);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("Ubigeos");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.UnidadMedida", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Codigo")
                        .IsRequired()
                        .HasMaxLength(5);

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.HasKey("Id");

                    b.ToTable("UnidadMedidas");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.CabeceraDocumento", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.Anexo", "Anexo")
                        .WithMany()
                        .HasForeignKey("AnexoId");

                    b.HasOne("SuperFact.Entity.Model.DocumentoAnticipo", "DocumentoAnticipo")
                        .WithMany()
                        .HasForeignKey("DocumentoAnticipoId");

                    b.HasOne("SuperFact.Entity.Model.Empresa", "Emisor")
                        .WithMany()
                        .HasForeignKey("EmisorId");

                    b.HasOne("SuperFact.Entity.Model.GuiaTransportista", "GuiaTransportista")
                        .WithMany()
                        .HasForeignKey("GuiaTransportistaId");

                    b.HasOne("SuperFact.Entity.Model.Moneda", "Moneda")
                        .WithMany()
                        .HasForeignKey("MonedaId");

                    b.HasOne("SuperFact.Entity.Model.Empresa", "Receptor")
                        .WithMany()
                        .HasForeignKey("ReceptorId");

                    b.HasOne("SuperFact.Entity.Model.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("TipoDocumentoId");

                    b.HasOne("SuperFact.Entity.Model.TipoOperacion", "TipoOperacion")
                        .WithMany()
                        .HasForeignKey("TipoOperacionId");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DatoAdicional", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.CabeceraDocumento", "CabeceraDocumento")
                        .WithMany("DatoAdicionales")
                        .HasForeignKey("IdCabeceraDocumento")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperFact.Entity.Model.TipoDatoAdicional", "TipoDatoAdicional")
                        .WithMany()
                        .HasForeignKey("IdTipoDatoAdicional")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DiscrepanciaDocumento", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.CabeceraDocumento")
                        .WithMany("Discrepancias")
                        .HasForeignKey("CabeceraDocumentoId");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DocumentoAnticipo", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.Moneda", "Moneda")
                        .WithMany()
                        .HasForeignKey("IdMoneda")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperFact.Entity.Model.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DocumentoDetalle", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.CabeceraDocumento", "Cabecera")
                        .WithMany("Detalles")
                        .HasForeignKey("CabeceraId");

                    b.HasOne("SuperFact.Entity.Model.TipoPrecio", "TipoPrecio")
                        .WithMany()
                        .HasForeignKey("TipoPrecioId");

                    b.HasOne("SuperFact.Entity.Model.UnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.DocumentoRelacionado", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.CabeceraDocumento", "CabeceraDocumento")
                        .WithMany("DocumentoRelacionados")
                        .HasForeignKey("IdCabeceraDocumento")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperFact.Entity.Model.Empresa", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.TipoDocumentoContribuyente", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("SuperFact.Entity.Model.Ubigeo", "Ubigeo")
                        .WithMany()
                        .HasForeignKey("IdUbigeo")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("SuperFact.Entity.Model.GuiaTransportista", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.ModalidadTransporte", "ModalidadTransporte")
                        .WithMany()
                        .HasForeignKey("ModalidadTransporteId");

                    b.HasOne("SuperFact.Entity.Model.TipoDocumentoContribuyente", "TipoDocTransportista")
                        .WithMany()
                        .HasForeignKey("TipoDocTransportistaId");

                    b.HasOne("SuperFact.Entity.Model.UnidadMedida", "UnidadMedida")
                        .WithMany()
                        .HasForeignKey("UnidadMedidaId");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.ParametroConfiguracion", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.Empresa", "Contribuyente")
                        .WithMany()
                        .HasForeignKey("ContribuyenteId");
                });

            modelBuilder.Entity("SuperFact.Entity.Model.TipoDiscrepancia", b =>
                {
                    b.HasOne("SuperFact.Entity.Model.TipoDocumento", "TipoDocumento")
                        .WithMany()
                        .HasForeignKey("IdTipoDocumento")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
