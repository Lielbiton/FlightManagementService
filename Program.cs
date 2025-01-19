using FlightManagementService.Models;
using FlightManagementService.Services;
using System;
using System.Linq;

namespace FlightManagementService
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the AlertService
            AlertManagementService alertService = new AlertManagementService();

            // Create a new user
            var user = new User
            {
                UserId = Guid.NewGuid().ToString(),
                Name = "Liel Machluf",
                Email = "lielbiton62@gmail.com",
                Phone = "054-7738927"
            };

            // Adds the user to the system
            alertService.AddUser(user);

            // Creates a new alert
            var alert = new Alert
            {
                User = user,
                Destination = "Paris",
                MaxPrice = 1000,
                MinPrice = 500,
                IsActive = true,
                AlertType = "Price Drop",
                FlightId = "FL123"
            };

            // Adds the alert to the system
            try
            {
                alertService.AddAlert(alert);
                Console.WriteLine("Alert added successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error adding alert: {ex.Message}");
            }

            // Retrieve all alerts for the user
            Console.WriteLine("\nAll alerts for the user:");
            var alertsForUser = alertService.GetAlertsByUserId(user.UserId);
            foreach (var a in alertsForUser)
            {
                Console.WriteLine($"- Destination: {a.Destination}, Max Price: {a.MaxPrice}, Min Price: {a.MinPrice}, Active: {a.IsActive}");
            }

            // Updates an alert
            Console.WriteLine("\nUpdating alert...");
            alert.MaxPrice = 900;
            alertService.UpdateAlert(alert);
            Console.WriteLine("Alert updated successfully.");

            // Retrieves updated alerts
            Console.WriteLine("\nUpdated alerts for the user:");
            alertsForUser = alertService.GetAlertsByUserId(user.UserId);
            foreach (var a in alertsForUser)
            {
                Console.WriteLine($"- Destination: {a.Destination}, Max Price: {a.MaxPrice}, Min Price: {a.MinPrice}, Active: {a.IsActive}");
            }

            // Deletes an alert
            Console.WriteLine("\nDeleting alert...");
            alertService.DeleteAlert(alert.AlertId);
            Console.WriteLine("Alert deleted successfully.");

            // Try retrieving alerts again
            Console.WriteLine("\nAll alerts for the user after deletion:");
            alertsForUser = alertService.GetAlertsByUserId(user.UserId);
            if (!alertsForUser.Any())
            {
                Console.WriteLine("No alerts found.");
            }
        }
    }
}
