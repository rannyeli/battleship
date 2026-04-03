# BattleShip

A classic Battleship board game built with C# Windows Forms (.NET Framework 4.0).

## About

Two-player Battleship game where you compete against the computer. Place your fleet on the board, then take turns firing at the enemy's grid to locate and sink their ships.

## How to Play

### Ship Placement
1. Drag each ship from the dock onto your 10×10 board.
2. Right-click a ship to rotate it (vertical ↔ horizontal).
3. Ships must have at least one cell of spacing between them.
4. Once all 5 ships are placed, click the battle button to start.

### Battle Phase
- Click a cell on the enemy board to fire.
- **Hit** — the cell is marked and you get another turn.
- **Miss** — the turn passes to the computer.
- When all cells of a ship are hit, it sinks and the surrounding cells are revealed.
- First player to sink all 5 enemy ships wins.

### Fleet

| Ship             | Size |
|------------------|------|
| Carrier          | 5    |
| Battleship       | 4    |
| Submarine        | 3    |
| Submarine        | 3    |
| Destroyer        | 2    |

## Requirements

- Windows OS
- .NET Framework 4.0 (Client Profile)
- Visual Studio 2010 or later (for building from source)

## Build & Run

1. Open `BattleShip.sln` in Visual Studio.
2. Set the configuration to **Debug | x86**.
3. Press **F5** to build and run.

Alternatively, from a Developer Command Prompt:

```
msbuild BattleShip.sln /p:Configuration=Debug /p:Platform=x86
BattleShip\bin\Debug\BattleShip.exe
```

## Project Structure

```
BattleShip/
├── Program.cs              # Application entry point
├── Form1.cs                # Main menu (start, instructions, exit, music toggle)
├── Game.cs                 # Core game form (board setup, turn logic, computer AI)
├── Board.cs                # 10×10 game board with ship placement and validation
├── Cell.cs                 # Individual board cell (status, hit state, rendering)
├── Ship.cs                 # Ship model (size, position, orientation, rendering)
├── Find.cs                 # AI targeting helper (tracks row/column of a discovered hit)
├── Instructions.cs         # Instructions dialog
└── Properties/
    └── Resources.resx      # Embedded images and sounds
```
