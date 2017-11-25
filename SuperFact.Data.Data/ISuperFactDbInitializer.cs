using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SuperFact.Data.Data
{
    public interface ISuperFactDbInitializer
    {
        Task InitializeAsync();
    }
}
