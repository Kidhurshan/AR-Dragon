<div align="center">
  <h1 align="center">🐉 AR Dragon Game</h1>
  <p align="center">
    An immersive Augmented Reality game that brings mythical dragons to life.
  </p>
  
  <p align="center">
    <img src="https://img.shields.io/badge/Unity-2022.3%20LTS-black?logo=unity" alt="Unity Version" />
    <img src="https://img.shields.io/badge/ARCore-5.1.5-green?logo=google" alt="ARCore Version" />
    <img src="https://img.shields.io/badge/Platform-Android-brightgreen.svg" alt="Platform" />
    <img src="https://img.shields.io/badge/License-MIT-yellow.svg" alt="License" />
  </p>
</div>

<h2 align="center">🎥 Project Demo</h2>

<p align="center">
  <a href="https://youtu.be/kpfNc8FErFY">
    <img src="https://github.com/user-attachments/assets/7467f794-bf0f-451e-8a84-c4a1b0f9adec" alt="Project Demo Video" width="600" />
  </a>
</p>

---

## 📑 Table of Contents

- [About The Project](#-about-the-project)
- [Key Features](#-key-features)
- [Built With](#-built-with)
- [Getting Started](#-getting-started)
- [Project Structure](#-project-structure)
- [Core Scripts](#-core-scripts)
- [Gameplay](#-gameplay)
- [Contributing](#-contributing)
- [License](#-license)
- [Acknowledgments](#-acknowledgments)
- [Contact](#-contact)

---

## 📖 About The Project

<p align="center">
  <img src="https://github.com/user-attachments/assets/ecd24fd2-f806-4eb5-9e26-76eade956dbf" alt="Gameplay Screenshot" width="600" />
</p>


This professional-grade **Augmented Reality (AR) dragon game** is built with Unity and ARCore, designed to bring mythical dragons to life in your real-world environment. It leverages advanced AR image tracking, high-fidelity 3D assets, and smooth mobile controls to deliver an engaging and interactive experience. Whether for entertainment, education, or demonstration of AR capabilities, this project showcases best practices in Unity AR development.

---

## 🌟 Key Features

### 🎮 Core Gameplay
- **AR Image Tracking**: Dragons spawn when the camera detects specific reference images.
- **Touch Controls**: Intuitive joystick-based movement for mobile devices.
- **Real-time Interaction**: Control dragons in real-world space with smooth, physics-based movement.

### 🐲 Dragon Collection
  - Dragon Nightmare
![Dragon1](https://github.com/user-attachments/assets/95fbaa7c-8fb5-4804-b5d6-3f7814355e8e)



### 🎭 Rich Animations
Each dragon features a comprehensive animation set, including:
- **Movement**: Walk, Run, Jump, Fly
- **Combat**: Various attack animations

---

## 🛠️ Built With

This project is built on a modern stack of game development and AR technologies.

### Core Technologies
*   **Unity 2022.3 LTS**: The core game engine.
*   **ARCore 5.1.5**: Google's framework for building AR experiences on Android.
*   **AR Foundation 5.1.5**: Unity's cross-platform AR framework for building rich experiences.
*   **C#**: The primary programming language for game logic.

### Third-party Assets
*   **Joystick Pack**: For intuitive mobile touch controls.
*   **Four Evil Dragons HP**: A complete asset pack providing high-quality dragon models, animations, and textures.

---

## 🚀 Getting Started

Follow these instructions to get a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites
- Unity 2022.3 LTS or later
- An Android device with ARCore support
- Android SDK and build tools configured in Unity

### Installation

1.  **Clone the repository**:
    ```bash
    git clone https://github.com/yourusername/ar-dragon-game.git
    cd ar-dragon-game
    ```

2.  **Open in Unity**:
    - Launch the Unity Hub.
    - Click "Add" and select the cloned project folder.
    - Open the project with Unity 2022.3 LTS.

3.  **Build for Android**:
    - Navigate to `File > Build Settings`.
    - Ensure the platform is set to **Android**.
    - Configure Player Settings (e.g., package name, graphics APIs).
    - Click `Build And Run` to deploy to your connected ARCore-compatible device.

---

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── DrogonController.cs      # Dragon movement and control logic
│   └── PrefabCreator.cs         # AR dragon spawning and management
├── FourEvilDragonsHP/
│   ├── Animations/
│   ├── Animators/
│   ├── Materials/
│   ├── Mesh/
│   ├── Prefab/
│   └── Texture/
├── Joystick Pack/               # Mobile control system assets
├── Scenes/
│   └── GameScene.unity          # Main game scene
└── XR/                          # AR configuration and settings
```

---

## 🎯 Core Scripts

### `DrogonController.cs`
Handles all aspects of dragon movement and animation control:
- Processes input from the virtual joystick.
- Implements physics-based movement with smooth interpolation for realistic motion.
- Manages dynamic rotation to face the movement direction.

### `PrefabCreator.cs`
Manages the AR-based spawning and lifecycle of the dragons:
- Integrates with AR Foundation's image tracking system.
- Instantiates the correct dragon prefab when a reference image is detected.
- Handles the positioning, scaling, and orientation of the spawned dragon.

---

## 🎮 Gameplay

1.  **Launch the App**: Open the game on your ARCore-compatible Android device.
2.  **Scan an Image**: Point your camera at one of the reference images.
![Dragon1](https://github.com/user-attachments/assets/d4ead620-fb9e-458b-ab73-ac893ee182c7)
3.  **Spawn a Dragon**: A dragon will appear in the real world, anchored to the image.
<img width="1605" height="715" alt="image" src="https://github.com/user-attachments/assets/050ecdf4-e172-4a41-84d5-82c12ab5cc47" />

4.  **Control the Dragon**: Use the on-screen joystick to move the dragon around your environment.
<img width="1618" height="725" alt="image" src="https://github.com/user-attachments/assets/a5358994-0ed1-482f-9807-67d36f4e29c0" />

5.  **Explore**: Interact with different dragons and enjoy the immersive experience.

---

## 🤝 Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are **greatly appreciated**.

1.  Fork the Project
2.  Create your Feature Branch (`git checkout -b feature/AmazingFeature`)
3.  Commit your Changes (`git commit -m 'Add some AmazingFeature'`)
4.  Push to the Branch (`git push origin feature/AmazingFeature`)
5.  Open a Pull Request

---

## 📄 License

This project is distributed under the MIT License. See the `LICENSE` file for more information.

---

## 🙏 Acknowledgments

- Unity Technologies
- Google ARCore
- The creators of the "Four Evil Dragons HP" and "Joystick Pack" assets.

---

## 📞 Contact

Your Name - [your.email@example.com](mailto:your.email@example.com)

Project Link: [https://github.com/yourusername/ar-dragon-game](https://github.com/yourusername/ar-dragon-game)

---

⭐ **Star this repository if you found it helpful!**
