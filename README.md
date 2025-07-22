# 🐉 AR Dragon Game

An immersive **Augmented Reality (AR) dragon game** built with Unity and ARCore that brings mythical dragons to life in your real world environment.

![AR Dragon Game](Screenshot%202024-10-05%20180430.jpg)

## 🌟 Features

### 🎮 Core Gameplay
- **AR Image Tracking**: Dragons spawn when the camera detects specific reference images
- **Touch Controls**: Intuitive joystick-based movement system for mobile devices
- **Real-time Interaction**: Control dragons in real-world space with smooth physics-based movement

### 🐲 Dragon Collection
- **4 Unique Dragon Types**:
  - **Dragon Nightmare** - Albino, Blue variants
  - **Dragon Soul Eater** - Blue, Green variants  
  - **Dragon Terror Bringer** - Blue, Green variants
  - **Dragon Usurper** - Blue, Green variants

### 🎭 Rich Animations
Each dragon features comprehensive animation sets:
- **Movement**: Walk, Run, Jump, Fly
- **Combat**: Basic Attack, Claw Attack, Horn Attack, Tail Attack, Flame Attack
- **Defense**: Defend, Get Hit
- **Behavior**: Idle, Sleep, Scream, Die
- **Flight**: Take Off, Land, Fly Float, Fly Forward, Fly Glide (Soul Eater)

### 🎨 Visual Features
- **Multiple Color Variants** for each dragon type
- **High-quality 3D Models** with detailed textures
- **Smooth Animation Controllers** with state management
- **AR-optimized Rendering** for mobile performance

## 🛠️ Technical Stack

### Core Technologies
- **Unity 2022.3 LTS** - Game engine
- **ARCore 5.1.5** - Android AR framework
- **AR Foundation 5.1.5** - Cross-platform AR framework
- **C#** - Programming language

### Key Dependencies
- `com.unity.xr.arcore` - ARCore integration
- `com.unity.xr.arfoundation` - AR Foundation framework
- `com.unity.textmeshpro` - Text rendering
- `com.unity.timeline` - Animation timeline
- `com.unity.ugui` - UI system

### Third-party Assets
- **Joystick Pack** - Mobile touch controls
- **Four Evil Dragons HP** - Complete dragon asset pack

## 🚀 Getting Started

### Prerequisites
- Unity 2022.3 LTS or later
- Android device with ARCore support
- Android SDK and build tools

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/yourusername/ar-dragon-game.git
   cd ar-dragon-game
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Add the project folder
   - Open with Unity 2022.3 LTS

3. **Build for Android**
   - Go to `File > Build Settings`
   - Select Android platform
   - Configure player settings for AR
   - Build and install on ARCore-compatible device

### Setup Instructions

1. **Configure AR Image Tracking**
   - Add reference images to the AR Image Library
   - Configure tracking settings in AR Tracked Image Manager

2. **Test on Device**
   - Install the APK on your Android device
   - Point camera at reference images to spawn dragons
   - Use joystick to control dragon movement

## 📁 Project Structure

```
Assets/
├── Scripts/
│   ├── DrogonController.cs      # Dragon movement and control
│   └── PrefabCreator.cs         # AR dragon spawning system
├── FourEvilDragonsHP/
│   ├── Animations/              # Dragon animation files
│   ├── Animators/               # Animation controllers
│   ├── Materials/               # Dragon materials and shaders
│   ├── Mesh/                    # 3D dragon models
│   ├── Prefab/                  # Dragon prefabs
│   └── Texture/                 # Dragon textures
├── Joystick Pack/               # Mobile control system
├── Scenes/
│   └── GameScene.unity         # Main game scene
└── XR/                         # AR configuration
```

## 🎯 Core Scripts

### DrogonController.cs
Handles dragon movement and control:
- Joystick input processing
- Physics-based movement with smooth interpolation
- Rotation and orientation control
- Configurable speed and sensitivity settings

### PrefabCreator.cs
Manages AR dragon spawning:
- AR image tracking integration
- Automatic dragon instantiation
- Transform positioning and offset handling

## 📱 Mobile Controls

- **Joystick Movement**: Drag joystick to move dragon
- **Smooth Rotation**: Dragon automatically faces movement direction
- **Physics-based**: Realistic movement with momentum and smoothing

## 🔧 Configuration

### Dragon Settings
- Adjustable movement speed and rotation speed
- Configurable movement smoothing
- Physics parameters for realistic behavior

### AR Settings
- Image tracking sensitivity
- Spawn offset positioning
- Performance optimization settings

## 🎮 Gameplay

1. **Launch the app** on your ARCore-compatible Android device
2. **Point camera** at reference images to spawn dragons
3. **Use joystick** to control dragon movement and rotation
4. **Explore** different dragon types and animations
5. **Interact** with dragons in your real environment

## 📸 Screenshots

![Gameplay Screenshot](Screenshot%202024-10-05%20180430.jpg)

## 🤝 Contributing

1. Fork the repository
2. Create a feature branch (`git checkout -b feature/amazing-feature`)
3. Commit your changes (`git commit -m 'Add amazing feature'`)
4. Push to the branch (`git push origin feature/amazing-feature`)
5. Open a Pull Request

## 📄 License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

## 🙏 Acknowledgments

- **Unity Technologies** for the game engine and AR Foundation
- **Google ARCore** for Android AR capabilities
- **Four Evil Dragons HP** asset pack creators
- **Joystick Pack** developers for mobile controls

## 📞 Contact

- **Project Link**: [https://github.com/yourusername/ar-dragon-game](https://github.com/yourusername/ar-dragon-game)
- **Issues**: [https://github.com/yourusername/ar-dragon-game/issues](https://github.com/yourusername/ar-dragon-game/issues)

---

⭐ **Star this repository if you found it helpful!**
