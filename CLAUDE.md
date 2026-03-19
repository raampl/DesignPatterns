# Design Patterns Repository - Technical Details

## Overview
This repository contains implementations of common design patterns using modern .NET technologies.

## Technology Stack

### .NET Framework
- **Framework**: .NET 8.0
- **SDK**: Microsoft.NET.Sdk
- **Type**: Console Applications (Exe)

### Programming Language
- **Language**: C#
- **Version**: Latest (as per .NET 8.0)

### Build System
- **Build Tool**: .NET CLI (dotnet)
- **Solution Format**: Visual Studio 15 (Modern format)
- **Configuration**: Debug | Any CPU, Release | Any CPU

## Projects

### 1. **DesignPatterns**
- **Type**: Console Application (.NET 8.0)
- **Output**: Executable
- **Purpose**: Main namespace for pattern implementations
- **Build Command**: `dotnet build DesignPatterns/DesignPatterns.csproj`
- **Run Command**: `dotnet run --project DesignPatterns/DesignPatterns.csproj`

### 2. **Factory**
- **Type**: Console Application (.NET 8.0)
- **Output**: Executable
- **Purpose**: Factory Method Pattern Implementation
- **Pattern Focus**: Air Conditioner creation system with factory abstraction
- **Build Command**: `dotnet build Factory/Factory.csproj`
- **Run Command**: `dotnet run --project Factory/Factory.csproj`

## Key Features

### Factory Pattern Implementation
- **Interface**: `IAirConditioner` - Contract for all AC implementations
- **Abstract Factory**: `AirConditionerFactory` - Base factory class
- **Concrete Factories**: 
  - `CoolingFactory` - Creates cooling AC units
  - `WarmingFactory` - Creates warming AC units
  - `RoomTemperatureFactory` - Creates temperature control units
- **Concrete Products**: Cooling, Warming, RoomTemperature classes
- **Service Class**: AirConditioner with factory dictionary pattern

## Development Setup

### Prerequisites
- .NET 8.0 SDK (or later compatible version)
- Visual Studio, Visual Studio Code, or Rider IDE

### Build Commands
```bash
# Build entire solution
dotnet build

# Build specific project
dotnet build Factory/Factory.csproj
dotnet build DesignPatterns/DesignPatterns.csproj

# Clean artifacts
dotnet clean
```

### Run Commands
```bash
# Run Factory pattern demo
dotnet run --project Factory/Factory.csproj

# Run main project
dotnet run --project DesignPatterns/DesignPatterns.csproj
```

## Project Structure
```
DesignPatterns/
├── DesignPatterns.sln          # Solution file
├── DesignPatterns/             # Main project
│   ├── DesignPatterns.csproj
│   └── Program.cs
├── Factory/                    # Factory pattern implementation
│   ├── Factory.csproj
│   ├── Program.cs
│   ├── IAirConditioner.cs
│   ├── AirConditionerFactory.cs
│   ├── Concrete implementations/
│   └── AirConditioner.cs (service class)
└── README.md                   # Project documentation
```

## Summary
This is a modern .NET 8.0 project demonstrating fundamental design patterns using C# with console-based implementations and factory abstraction patterns for extensible object creation.
