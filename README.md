# CoreAppFramework
.NET Core App abstracting the .NET Core Dependency Injection & Logger using the iDesign Manager/Engine/Accessor architecture design.

## Core Projects
* **Contracts** - Interfaces
* **DataContracts** - DTOs

## Infrastructure Projects
* **Utils** - Logger, Dependency Injection ServiceProvider base class, Security, & other 3rd-party library abstraction classes.
* **Managers** - Orchestrate execution of Manager/Engine/Accessor logic.
* **Engines** - Business Logic or other isolated logic (ie - builder, processor, calculator, etc).
* **Accessors** - Database access or 3rd-party access (like APIs).  Can only be called by a Manager or Engine.
* **Tests** - The Unit Tests for all of the Infrastructure projects.

## Clients Projects
* **Web** - The .NET Core MVC frontend for this solution.
