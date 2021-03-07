using Ongoren.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongoren.Models
{
    public class MailModel
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public string MailTo { get; set; }
    }
}
