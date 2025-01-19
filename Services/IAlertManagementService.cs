using FlightManagementService.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightManagementService.Services
{
    public interface IAlertManagementService
    {
        void AddAlert(Alert alert);
        List<Alert> GetAlerts();
        void UpdateAlert(Alert alert);
        void DeleteAlert(string alertId);
        List<Alert> GetAlertsByUserId(string userId);
    }
}
