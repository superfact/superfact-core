using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Helper.Sunat
{
    public interface IServicioSunatConsultas : IServicioSunat
    {
        RespuestaSincrono ConsultarConstanciaDeRecepcion(DatosDocumento request);
    }
}
