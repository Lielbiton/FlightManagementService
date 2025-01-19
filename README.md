# FlightManagementService

**FlightManagementService** is a backend service for managing flight price alerts and sending notifications to users when the price matches their specified criteria. This system is built to handle high loads and provides an intuitive alert management system.

---

## Key Features

- **Price Alerts**: Receives flight price information from external sources (e.g., airline APIs).
- **Push Notifications**: Sends push notifications to users when the price matches their alert criteria.
- **Alert Management**: Manages users' flight price alerts.
- **High Load Support**: Designed to handle large numbers of requests and notifications efficiently.

---

## Architecture Diagram

The following diagram illustrates the system's architecture, showing how the different components interact with each other:

![Architecture Diagram](https://github.com/user-attachments/assets/d21e7cc0-3654-49e5-9ad8-d5a53d801694)

---

## Data Structures

Here are the key data structures used in the Flight Management System:

- **User**: Represents the user who sets the price alerts.
- **Alert**: Represents the price alert set by the user.
- **PriceUpdate**: Represents the flight price data.
- **Notification**: Represents notifications sent to users when alerts are triggered.

![Flight Management System - Data Structures](https://github.com/user-attachments/assets/0577a1fb-0ce3-45cb-9c3e-c61e905a35ca)

---

## Data Flow

The data flow diagram represents the movement of data between the different components in the system. It shows how the alert service, notification service, and price update service interact with each other to deliver alerts to users.

![Flight Management System - Data Flow Diagram](https://github.com/user-attachments/assets/472f700d-29dd-4107-a71e-2fc4edf37568)

---

## Installation

To set up the project on your local machine:

1. Clone the repository:
   ```bash
   git clone https://github.com/Lielbiton/FlightManagementService.git

2. Navigate to the project directory:
   ```bash
   cd FlightManagementService
   ```

3. Build the project:
   - If using Visual Studio:
     - Open the `.sln` file in Visual Studio.
     - Build the solution by pressing `Ctrl + Shift + B`.
   - If using VS Code:
     - Make sure you have the .NET SDK installed.
     - Open a terminal and run:
       ```bash
       dotnet build
       ```

4. Run the project:
   ```bash
   dotnet run
   ```

---

## Implementation Details

The core functionality of this system revolves around the **Alert Management (CRUD)** feature, which is implemented as follows:

- **Add Alert**: Users can create flight price alerts by specifying the destination, maximum price, minimum price, and whether the alert is active.
- **Update Alert**: Users can modify their existing alerts.
- **Delete Alert**: Users can remove an alert once they no longer need it.
- **Get Alerts**: Users can view all of their active alerts.

### Example:

Here’s an example of how to create a new alert in the system:

```csharp
var alertService = new AlertService();
alertService.AddAlert(new Alert
{
    User = user,  // User object that was already created
    Destination = "New York",
    MaxPrice = 200.00f,
    MinPrice = 150.00f,
    IsActive = true,
    AlertType = "Price Drop",
    FlightId = "NY123"
});
```

This approach ensures that the system is easy to maintain and scale, and it handles large numbers of requests efficiently.

---

## Conclusion

This project demonstrates my ability to design a scalable and efficient backend service for flight price management, focusing on core concepts such as alert management, data flow, and system architecture. The implementation ensures that the system can handle high request volumes and deliver timely notifications to users when their price alerts are triggered.

---

### Additional Notes

- I have designed this system to be extensible for adding additional services, such as more sophisticated user notifications or more advanced price update tracking.
- The system is designed with scalability in mind, ensuring it can handle a large number of users and alerts efficiently.

---

### Contact

If you have any questions or would like to discuss the project further, feel free to reach out to me via [LinkedIn](http://www.linkedin.com/in/liel-biton-346948158) or email me at lielbiton62@gmail.com.


