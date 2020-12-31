using Ongoren.Core.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongoren.Models.Data.Entities
{
    [Table("Companies")]
    public class Company : CoreEntity
    {
        //public Company()
        //{
        //    People = new HashSet<Person>();
        //}
        public string Name { get; set; }
        //public ICollection<Person> People { get; set; }
    }
}
