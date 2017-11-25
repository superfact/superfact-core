using SuperFact.Entity.Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SuperFact.Data.Data
{
    public class SuperFactDbInitializer : ISuperFactDbInitializer
    {
        private readonly SuperFactDbContext _context;
        public SuperFactDbInitializer(SuperFactDbContext _context)
        {
            this._context = _context;
        }

        public async Task InitializeAsync()
        {
            var separador = '|';
            var carpeta = @".\Data\";

            //create database schema if none exists
            _context.Database.EnsureCreated();

            //If there is already an Tipo Documento, abort
            if (_context.TipoDocumentos.Any()) return;

            DireccionSunatModel[] direccionesSunat = File.ReadAllLines($"{carpeta}DireccionesSunat.txt").Select(linea => linea.Split(separador))
                .Select(valores => new DireccionSunatModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (DireccionSunatModel dir in direccionesSunat) { await _context.DireccionesSunat.AddAsync(dir); }
            //_context.SaveChanges();
            MonedaModel[] monedas = File.ReadAllLines($"{carpeta}Monedas.txt").Select(linea => linea.Split(separador))
                .Select(valores => new MonedaModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (MonedaModel mon in monedas) { await _context.Monedas.AddAsync(mon); }


            ModalidadTransporteModel[] modalidadTransportes = File.ReadAllLines($"{carpeta}ModalidadTransportes.txt").Select(linea => linea.Split(separador))
                .Select(valores => new ModalidadTransporteModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (ModalidadTransporteModel mod in modalidadTransportes) { await _context.ModalidadTransportes.AddAsync(mod); }

            TipoDatoAdicionalModel[] tipoDatoAdicionales = File.ReadAllLines($"{carpeta}TipoDatoAdicionales.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoDatoAdicionalModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoDatoAdicionalModel dato in tipoDatoAdicionales) { await _context.TipoDatoAdicionales.AddAsync(dato); }

            TipoDocumentoModel[] tipoDocumentos = File.ReadAllLines($"{carpeta}TipoDocumentos.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoDocumentoModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoDocumentoModel doc in tipoDocumentos) { await _context.TipoDocumentos.AddAsync(doc); }

            TipoDocumentoAnticipoModel[] tipoDocumentoAnticipos = File.ReadAllLines($"{carpeta}TipoDocumentoAnticipos.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoDocumentoAnticipoModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoDocumentoAnticipoModel anticipo in tipoDocumentoAnticipos) { await _context.TipoDocumentoAnticipos.AddAsync(anticipo); }

            TipoDocumentoEmpresaModel[] tipoDocumentoContribuyentes = File.ReadAllLines($"{carpeta}TipoDocumentoContribuyentes.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoDocumentoEmpresaModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoDocumentoEmpresaModel contri in tipoDocumentoContribuyentes) { await _context.TipoDocumentoContribuyentes.AddAsync(contri); }

            TipoDocumentoRelacionadoModel[] tipoDocumentoRelacionados = File.ReadAllLines($"{carpeta}TipoDocumentoRelacionados.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoDocumentoRelacionadoModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoDocumentoRelacionadoModel relacion in tipoDocumentoRelacionados) { await _context.TipoDocumentoRelacionados.AddAsync(relacion); }


            TipoImpuestoModel[] tipoImpuestos = File.ReadAllLines($"{carpeta}TipoImpuestos.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoImpuestoModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoImpuestoModel impuesto in tipoImpuestos) { await _context.TipoImpuestos.AddAsync(impuesto); }

            TipoOperacionModel[] tipoOperaciones = File.ReadAllLines($"{carpeta}TipoOperaciones.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoOperacionModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoOperacionModel operacion in tipoOperaciones) { await _context.TipoOperaciones.AddAsync(operacion); }

            TipoPrecioModel[] tipoPrecios = File.ReadAllLines($"{carpeta}TipoPrecios.txt").Select(linea => linea.Split(separador))
                .Select(valores => new TipoPrecioModel
                {
                    Codigo = valores.First(),
                    Descripcion = valores.Last()
                }).ToArray();
            foreach (TipoPrecioModel precio in tipoPrecios) { await _context.TipoPrecios.AddAsync(precio); }
            _context.SaveChanges();

            UbigeoModel[] ubigeos = File.ReadAllLines($"{carpeta}Ubigeo.txt").Select(linea => linea)
                .Select(valores => new UbigeoModel
                {
                    Codigo = valores.Substring(0, 6),
                    Descripcion = valores.Substring(7).Trim()
                }).ToArray();
            foreach (UbigeoModel ubigeo in ubigeos) { await _context.Ubigeos.AddAsync(ubigeo); }
            _context.SaveChanges();

            var tipoDiscrepancias = File.ReadAllLines($"{carpeta}TipoDiscrepancias.txt");
            foreach (var discrepancia in tipoDiscrepancias.Select(linea => linea.Split(separador)))
            {
                var codigo = discrepancia.Last().Trim();
                var tipoDoc = _context.TipoDocumentos.SingleOrDefault(c => c.Codigo == codigo);
                if (tipoDoc != null)
                {
                    await _context.TipoDiscrepancias.AddAsync(new TipoDiscrepanciaModel
                    {
                        Codigo = discrepancia.First(),
                        Descripcion = discrepancia[1],
                        IdTipoDocumento = tipoDoc.Id
                    });
                }
            }
            _context.SaveChanges();
        }


    }
}
