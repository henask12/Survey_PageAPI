using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models.common
{
    public class AuditLog
    {
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime CreationDate { get; set; }
    public string CreatedBy { get; set; }
    public DateTime RevisionDate { get; set; }
    public string RevisedBy { get; set; }
    public RecordStatus Status { get; set; }
    }
}