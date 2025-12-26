# Restaurant Management System

A comprehensive Windows Forms application built with C# for managing restaurant operations, including user management, order processing, reservations, inventory tracking, and sales reporting.

## Features

### Multi-Role User System
- **Admin**: Full system access with user management capabilities
- **Manager**: Inventory management, sales reports, and reservation oversight
- **Chef**: Order viewing and status updates
- **Customer**: Menu browsing, ordering, reservations, and feedback submission

### Core Functionalities

#### User Management
- User registration and authentication
- Role-based access control
- Password recovery system
- Profile management and updates
- Admin user creation with auto-generated passwords

#### Customer Features
- Browse menu and place orders
- Make table reservations
- Multiple payment methods (online payment and counter payment)
- Submit feedback and reviews
- Update personal information

#### Manager Features
- Inventory management and restocking
- View and analyze sales reports
- Reservation reports and management
- Employee management

#### Chef Features
- View incoming orders
- Update order status
- Track order completion times

#### Admin Features
- Add, view, update, and delete users
- Change user roles
- View customer feedback
- Manage system users

## Technology Stack

- **Language**: C# (.NET Framework 4.7.2)
- **UI Framework**: Windows Forms
- **Database**: SQL Server (LocalDB)
- **IDE**: Visual Studio 2017/2019/2022

## Database Schema

The application uses the following main tables:
- `userData` - User credentials and roles
- `customer` - Customer information and transactions
- `menu` - Food items and pricing
- `order` - Order details
- `reservation` - Table reservation information
- `Chef` - Chef assignments and order tracking
- `inventory` - Ingredient stock management
- `sales` - Sales tracking and reporting

## Prerequisites

- Windows OS (Windows 7 or later)
- .NET Framework 4.7.2 or higher
- SQL Server LocalDB or SQL Server Express
- Visual Studio 2017 or later (for development)

## Installation

1. Clone the repository:
   ```bash
   git clone https://github.com/xiangzhi2003/Restaurant-Management-System.git
   ```

2. Open the solution file:
   ```
   IOOP Assignment Group Adlina.sln
   ```

3. Restore NuGet packages:
   - Right-click on the solution in Solution Explorer
   - Select "Restore NuGet Packages"

4. Set up the database:
   - Open SQL Server Management Studio or Visual Studio SQL Server Object Explorer
   - Execute the SQL script from `mainDBQuery.sql` to create tables and sample data
   - Update the connection string in `App.config` if necessary

5. Build and run the application:
   - Press F5 or click "Start" in Visual Studio

## Configuration

Update the connection string in `App.config` to match your SQL Server instance:

```xml
<connectionStrings>
  <add name="IOOP_Assignment_Group_Adlina.Properties.Settings.MainDBConnectionString"
       connectionString="Data Source=(LocalDB)\MSSQLLocalDB;..."
       providerName="System.Data.SqlClient" />
</connectionStrings>
```

## Default Login Credentials

The system comes with pre-configured test accounts:

| Role     | Username | Email             | Password |
|----------|----------|-------------------|----------|
| Admin    | Adlina   | Adlina@mail.com   | ad123    |
| Manager  | Zhi      | Zhi@mail.com      | z123     |
| Chef     | Lim      | Lim@mail.com      | lim123   |
| Customer | Tayyeba  | Tayy@mail.com     | tayy123  |

## Project Structure

```
IOOP Assignment Group Adlina/
├── Forms/
│   ├── AdminMenuForm.cs         - Admin dashboard
│   ├── ManagerForm.cs           - Manager dashboard
│   ├── ChefForm.cs              - Chef interface
│   ├── CustomerMainMenu.cs      - Customer dashboard
│   ├── Login.cs                 - Login form
│   ├── SignUp.cs                - Registration form
│   └── [Other Forms]
├── Classes/
│   ├── UserClass.cs             - User operations
│   ├── CustomerClass.cs         - Customer operations
│   ├── Chef.cs                  - Chef operations
│   ├── FoodMenu.cs              - Menu operations
│   ├── Reservation.cs           - Reservation operations
│   └── PasswordGen.cs           - Password generation utility
├── Database/
│   ├── MainDB.mdf               - SQL Server database file
│   └── MainDB_log.ldf           - Database log file
├── App.config                   - Application configuration
└── mainDBQuery.sql              - Database creation script
```

## Usage

1. **Login**: Start the application and use one of the default credentials or create a new account
2. **Navigate**: Use the role-specific menu to access features
3. **Orders**: Customers can browse the menu and place orders
4. **Reservations**: Book tables for events through the reservation system
5. **Management**: Admins and managers can access reporting and management features

## Security Notes

- Passwords are currently stored in plain text (for educational purposes only)
- For production use, implement password hashing (e.g., BCrypt, PBKDF2)
- Add input validation and SQL injection protection
- Implement proper session management

## Known Issues

- Password storage is not encrypted
- Some forms may require additional validation
- Connection string contains hardcoded path

## Future Enhancements

- Implement password encryption
- Add email notification system
- Create reporting dashboard with charts
- Add receipt generation and printing
- Implement table management system
- Add support for promotions and discounts

## Contributors

- **Group Adlina** - Development Team

## License

This project is developed as an academic assignment for educational purposes.

## Acknowledgments

- Developed as part of the Introduction to Object-Oriented Programming (IOOP) course
- Asia Pacific University (APU)