# BookReviewApp

> Early ASP.NET Core Web API project built around a book review domain.

## Overview

`BookReviewApp` explores backend application structure in .NET through a relational, database-backed API covering books, authors, categories, countries, reviewers, and reviews.

The project is not intended as a finished production system. Its value lies in exposing the main moving parts of a typical ASP.NET Core + EF Core backend in a manageable learning context.

## What the project includes

- ASP.NET Core Web API structure
- controller-based endpoint definitions
- DTOs for request/response shaping
- repository interfaces and implementations
- Entity Framework Core with SQL Server
- migrations and seeded sample data
- dependency injection setup in `Program.cs`
- OpenAPI / Swagger support
- Postman and HTTP request-based API testing

## Project layout

| Folder | Role |
|---|---|
| `Controllers` | HTTP endpoints and request handling |
| `Data` | EF Core database context |
| `Dto` | data transfer objects |
| `Interfaces` | repository contracts |
| `Models` | domain entities |
| `Repository` | repository implementations |
| `Migrations` | EF Core migration history |

## Why it matters

This project represents an early shift from language learning into backend architecture, data persistence, and API design in the .NET ecosystem.
