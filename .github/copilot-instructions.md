# Copilot Instructions for Shop.Suleiman

## Overview
This codebase is a full-stack shop application with two main components:
- **Shop.API**: ASP.NET Core Web API (C#) for backend services
- **Shop.Frontend**: Angular 10+ SPA for frontend user interface

## Architecture
- **Shop.API** exposes RESTful endpoints for product management.
  - Controllers: `Shop.API/Controllers/`
  - Data access: `Shop.API/Data/` (supports both mock and SQLite implementations)
  - DTOs: `Shop.API/Dtos/`
  - Entity models: `Shop.API/Models/`
  - AutoMapper profiles: `Shop.API/Profiles/`
  - EF Core migrations: `Shop.API/Migrations/`
- **Shop.Frontend** is structured as a standard Angular CLI project.
  - Main app: `Shop.Frontend/src/app/`
  - Products feature: `Shop.Frontend/src/app/Products/`
  - Routing: `Shop.Frontend/src/app/app-routing.module.ts`

## Developer Workflows
### Backend (Shop.API)
- **Build**: Use VS Code tasks (`build`, `publish`, `watch`) or run `dotnet build Shop.API/shop.API.csproj`.
- **Run/Debug**: Use `dotnet watch run Shop.API/shop.API.csproj` for hot-reload.
- **Database**: Uses SQLite (`data.db`). Migrations in `Migrations/`.
- **Configuration**: `appsettings.json` and `appsettings.Development.json`.

### Frontend (Shop.Frontend)
- **Dev server**: `ng serve` (see `README.md`).
- **Build**: `ng build` (artifacts in `dist/`).
- **Unit tests**: `ng test` (Karma).
- **E2E tests**: `ng e2e` (Protractor).
- **Generate components/services**: `ng generate component|service <name>`.

## Project-Specific Patterns
- **Data Repositories**: Backend uses interface-based repositories (`IProductRepo`) with both mock and SQL implementations.
- **DTOs and AutoMapper**: All API data transfer uses DTOs and AutoMapper profiles.
- **Angular Services**: Frontend uses services for API communication (see `notification.service.ts`).
- **Error Handling**: API errors are returned as standard HTTP responses; Angular handles errors via RxJS.

## Integration Points
- **API <-> Frontend**: Angular services call API endpoints (default port 5000 for API, 4200 for frontend).
- **Database**: SQLite file (`data.db`) managed via EF Core.

## Conventions
- **C#**: Follows standard ASP.NET Core conventions; DI via Startup.cs.
- **Angular**: Follows Angular CLI structure and style.
- **File Naming**: DTOs, Profiles, and Repos are clearly named by function.

## Key Files
- `Shop.API/Startup.cs`: API configuration and DI setup
- `Shop.API/Data/IProductRepo.cs`: Repository interface
- `Shop.API/Controllers/ProductsController.cs`: Main product API
- `Shop.Frontend/src/app/app.module.ts`: Angular root module
- `Shop.Frontend/README.md`: Angular workflow reference

---
For questions or unclear patterns, review the above files or ask for clarification.
