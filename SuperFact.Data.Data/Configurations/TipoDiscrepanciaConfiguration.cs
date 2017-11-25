using SuperFact.Entity.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace SuperFact.Data.Data.Configurations
{
    public class TipoDiscrepanciaConfiguration : BaseConfigurationEntity<TipoDiscrepanciaModel>
    {
        public TipoDiscrepanciaConfiguration()
        {
            //Property(p => p.IdTipoDocumento).HasIndex(Prefix + "IdTipoDoc");

            //HasRequired(p => p.TipoDocumento)
            //    .WithMany()
            //    .HasForeignKey(p => p.IdTipoDocumento)
            //    .WillCascadeOnDelete(false);
        }
    }
}
