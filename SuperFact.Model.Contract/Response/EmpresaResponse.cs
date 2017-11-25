using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Model.Contract.Response
{
    public class EmpresaResponse
    {
        public int Id { get; set; }

        public string NroDocumento { get; set; }
       
        public TipoDocumentoContribuyenteResponse TipoDocumento { get; set; }

        public string NombreLegal { get; set; }

        public string NombreComercial { get; set; }

        public string Direccion { get; set; }

        public string Urbanizacion { get; set; }

        public string CorreoElectronico { get; set; }       
                
        public UbigeoResponse Ubigeo { get; set; }
    }
}
