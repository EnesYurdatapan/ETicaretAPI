# **Mini E-Commerce**
This project is a web application built on **.NET Core 6.0**. It utilizes the following technologies and architectural patterns:
## **Technologies and Architectures Used**
- **Onion Architecture**: A layered architecture model is used to separate application modules, reducing dependencies and enhancing testability.
- **PostgreSQL**: PostgreSQL is used as the database for the application.
- **Entity Framework Core (Code First)**: Entity Framework is used for database operations, and the database is created using the Code First approach.
- **CQRS (Command Query Responsibility Segregation)**: Command and query operations are handled in separate layers, segregating data updates from data retrievals.
- **Generic Repository Design Pattern**: A generic repository pattern is applied for database operations.
- **Identity**: ASP.NET Core Identity is used for user authentication processes.
- **SignalR**: SignalR integration is used for real-time communication needs(MailService).
- **Logging**: A logging mechanism is set up for tracking errors and activities within the application.
- **Login and Authorization**: User login and authorization processes are integrated.
- **Role-Based Authentication**: Users are authorized based on different roles.
- **Authentication Middleware**: Middleware is used for authentication processes.
- **JWT (JSON Web Token)**: JWT is used for user authentication and authorization.
- **Fluent Validation**: Fluent Validation is used for data validation processes.
- **Local Storage**: Local storage is used for file storage operations.
- **QR Code**: The application supports QR code generation and validation.
## **Setup and Running the Application**
### **Requirements**
- .NET 6 SDK
- PostgreSQL 13+
- Git
### **Step 1: Clone the Repository**
1. First, clone the project from GitHub:
1. git clone https://github.com/EnesYurdatapan/ETicaretAPI.git
1. cd ETicaretAPI
### **Step 2: PostgreSQL Configuration**
- Update the connection string in the appsettings.json file so the application can connect to your PostgreSQL database:

"ConnectionStrings": {

`    `"DefaultConnection": "Host=localhost;Database=your\_database\_name;Username=your\_username;Password=your\_password"

}
### **Step 3: Create the Database**
- Run the following command to create the database using Entity Framework Core:

\>> dotnet ef database update
### **Step 4: Run the Application**
- In the project’s root directory, run the following command to start the application:

\>> dotnet run

**Endpoint Pictures**


![](presentation/ETicaretAPI.API/wwwroot/photo-images/ss1.png)
![](presentation/ETicaretAPI.API/wwwroot/photo-images/ss2.png)
![](presentation/ETicaretAPI.API/wwwroot/photo-images/ss3.png)




