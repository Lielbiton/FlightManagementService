using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementService.Models
{
    public class Alert
    {
        public string AlertId { get; set; }
        public string Destination { get; set; }
        public float MaxPrice { get; set; }
        public float MinPrice { get; set; }
        public string AlertType { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedAt { get; set; }
        public string FlightId { get; set; }
        public User User { get; set; }
    }
}
