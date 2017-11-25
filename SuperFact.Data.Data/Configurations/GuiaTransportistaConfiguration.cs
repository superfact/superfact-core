using SuperFact.Entity.Model;
using System;

using System.Collections.Generic;
using System.Text;

namespace SuperFact.Data.Data.Configurations
{
    public class GuiaTransportistaConfiguration : BaseConfigurationEntity<GuiaTransportistaModel>
    {
        public GuiaTransportistaConfiguration()
        {
            //Property(e => e.IdModoTransporte).HasIndex(Prefix + "IdModoTransporte");

            //Property(e => e.IdUnidadMedida).HasIndex(Prefix + "IdUnidadMedida");

            //Property(e => e.IdTipoDocTransportista).HasIndex(Prefix + "IdTipoDocTransportista");

            //HasRequired(e => e.ModalidadTransporte)
            //   .WithMany()
            //   .HasForeignKey(e => e.IdModoTransporte)
            //   .WillCascadeOnDelete(false);

            //HasRequired(e => e.UnidadMedida)
            //    .WithMany()
            //    .HasForeignKey(e => e.IdUnidadMedida)
            //    .WillCascadeOnDelete(false);

            //HasRequired(e => e.TipoDocTransportista)
            //    .WithMany()
            //    .HasForeignKey(e => e.IdTipoDocTransportista)
            //    .WillCascadeOnDelete(false);

            //Property(e => e.CodigoAutorizacion)
            //    .IsRequired()
            //    .HasMaxLength(10);

            //Property(e => e.MarcaVehiculo)
            //    .IsRequired()
            //    .HasMaxLength(50);

            //Property(e => e.NombreTransportista)
            //    .IsRequired()
            //    .HasMaxLength(100);

            //Property(e => e.NroLicencia)
            //    .IsRequired()
            //    .HasMaxLength(10);

            //Property(e => e.RucTransportista)
            //    .IsRequired()
            //    .HasMaxLength(11);

            //Property(e => e.PesoBruto)
            //    .HasPrecision(11, 2);
        }
    }
}
