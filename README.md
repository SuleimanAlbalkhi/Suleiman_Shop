# Shop.Suleiman

A full-stack shop application built with ASP.NET Core (backend) and Angular (frontend).

## Video Review


https://github.com/user-attachments/assets/ebbdcd69-842d-4b45-89e2-6f11e422447b


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
- .NET Core SDK 3.1+ (or newer)
- Node.js 16.x (LTS recommended for Angular 10)
- npm (comes with Node.js)

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

   # Shop.Suleiman

   A modern full-stack shop application built with ASP.NET Core (.NET 9) and Angular 10.

   ## Overview
   - **Shop.API**: ASP.NET Core Web API for backend services
   - **Shop.Frontend**: Angular SPA for frontend user interface

   ## Features
   - Product management via RESTful API
   - SQLite database with EF Core migrations
   - Angular SPA for product browsing and notifications
   - Clean separation using repositories, DTOs, and AutoMapper

   ## Quick Start

   ### Prerequisites
   - .NET 9 SDK & Runtime
   - Node.js 16.x (LTS)
   - npm

   ### Backend Setup (Shop.API)
   ```sh
   dotnet restore Shop.API/shop.API.csproj
   dotnet build Shop.API/shop.API.csproj
   dotnet run --project Shop.API/shop.API.csproj
   # API runs at https://localhost:5001 and http://localhost:5000
   ```
   **CORS for development:**
   In `Startup.cs`, use:
   ```csharp
   services.AddCors();
   app.UseCors(options => options.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod());
   ```

   ### Frontend Setup (Shop.Frontend)
   ```sh
   cd Shop.Frontend
   npm install
   npx ng serve
   # App runs at http://localhost:4200
   ```
   **API URL:**
   Set `baseUrl` in `src/app/Products/products.service.ts` to match your backend (default: `https://localhost:5001/api/products`).

   ## Full Stack Testing
   1. Start backend: `dotnet run --project Shop.API/shop.API.csproj`
   2. Start frontend: `cd Shop.Frontend && npx ng serve`
   3. Open `http://localhost:4200` in your browser
   4. Confirm product data loads from the API
   5. If you see errors, check CORS, API URL, and certificate trust

   ## Troubleshooting
   - **Node/Angular CLI errors:** Use Node.js 16.x, run `npx ng serve`, uninstall global Angular CLI if needed
   - **CORS errors:** Ensure backend allows any origin for development
   - **Certificate warnings:** Accept/trust the developer certificate in your browser for local HTTPS

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

   ## Patterns & Key Files
   - Interface-based repositories (`IProductRepo`)
   - DTOs and AutoMapper for API data
   - Angular services for API communication
   - Error handling via HTTP responses and RxJS
   - `Shop.API/Startup.cs`: API config & CORS
   - `Shop.API/Data/IProductRepo.cs`: Repository interface
   - `Shop.API/Controllers/ProductsController.cs`: Product API
   - `Shop.Frontend/src/app/app.module.ts`: Angular root module

   ## License
   © 2025 Suleiman_Shop
