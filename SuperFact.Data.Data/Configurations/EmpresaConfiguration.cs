﻿using SuperFact.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Data.Data.Configurations
{
    public class EmpresaConfiguration : BaseConfigurationEntity<EmpresaModel>
    {
        public EmpresaConfiguration()
        {
            //Property(p => p.IdUbigeo).HasIndex(Prefix + "IdUbigeo");

            //HasRequired(p => p.Ubigeo)
            //    .WithMany()
            //    .HasForeignKey(p => p.IdUbigeo)
            //    .WillCascadeOnDelete(false);

            //HasRequired(p => p.TipoDocumento)
            //    .WithMany()
            //    .HasForeignKey(p => p.IdTipoDocumento)
            //    .WillCascadeOnDelete(false);

            //Property(p => p.NroDocumento)
            //    .HasMaxLength(11)
            //    .IsRequired();

            //Property(p => p.NombreLegal)
            //    .HasMaxLength(200)
            //    .IsRequired();

            //Property(p => p.NombreComercial)
            //    .HasMaxLength(200)
            //    .IsRequired();

            //Property(p => p.Direccion)
            //    .HasMaxLength(500)
            //    .IsRequired();

            //Property(p => p.CorreoElectronico)
            //    .HasMaxLength(500);

            //Property(p => p.Urbanizacion)
            //    .HasMaxLength(50)
            //    .IsRequired();
        }
    }
}
