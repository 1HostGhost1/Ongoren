using Ongoren.Models.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongoren.Models.Data.Context
{
    class DataContext : DbContext
    {
        public DataContext() : base("name=Conn")
        {

        }

        public DbSet<Person> People { get; set; }
        public DbSet<MailList> MailLists { get; set; }
    }
}
