using FoxApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FoxApp.Repositories
{
    public class FoxRepository
    {
        FoxContext foxContext;

        public FoxRepository(FoxContext foxContext)
        {
            this.foxContext = foxContext;
        }
    }
}
