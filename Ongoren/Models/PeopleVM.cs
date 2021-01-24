using Ongoren.Core.Entity.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ongoren.Models
{
    public class PeopleVM
    {
        public int Id { get; set; }
        public Status Status { get; set; }
        public string WpOrRp { get; set; }
        public string AppNo { get; set; }
        public string YKN { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string CompanyName { get; set; }
        public DateTime AppDate { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public DateTime ImmTrackEndDate { get; set; }
        public string ImmigrationFree { get; set; }
    }
}
