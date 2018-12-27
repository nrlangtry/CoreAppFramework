# CoreAppFramework
.NET Core App Framework

## Core Projects
* **Contracts** - Interfaces
* **DataContracts** - DTOs

## Infrastructure Projects
* **Configuration** - .NET Core Startup configurations. For now it's just Dependency Injection.
* **Utils** - Logger, Dependency Injection, Security, & other 3rd-party library abstraction classes.
* **Managers** - Orchestrate execution of Manager/Engine/Accessor logic.
* **Engines** - Business Logic or other isolated logic (ie - builder, processor, calculator, etc).
* **Accessors** - Database access or 3rd-party access (like APIs).  Can only be called by a Manager or Engine.
* **Tests** - The Unit Tests for all of the Infrastructure projects.

## Clients Project (aka Client(s))
* **Web** - The .NET Core MVC frontend for this solution.
