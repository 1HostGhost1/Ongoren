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
        public string Name { get; set; }
    }
}
