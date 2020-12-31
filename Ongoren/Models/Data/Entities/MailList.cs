using Ongoren.Core.Entity;
using Ongoren.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongoren.Models.Data.Entities
{
    public class MailList : CoreEntity
    {
        public MailStatus MailStatus { get; set; }
        public string MailTo { get; set; }
    }
}
