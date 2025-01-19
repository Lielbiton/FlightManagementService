using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementService.Models
{
    public class User
    {
        public string UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
