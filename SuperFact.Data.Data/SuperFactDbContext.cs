using Microsoft.EntityFrameworkCore;
using SuperFact.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Data.Data
{
    public class SuperFactDbContext : DbContext
    {
        public SuperFactDbContext(DbContextOptions<SuperFactDbContext> options) :base(options)
        {         
            Database.MigrateAsync();
        }      
        protected override void OnModelCreating(ModelBuilder builder)
        {            
            base.OnModelCreating(builder);           
        }
        public virtual void SetEntityState(IEntity entity)
        {
            SetEntityState(entity, entity.Id == 0 ? EntityState.Added : EntityState.Modified);
        }

        public virtual void SetEntityState(object entity, EntityState newState)
        {
            Entry(entity).State = newState;
        }
        public virtual DbSet<EmpresaModel> Empresas { get; set; }
        public virtual DbSet<DireccionSunatModel> DireccionesSunat { get; set; }
        public virtual DbSet<TipoDocumentoEmpresaModel> TipoDocumentoContribuyentes { get; set; }
        public virtual DbSet<CertificadoDigitalModel> CertificadoDigitales { get; set; }


        public virtual DbSet<TipoDocumentoModel> TipoDocumentos { get; set; }       
        public virtual DbSet<TipoOperacionModel> TipoOperaciones { get; set; }
        public virtual DbSet<TipoImpuestoModel> TipoImpuestos { get; set; }
        public virtual DbSet<TipoPrecioModel> TipoPrecios { get; set; }
        public virtual DbSet<TipoDocumentoRelacionadoModel> TipoDocumentoRelacionados { get; set; }
        public virtual DbSet<TipoDocumentoAnticipoModel> TipoDocumentoAnticipos { get; set; }
        public virtual DbSet<TipoDiscrepanciaModel> TipoDiscrepancias { get; set; }
        public virtual DbSet<TipoDatoAdicionalModel> TipoDatoAdicionales { get; set; }
        public virtual DbSet<MonedaModel> Monedas { get; set; }
        public virtual DbSet<ModalidadTransporteModel> ModalidadTransportes { get; set; } 
        public virtual DbSet<DatoAdicionalModel> DatosAdicionales { get; set; }
        public virtual DbSet<CabeceraDocumentoModel> CabeceraDocumentos { get; set; }
        public virtual DbSet<DocumentoDetalleModel> DetalleDocumentos { get; set; }
        public virtual DbSet<DiscrepanciaDocumentoModel> Discrepancias { get; set; }
        public virtual DbSet<DocumentoAnticipoModel> DocumentoAnticipos { get; set; }
        public virtual DbSet<DocumentoRelacionadoModel> DocumentoRelacionados { get; set; }
        public virtual DbSet<GuiaTransportistaModel> GuiaTransportistas { get; set; }
        public virtual DbSet<UbigeoModel> Ubigeos { get; set; }
        public virtual DbSet<UnidadMedidaModel> UnidadMedidas { get; set; }
        public virtual DbSet<ParametroEmpresaModel> Parametros { get; set; }
    }
}
