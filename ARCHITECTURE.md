# Architecture Overview

## Solution Purpose

This repository is intended as a demonstration project for GitHub Copilot capabilities. It serves as a template or starting point for exploring Copilot's features in a real-world development workflow.

## Project/Folder Structure

- `src/API`: ASP.NET Core Web API project (presentation layer)
- `src/Application`: Application logic and service interfaces (business logic layer)
- `src/Domain`: Domain entities and core business models (domain layer)
- `src/Infrastructure`: Infrastructure and data access implementations (infrastructure layer)
- `README.md`: Project overview and basic instructions.
- `ARCHITECTURE.md`: This document, describing the solution's architecture.
- `.git/`: Git version control metadata.

## Key Frameworks & NuGet Dependencies

- ASP.NET Core (Web API)
- Microsoft.Extensions.DependencyInjection (DI)
- Swashbuckle.AspNetCore (Swagger UI)

## Data Flow Between Layers

1. **API Layer** receives HTTP requests and delegates to Application services via DI.
2. **Application Layer** contains business logic and service interfaces, calls Domain models and Infrastructure implementations.
3. **Domain Layer** holds core business entities and logic, independent of other layers.
4. **Infrastructure Layer** implements interfaces from Application, handles data access and external integrations.

## Design Patterns in Use

- Dependency Injection (DI) for service registration and decoupling
- Repository Pattern (recommended for future data access)
- Layered/Onion Architecture for separation of concerns

---

_This architecture follows Onion Architecture principles. Update as your project evolves._

