# BlazorPOS - Point of Sale System

A modern Point of Sale system built with Blazor and Clean Architecture principles.

## Project Structure

The solution follows Clean Architecture principles with the following layers:

- **BlazorPOS.Domain**: Contains enterprise logic and business entities
- **BlazorPOS.Application**: Contains business logic and use cases
- **BlazorPOS.Infrastructure**: Contains external concerns like database, file system, etc.
- **BlazorPOS.Web**: Blazor Server web application (presentation layer)

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022 or any preferred IDE

### Running the Application
1. Clone the repository
2. Navigate to the solution directory
3. Run `dotnet restore`
4. Run `dotnet run --project BlazorPOS.Web`

## Features (Planned)
- [ ] Product Management
- [ ] Inventory Management
- [ ] Sales Processing
- [ ] Customer Management
- [ ] Reporting
- [ ] User Authentication and Authorization
