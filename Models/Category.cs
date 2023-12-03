using Survey.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class Category : AuditLog
    {
        public long Id { get; set; }
        public string CategoryText { get; set; }
        public List<Questions> Questions { get; set; }
    }
}