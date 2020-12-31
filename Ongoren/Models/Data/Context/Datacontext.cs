using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongoren.Models.Data.Context
{
    class Datacontext : DbContext
    {
        public Datacontext() : base("name=Conn")
        {

        }
    }
}
