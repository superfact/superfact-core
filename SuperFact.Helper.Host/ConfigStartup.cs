using SuperFact.Business.IService;
using SuperFact.Business.Service;
using SuperFact.Data.Data;
using SuperFact.Data.IRepository;
using SuperFact.Data.Repository;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using SuperFact.Ubl.Signed;
using SuperFact.Ubl.Xml;
using System;
using SuperFact.Helper.Sunat;
using SuperFact.Helper.Sunat.Soa;

namespace SuperFact.Helper.Host
{
    public class ConfigStartup
    {
        public static void ConfigDb(IServiceCollection services, string connection)
        {
            services.AddDbContext<SuperFactDbContext>(options =>
               options.UseSqlite(connection)
           );
        }
        public static void DependecyInjection(IServiceCollection services)
        {
            // Add Database Initializer
            services.AddScoped<ISuperFactDbInitializer, SuperFactDbInitializer>();

            // Add document operations-signed
            services.AddScoped<ISerializador, Serializador>();
            services.AddScoped<ICertificador, Certificador>();

            // Add end point sunat
            services.AddScoped<IServicioSunatDocumentos, ServicioSunatDocumentos>();
            services.AddScoped<IServicioSunatConsultas, ServicioSunatConsultas>();

            // Add document manipulated
            services.AddScoped<IDocumentoXml, FacturaXml>();
            services.AddScoped<IDocumentoXml, NotaCreditoXml>();
            services.AddScoped<IDocumentoXml, NotaDebitoXml>();
            services.AddScoped<IDocumentoXml, ResumenDiarioXml>();
            services.AddScoped<IDocumentoXml, ResumenDiarioNuevoXml>();
            services.AddScoped<IDocumentoXml, ComunicacionBajaXml>();
            services.AddScoped<IDocumentoXml, RetencionXml>();
            services.AddScoped<IDocumentoXml, PercepcionXml>();
            services.AddScoped<IDocumentoXml, GuiaRemisionXml>();


            // Add application services.
            services.AddScoped<ICertificadoDigitalProvider, CertificadoDigitalProvider>();
            services.AddScoped<IComunicacionBajaProvider, ComunicacionBajaProvider>();
            services.AddScoped<IDireccionSunatProvider, DireccionSunatProvider>();
            services.AddScoped<IEmpresaProvider, EmpresaProvider>();       
            services.AddScoped<IFacturaProvider, FacturaProvider>();
            services.AddScoped<IGuiaRemisionProvider, GuiaRemisionProvider>();
            services.AddScoped<INotaCreditoProvider, NotaCreditoProvider>();
            services.AddScoped<INotaDebitoProvider, NotaDebitoProvider>();
            services.AddScoped<IPercepcionProvider, PercepcionProvider>();
            services.AddScoped<IResumenDiarioProvider, ResumenDiarioProvider>();
            services.AddScoped<IRetencionProvider, RetencionProvider>();


            // Add application Repositories.
            services.AddScoped<ICertificadoDigitalRepository, CertificadoDigitalRepository>();
            services.AddScoped<IDireccionSunatRepository, DireccionSunatRepository>();
            services.AddScoped<IEmpresaRepository, EmpresaRepository>();
            services.AddScoped<IModalidadTransporteRepository, ModalidadTransporteRepository>();
            services.AddScoped<IMonedaRepository, MonedaRepository>();
            services.AddScoped<IParametroEmpresaRepository, ParametroEmpresaRepository>();
            services.AddScoped<IProvinciaRepository, ProvinciaRepository>();
            services.AddScoped<ITipoDatoAdicionalRepository, TipoDatoAdicionalRepository>();
            services.AddScoped<ITipoDiscrepanciaRepository, TipoDiscrepanciaRepository>();
            services.AddScoped<ITipoDocumentoAnticipoRepository, TipoDocumentoAnticipoRepository>();
            services.AddScoped<ITipoDocumentoContribuyenteRepository, TipoDocumentoContribuyenteRepository>();
            services.AddScoped<ITipoDocumentoRelacionadoRepository, TipoDocumentoRelacionadoRepository>();
            services.AddScoped<ITipoDocumentoRepository, TipoDocumentoRepository>();
            services.AddScoped<ITipoImpuestoRepository, TipoImpuestoRepository>();
            services.AddScoped<ITipoOperacionRepository, TipoOperacionRepository>();
            services.AddScoped<ITipoPrecioRepository, TipoPrecioRepository>();
            services.AddScoped<IUbigeoRepository, UbigeoRepository>();

        }

    }
}
