# Unity Driving Simulation Prototype 🚗💨

A feature-rich driving simulation project developed as part of **Unity Learn**, expanding upon the foundational mechanics into an interactive, multi-mode driving experience.

## ✨ Features Implemented

### 1. Obstacle Pyramid (Easy)
* Constructed structured obstacle formations using physics-enabled prefabs.
* Designed collision interactions to test vehicle handling and impact physics.

### 2. Oncoming Traffic (Medium)
* Implemented dynamic oncoming vehicles moving in the opposite direction.
* Utilized custom scripting (`MoveOncomingVehicle.cs`) to control traffic flow and increase environmental difficulty.

### 3. Interactive Camera Switching (Hard)
* Developed a `CameraSwitcher` script allowing players to seamlessly toggle perspectives between:
  * **Main Camera:** External third-person chase cam positioned behind the vehicle.
  * **Driver Camera:** First-person cock-pit view positioned from the driver's seat perspective.

### 4. Local Multiplayer (Expert)
* Split-screen setup utilizing camera **Viewport Rect** configurations.
* Integrated Unity's **Input System** (`UnityEngine.InputSystem`) to support independent multi-player controls:
  * **Player 1:** Controlled via `WASD` keys.
  * **Player 2:** Controlled via `Arrow` keys.

---

## 🛠️ Tech Stack & Environment
* **Engine:** Unity 6 (6000.3.25f1)
* **Language:** C#
* **Input System:** Unity Input System package

---

## 🚀 Getting Started

1. **Clone the repository:**
   ```bash
   git clone [https://github.com/your-username/your-repo-name.git](https://github.com/your-username/your-repo-name.git)
