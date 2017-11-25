using SuperFact.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Data.Data.Configurations
{
    public class ParametroConfiguration : BaseConfigurationEntity<ParametroEmpresaModel>
    {
        public ParametroConfiguration()
        {
            //Property(p => p.IdContribuyente).HasIndex(Prefix + "IdContribuyente");

            //HasRequired(p => p.Contribuyente)
            //    .WithMany()
            //    .HasForeignKey(p => p.IdContribuyente)
            //    .WillCascadeOnDelete(false);

            //Property(p => p.TasaDetraccion)
            //    .HasPrecision(11, 2)
            //    .IsRequired();

            //Property(p => p.TasaIgv)
            //    .HasPrecision(11, 2)
            //    .IsRequired();

            //Property(p => p.TasaIsc)
            //    .HasPrecision(11, 2)
            //    .IsRequired();

            //Property(p => p.CertificadoDigital)
            //    .IsRequired();

            //Property(p => p.ClaveCertificado)
            //    .IsRequired();

            //Property(p => p.UsuarioSol)
            //    .HasMaxLength(10)
            //    .IsRequired();

            //Property(p => p.ClaveSol)
            //    .HasMaxLength(10)
            //    .IsRequired();

        }
    }
}
