using Survey.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class Responses : AuditLog
    {
        public long Id { get; set; }
        public long UserId { get; set; }
        public long QuestionId { get; set; }
        public string Answer { get; set; }
    }
}