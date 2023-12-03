using Survey.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class Choice : AuditLog
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}