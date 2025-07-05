# 🧮 DotNet Avalonia UI Calculator

A sleek, cross-platform calculator built using **Avalonia UI** and **.NET**, designed as a learning project to explore desktop application development with a modern, platform-agnostic UI framework.


## 🚀 Features

- ✏️ Basic arithmetic operations: Add ➕, Subtract ➖, Multiply ✖️, Divide ➗  
- 📱 Responsive UI built with Avalonia XAML  
- 💻 Works on Windows, Linux, and macOS  
- 🧠 Clean architecture, MVVM-ready (expandable for future features)


## 📸 Preview

![sample](https://github.com/Aspiringtr/DotNet_Avalone_UI_calci/blob/master/Asserts/images/sample.png)

## 🛠️ Built With

- [Avalonia UI](https://avaloniaui.net/) - Modern cross-platform .NET UI framework  
- [.NET 7/8](https://dotnet.microsoft.com/) - Fast and open-source developer platform  
- **C#** - The primary language powering the app


## ⚙️ Installation & Usage

### 🐧 Linux

#### ✅ Using .NET SDK

1. Install .NET 8 SDK:
   ```bash
   wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
   sudo dpkg -i packages-microsoft-prod.deb
   sudo apt update
   sudo apt install -y dotnet-sdk-8.0
2. Navigate to the project directory and run:
   ```bash
   dotnet run

### 🍷 Using Wine

1. Install Wine:
   ```bash
   sudo apt install wine
2. Run the executable (located in bin/Debug/net8.0/):
   ```bash
   wine Calculator.exe

### 🪟 Windows

#### ✅ Using .NET & Visual Studio

- Install [Avalonia for Visual Studio](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaVS)
- Open the solution in Visual Studio and build/run the project

#### 🚀 Direct Execution

- Navigate to `bin/Debug/net8.0/`
- Run `Calculator.exe` to launch the application

---

