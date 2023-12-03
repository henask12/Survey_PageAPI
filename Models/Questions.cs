using Survey.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class Questions : AuditLog
    {
        public long Id { get; set; }
        public string QuestionText { get; set; }
        public List<long> ChoiceIds { get; set; }
        public bool IsGeneral { get; set; }
        public int Min { get; set; }
        public int Max { get; set; }
    }
}