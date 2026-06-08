# Ele Shopping App

A simple C# console application for an electronic shopping experience. The app supports customer login/signup, staff login, product inventory management, and a shopping cart.

## Features

- Customer login and signup
- Staff login with admin access
- Staff product inventory management (add, remove, display, search)
- Product categories including TV, Smartphone, Laptop, Smartwatch, Tablet, and Headphone
- Shopping cart operations for customers

## Prerequisites

- .NET 10.0 SDK or later

## Run the application

From the project root directory, run:

```bash
dotnet run --project "Ele ShoppingApp.csproj"
```

## Project structure

- `Program.cs` - Application entry point and main menu
- `UserLogin.cs` - Customer login/signup and staff access handling
- `Products.cs` - Base product model and search/display methods
- `TV.cs`, `Smartphone.cs`, `Laptop.cs`, `Smartwatch.cs`, `Tablet.cs`, `Headphone.cs` - Product category classes
- `Cart.cs` - Shopping cart operations
- `Ele ShoppingApp.csproj` - .NET project file

## Notes

- Staff login currently uses hardcoded credentials: `admin` / `admin`
- The inventory is managed in memory while the application runs
- The app is designed as a console-based demo for learning C# and basic inventory/cart workflows
