# Minecraft Chest Manager

A C# console app for keeping track of what's in your Minecraft chests.
Create named chests, add items and quantities, and view everything you've saved.
Data is stored in a local SQLite database using Entity Framework Core.

## Features

- Create a chest and give it a name
- Add items with quantities, with input checking so bad numbers don't crash the app
- View all saved chests and their contents
- Data is saved between runs

## Built with

- C# / .NET 9
- Entity Framework Core 9
- SQLite

## How to run

1. Clone the repo
2. Open `MinecraftCM.sln` in Visual Studio 2022
3. Press F5. The database is created automatically on first run.

## What I learned

- Modelling a one-to-many relationship (one chest, many items) with EF Core
- Using migrations to create a database from C# classes
- Validating user input with `int.TryParse`

## Next steps

- A menu loop so you can add and view chests in one session
- Editing and deleting chests