using FlightManagementService.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FlightManagementService.Services
{
    public class AlertManagementService
    {
        private readonly List<Alert> _alerts = new List<Alert>();
        private readonly List<User> _users = new List<User>(); // Managing users within AlertService just for check

        // Creates a new alert
        public void AddAlert(Alert alert)
        {
            if (alert == null)
            {
                throw new ArgumentNullException(nameof(alert), "Alert cannot be null.");
            }
            // Validates if user exists
            if (!_users.Any(u => u.UserId == alert.User?.UserId))
            {
                throw new KeyNotFoundException("User not found.");
            }
            _alerts.Add(alert);
        }

        // Gets alerts by user ID
        public List<Alert> GetAlertsByUserId(string userId)
        {
            return _alerts.Where(a => a.User?.UserId == userId).ToList();
        }

        // Updates an existing alert
        public void UpdateAlert(Alert newAlert)
        {
            var alert = _alerts.FirstOrDefault(a => a.AlertId == newAlert.AlertId);
            if (alert != null)
            {
                alert.User = newAlert.User;
                alert.Destination = newAlert.Destination;
                alert.MaxPrice = newAlert.MaxPrice;
                alert.MinPrice = newAlert.MinPrice;
                alert.IsActive = newAlert.IsActive;
                alert.FlightId = newAlert.FlightId;
                alert.CreatedAt = DateTime.UtcNow;
                alert.AlertType = newAlert.AlertType;
            }
        }

        public void DeleteAlert(string alertId)
        {
            var alert = _alerts.FirstOrDefault(a => a.AlertId == alertId);
            if (alert != null)
            {
                _alerts.Remove(alert);
            }
        }

        // User-related logic within AlertService - for check
        public void AddUser(User user)
        {
            _users.Add(user);
        }

        public List<User> GetUsers() => _users;
    }
}
