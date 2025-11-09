<div align="center">

# 🎲 Snake & Ladder Game

### A fully automated two-player Snake & Ladder simulation built with C#

[Features](#-features) • [Installation](#-installation) • [Usage](#-usage) • [Architecture](#️-architecture)

</div>

---

## 📋 Overview

A console-based implementation of the classic Snake & Ladder board game that simulates autonomous gameplay between two players. The game follows the official **UC1–UC7** problem statement rules using multidimensional arrays, random dice rolls, and position updates.

---

## ✨ Features

- 🎯 **Automated Gameplay** — Runs continuously without user input until completion
- 👥 **Two-Player Mode** — Alternating turns between Player 1 and Player 2
- 🎲 **Random Dice Rolls** — Generates random numbers from 1 to 6 using `Random.Next()`
- 🪜 **Ladder Bonus** — Players get an extra turn on a ladder
- 🐍 **Snake Penalty** — Player moves backward when bitten by a snake
- 🏆 **Exact Win Condition** — Must land exactly on position 100 to win
- 📊 **Game Statistics** — Tracks dice rolls and shows player position after every turn
- 🔁 **UC-Based Design** — Implements all seven use cases step by step (UC1–UC7)

---

## 🚀 Installation

### Prerequisites

- .NET SDK / Runtime or Visual Studio / JetBrains Rider
- C# 10 or later

### Clone the Repository

```bash
git clone https://github.com/sudiptabag2004/snake-ladder-game.git
cd snake-ladder-game
```

---

## 💻 Usage

### Run from Terminal

```bash
csc Program.cs
Program.exe
```

### Run from Visual Studio / Rider

1. Open the `.sln` file
2. Press **F5** or click **Run**

### Sample Output

```
======================================
        Snake and Ladder Game
======================================

Roll 1: Player 1 rolled 4
Option: Ladder! Player climbs ahead by 4 → Position: 4
--------------------------------------
Roll 2: Player 2 rolled 5
Option: Snake! Player slides down by 5 → Position: 0
--------------------------------------
...
🎉 Player 1 WON the game in 58 rolls!
======================================
```

---

## 🏗️ Architecture

### Game Flow

```
Start Game
   ↓
Initialize 10×10 Board (Multidimensional Array)
   ↓
Roll Dice (1–6)
   ↓
Randomly Choose Option (No Play / Ladder / Snake)
   ↓
Update Player Position
   ↓
Check Boundaries (0 – 100)
   ↓
Switch Player (unless Ladder)
   ↓
Repeat Until Someone Reaches 100
```

### Core Components

| Component | Description |
|-----------|-------------|
| **Multidimensional Array** | Represents 10×10 board (100 cells) |
| **Random Dice** | `Random.Next(1, 7)` generates dice roll |
| **Game Options** | `Random.Next(0, 3)` → No Play, Ladder, or Snake |
| **Loop Logic** | Repeats turns until exact 100 is reached |
| **Position Tracker** | Displays position after every roll |
| **Statistics** | Counts total dice rolls |
| **Two-Player System** | Ladder grants an extra turn; declares winner |

---

## 🧩 Use Case Implementation Summary

| UC | Description | Implemented |
|----|-------------|-------------|
| **UC1** | Game starts with single player at position 0 | ✅ |
| **UC2** | Player rolls dice (1–6) using `Random` | ✅ |
| **UC3** | Checks for No Play / Ladder / Snake | ✅ |
| **UC4** | Repeat till reaching 100 | ✅ |
| **UC5** | Must land exactly on 100 | ✅ |
| **UC6** | Report dice count & position after every roll | ✅ |
| **UC7** | Two-player mode + ladder extra turn | ✅ |

---

## 🌿 Git Workflow

This project follows a **feature-branch workflow**:

```
main
 └── dev
      ├── feature/uc1  (Single-player start)
      ├── feature/uc2  (Dice roll)
      ├── feature/uc3  (Game options)
      ├── feature/uc4  (Game loop)
      ├── feature/uc5  (Exact 100 rule)
      ├── feature/uc6  (Roll tracking)
      └── feature/uc7  (Two-player mode)
```

Each feature branch is merged into `dev` after testing and finally into `main`.

---

## 🎯 Future Enhancements

- 🖥️ GUI version (WPF / WinForms)
- 🎮 N-player support
- 🎯 Custom snake / ladder positions
- 💾 Save / Load game state
- 🏅 Leaderboard tracking

---

## 👨‍💻 Author

**Sudipta Bag**

[![GitHub](https://img.shields.io/badge/GitHub-sudiptabag2004-181717?style=flat&logo=github)](https://github.com/sudiptabag2004)

---

<div align="center">

Made with ❤️ in C# (.NET Console)

</div>
