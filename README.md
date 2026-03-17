# DesignPatterns

A .NET 8.0 repository demonstrating various design pattern implementations with practical examples.

## Table of Contents
- [Factory Pattern](#factory-pattern)
- [Building & Running](#building--running)
- [Project Structure](#project-structure)

## Factory Pattern

The Factory Method pattern is a creational design pattern that provides an interface for creating objects without specifying the exact classes to instantiate. This repository demonstrates the pattern using an air conditioning system.

### Overview
The Factory pattern implementation includes:
- **IAirConditioner** - Interface defining the contract for all AC operations
- **AirConditionerFactory** - Abstract base class that defines the factory creation contract
- **Concrete Factories** - `CoolingFactory`, `WarmingFactory`, `RoomTemperatureFactory`
- **Concrete Products** - `Cooling`, `Warming`, `RoomTemperature` classes implementing `IAirConditioner`
- **AirConditioner Service** - Manages factories via a Dictionary and delegates object creation

### Usage Example

```csharp
// Create cooling operation at 22.5 degrees
var airConditioner = new AirConditioner();
var cooler = airConditioner.ExecuteCreation(Actions.Cooling, 22.5);
cooler.Operate();

// Create warming operation at 35.0 degrees
var warmer = airConditioner.ExecuteCreation(Actions.Warming, 35.0);
warmer.Operate();

// Create room temperature operation at 32.5 degrees
var roomTemp = airConditioner.ExecuteCreation(Actions.RoomTemperature, 32.5);
roomTemp.Operate();
```

### Key Features
- **Decoupling**: Client code doesn't need to know about concrete AC implementations
- **Extensibility**: Add new AC types by creating new factory and product classes
- **Dictionary-based Registration**: Factories are registered in a Dictionary for dynamic lookup
- **Type Safety**: Enum-based action selection prevents invalid requests

### Running the Factory Example

```bash
# Run the Factory project
dotnet run --project Factory/Factory.csproj

# Or build and run
dotnet build Factory/Factory.csproj
dotnet run --project Factory/Factory.csproj
```

Expected output demonstrates the three AC operations with their respective temperature settings and behaviors.

---

## Building & Running

### Build entire solution
```bash
dotnet build
```

### Build specific project
```bash
dotnet build Factory/Factory.csproj
dotnet build DesignPatterns/DesignPatterns.csproj
```

### Clean build artifacts
```bash
dotnet clean
```

## Project Structure

```
DesignPatterns/
├── DesignPatterns.sln          # Solution file
├── Factory/                    # Factory Method pattern implementation
│   ├── IAirConditioner.cs      # AC interface
│   ├── AirConditionerFactory.cs # Abstract factory base
│   ├── Cooling.cs              # Concrete product
│   ├── Warming.cs              # Concrete product
│   ├── RoomTemperature.cs      # Concrete product
│   ├── AirConditioner.cs       # Service class
│   ├── Enum.cs                 # Actions enum
│   └── Program.cs              # Entry point
├── DesignPatterns/             # Main project
└── README.md
```

## References
- [Factory Method Pattern - Code Maze](https://code-maze.com/factory-method/)
- [Design Patterns - Gang of Four](https://en.wikipedia.org/wiki/Design_Patterns)
