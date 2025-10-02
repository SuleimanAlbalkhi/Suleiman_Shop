# Shop.Suleiman

A full-stack shop application built with ASP.NET Core (backend) and Angular (frontend).

## Architecture
- **Shop.API**: ASP.NET Core Web API for backend services
- **Shop.Frontend**: Angular 10+ SPA for frontend user interface

## Features
- Product management via RESTful API
- SQLite database with EF Core migrations
- Angular SPA with product browsing and notifications
- Interface-based repositories and DTOs for clean separation

## Getting Started

### Prerequisites
- .NET Core SDK 3.1+
- Node.js & npm
- Angular CLI (`npm install -g @angular/cli`)

### Backend (Shop.API)
1. Restore dependencies:
   ```sh
   dotnet restore Shop.API/shop.API.csproj
   ```
2. Build:
   ```sh
   dotnet build Shop.API/shop.API.csproj
   ```
3. Run (with hot reload):
   ```sh
   dotnet watch run Shop.API/shop.API.csproj
   ```
4. API available at `http://localhost:5000`

### Frontend (Shop.Frontend)
1. Install dependencies:
   ```sh
   cd Shop.Frontend
   npm install
   ```
2. Start dev server:
   ```sh
   ng serve
   ```
3. App available at `http://localhost:4200`

## Testing
- **Backend**: Add and run tests using standard .NET test frameworks
- **Frontend**:
  - Unit tests: `ng test` (Karma)
  - E2E tests: `ng e2e` (Protractor)

## Project Structure
```
Shop.API/           # ASP.NET Core backend
  Controllers/      # API controllers
  Data/             # Repositories and DB contexts
  Dtos/             # Data Transfer Objects
  Models/           # Entity models
  Profiles/         # AutoMapper profiles
  Migrations/       # EF Core migrations
Shop.Frontend/      # Angular frontend
  src/app/          # Main app code
    Products/       # Product feature
    ...
```

## Conventions & Patterns
- Backend uses interface-based repositories (`IProductRepo`) and DTOs
- AutoMapper for model/DTO mapping
- Angular services for API communication
- Error handling via HTTP responses and RxJS

## Key Files
- `Shop.API/Startup.cs`: API configuration
- `Shop.API/Data/IProductRepo.cs`: Repository interface
- `Shop.API/Controllers/ProductsController.cs`: Product API
- `Shop.Frontend/src/app/app.module.ts`: Angular root module
- `Shop.Frontend/README.md`: Angular workflow reference

## License
MIT
