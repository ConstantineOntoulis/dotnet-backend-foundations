# BookReviewApp

> Introductory ASP.NET Core Web API project built around a book review domain.

## Overview

`BookReviewApp` is an early backend practice project built with ASP.NET Core, Entity Framework Core, and SQL Server. The API is organized around a simple relational domain that includes books, authors, categories, countries, reviewers, and reviews.

The project is not intended as a production-ready system. Its purpose is to explore how a database-backed .NET API is structured, how HTTP endpoints are organized, and how data access is handled through EF Core and repository-based abstractions.

## What the project includes

- ASP.NET Core Web API structure
- controller-based routing and endpoint definitions
- DTO usage across parts of the API surface
- repository interfaces and implementations
- Entity Framework Core with SQL Server
- migrations and seeded sample data
- dependency injection configured in `Program.cs`
- OpenAPI / Swagger support
- API testing with Postman

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
