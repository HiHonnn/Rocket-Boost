# Rocket Boost

A small 3D rocket navigation game built with Unity and C# as a GameDev.tv guided learning project.

**Platform:** Windows  
**Engine:** Unity 6 (`6000.5.2f1`)  
**Development time:** Approximately two weeks  
**Project type:** Guided learning project

[Watch gameplay on YouTube](https://www.youtube.com/watch?v=5Ye5w867rZ8) | [Download Windows build](https://drive.google.com/file/d/1ADvhywfYg-bhwRpEh1mtsDNAZH8qJk6P/view?usp=drive_link)

<!-- Optional screenshot: ![Rocket Boost gameplay](docs/gameplay.png) -->

## Overview

Use thrust and rotation to guide a rocket from the launch pad to the landing pad while avoiding obstacles. The prototype contains three levels, including moving obstacles, with audio and particle feedback for thrust, crashes, and successful landings.

## Gameplay features

- Rigidbody-based thrust and rotation controls using Unity Input System.
- Three playable levels with automatic level progression.
- Collision handling for safe objects, the landing pad, and hazards.
- Crash and success sequences with audio, particle effects, and a short transition delay.
- Moving obstacles using configurable oscillating motion.

## Controls

| Action | Input |
| --- | --- |
| Thrust | Hold Space |
| Rotate | Left / Right arrow keys |

Reaching the landing pad advances to the next level. Crashing restarts the current level. Completing the third level returns to the first level.

## Play on Windows

Download the playable build from [Google Drive](https://drive.google.com/file/d/1ADvhywfYg-bhwRpEh1mtsDNAZH8qJk6P/view?usp=drive_link).

1. Open the Google Drive link and download the Windows build archive.
2. Extract the entire archive into a folder.
3. Run `Rocket Boost.exe`.
4. Keep the executable, `Rocket Boost_Data`, DLLs, and runtime folders together.

Unity Editor is not required to play the Windows build.

GitHub's **Download ZIP** option contains the Unity project source. Use the Google Drive link above to download the ready-to-play Windows build.

## Open the project in Unity

1. Clone this repository, or download and extract its source ZIP:

   ```bash
   git clone https://github.com/HiHonnn/Rocket-Boost.git
   ```

2. In Unity Hub, add the repository folder as an existing project.
3. Open it with Unity **6000.5.2f1** and allow Unity to restore packages and import assets.
4. Open `Assets/Scenes/Map1.unity` and press **Play**.

The build configuration includes `Map1`, `Map2`, and `Map3` in that order. To create a Windows build, select the Windows build profile and build these scenes.

## Code to explore

| Script | Responsibility |
| --- | --- |
| [Movement.cs](Assets/Scripts/Movement.cs) | Thrust, rotation, engine audio, and thruster effects |
| [CollisionHandler.cs](Assets/Scripts/CollisionHandler.cs) | Crash/success sequences, scene restart, and level progression |
| [Oscillator.cs](Assets/Scripts/Oscillator.cs) | Moving obstacles between two positions |
| [TutorialUI.cs](Assets/Scripts/TutorialUI.cs) | Brief on-screen controls panel in the current source version |

## Learning context and contribution

I completed this project by following GameDev.tv's *Complete C# Unity 3D Game Development in Unity 6* course, with a few small changes to the course version. Most of the core mechanics and implementation approach follow the lessons.

This project records my practice with Rigidbody movement, collision handling, scene management, particle effects, audio feedback, and Windows builds. It is presented as a guided learning project.

## Repository scope and credits

This repository contains the Unity project source: `Assets`, `Packages`, and `ProjectSettings`, including scenes, prefabs, gameplay scripts, and asset metadata. Unity regenerates local caches such as `Library` when the project is opened. Windows builds are available separately through the Google Drive link above.

- Course and learning reference: [GameDev.tv](https://www.gamedev.tv/).
- Art, models, audio, and other third-party content, including the GameDev.tv starter assets, remain subject to their respective licenses.
- Credits do not grant permission to redistribute course materials or third-party assets.
