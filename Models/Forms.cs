using Survey.Models.common;
using Survey.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class Forms : AuditLog
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public List<Category> Categories { get; set; }
        public FormStatus Status { get; set; }
        public DateTime From { get; set; }
        public DateTime To { get; set; }
        public string Remark { get; set; }
    }
}