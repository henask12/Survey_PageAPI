using Survey.Models.common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Survey.Models
{
    public class User : AuditLog
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string FlightNumber { get; set; }
        public string SeatNumber { get; set; }
        public DateTime FlightDate { get; set; }
    }
}