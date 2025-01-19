using FlightManagementService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementService.Services
{
    public interface IAlertManagementService
    {
        void AddAlert(string userId, string destination, float maxPrice);
        List<Alert> GetAlerts();
        void UpdateAlert(string alertId, string newDestination, float newMaxPrice);
        void DeleteAlert(string alertId);
        List<Alert> GetAlertsByUserId(string userId);
    }
}
