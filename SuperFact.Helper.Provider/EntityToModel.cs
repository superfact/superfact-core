using SuperFact.Entity.Model;
using SuperFact.Model.Contract.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Helper.Provider
{
    public class EntityToModel
    {
        public static EmpresaResponse ToEmpresaResponse(EmpresaModel entity)
        {
            EmpresaResponse representation = new EmpresaResponse();
            representation.Id = entity.Id;
            representation.NroDocumento = entity.NroDocumento;
            representation.TipoDocumento = ToTipoDocumentoContribuyenteResponse(entity.TipoDocumento);
            representation.NombreLegal = entity.NombreLegal;
            representation.NombreComercial = entity.NombreComercial;
            representation.Direccion = entity.Direccion;
            representation.Urbanizacion = entity.Urbanizacion;
            representation.CorreoElectronico = entity.CorreoElectronico;
            representation.Ubigeo = ToUbigeoResponse(entity.Ubigeo);
            return representation;
        }

        public static UbigeoResponse ToUbigeoResponse(UbigeoModel entity)
        {
            UbigeoResponse representation = new UbigeoResponse();
            if (entity != null)
            {
                representation.Id = entity.Id;
                representation.Codigo = entity.Codigo;
                representation.Descripcion = entity.Descripcion;
            }
            return representation;
        }

        public static TipoDocumentoContribuyenteResponse ToTipoDocumentoContribuyenteResponse(TipoDocumentoEmpresaModel entity)
        {
            TipoDocumentoContribuyenteResponse rep = new TipoDocumentoContribuyenteResponse();
            if (entity != null)
            {
                rep.Id = entity.Id;
                rep.Codigo = entity.Codigo;
                rep.Descripcion = entity.Descripcion;
            }
            return rep;
        }
    }
}
