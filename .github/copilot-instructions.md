# Copilot Instructions for DesignPatterns Repository

## Overview
This is a .NET 8.0 repository demonstrating design pattern implementations. Currently contains:
- **DesignPatterns** - Main project (placeholder for future patterns)
- **Factory** - Factory Method pattern implementation with an air conditioner system

## Build & Run Commands

### Build the entire solution
```bash
dotnet build
```

### Build a specific project
```bash
dotnet build Factory/Factory.csproj
dotnet build DesignPatterns/DesignPatterns.csproj
```

### Run a specific project
```bash
dotnet run --project Factory/Factory.csproj
dotnet run --project DesignPatterns/DesignPatterns.csproj
```

### Clean build artifacts
```bash
dotnet clean
```

## Project Structure

### Solution Organization
- **DesignPatterns.sln** - Main solution file with two projects

### Factory Pattern (Factory/)
A complete implementation of the Factory Method pattern demonstrating object creation for different air conditioner operations:

**Architecture:**
- **IAirConditioner** - Interface that all AC implementations follow
- **AirConditionerFactory** - Abstract base class defining the factory contract
- **Concrete Factories** - CoolingFactory, WarmingFactory, RoomTemperatureFactory each creating their respective implementations
- **Concrete Products** - Cooling, Warming, RoomTemperature classes implementing IAirConditioner
- **Actions Enum** - Defines available operations (Cooling, Warming, RoomTemperature)
- **AirConditioner** - Service class that holds a Dictionary of factories and delegates creation based on the Actions enum

**Key Pattern Details:**
- The AirConditioner class uses a Dictionary<Actions, AirConditionerFactory> to map enum values to factory instances
- Each factory implements Create(double temperature) to produce the appropriate IAirConditioner implementation
- Products are instantiated with temperature parameters and can be executed via Operate()

### DesignPatterns Project (DesignPatterns/)
Currently a placeholder console application (prints "Hello World!"). Intended for future pattern demonstrations.

## Key Conventions

### Naming
- Interface names follow standard C# convention with **I** prefix (e.g., IAirConditioner)
- Factory classes are suffixed with "Factory" (e.g., CoolingFactory)
- Abstract factory base class is generic and pattern-named (AirConditionerFactory)
- Concrete product classes match their domain concept directly (Cooling, Warming, RoomTemperature)

### Namespace Usage
- Each project has its own namespace matching the project name (Factory, DesignPatterns)
- No sub-namespaces are used; all types are at the project-level namespace

### Pattern Application
- Each new design pattern should be added as a separate folder at the solution root (following Factory/ structure)
- Each pattern folder should have its own .csproj and Program.cs demonstrating usage
- Implement the pattern cleanly; comments document the approach (see AirConditioner.cs for reflection example)

### Code Style
- C# 8.0+ features are used (e.g., nullable reference types may be enabled)
- Use expression-bodied members where appropriate (e.g., factory Create methods)
- Keep concrete implementations minimal—focus on pattern illustration
