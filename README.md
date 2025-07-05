# DotNet_Avalone_UI_calci 🧮

A simple cross-platform calculator built using **Avalonia UI** and **.NET**, designed as a learning project to explore desktop application development with a modern, platform-agnostic UI framework.

## 🚀 Features

- Basic arithmetic operations: addition, subtraction, multiplication, division
- Responsive UI using Avalonia XAML
- Cross-platform support (Windows, Linux, macOS)
- Clean MVVM-friendly structure (optional for future expansion)

## Sample 
![sample](https://github.com/Aspiringtr/DotNet_Avalone_UI_calci/blob/master/Asserts/images/sample.png)
## 🛠️ Built With

- [Avalonia UI](https://avaloniaui.net/) — Cross-platform .NET UI framework
- [.NET 7/8](https://dotnet.microsoft.com/) — Modern, fast, and open-source development platform
- C# — Primary programming language

# Installation
## Linux
### Using dotnet frame work 
run the following command to install the dotnet frame work to construct the built and run it
```
wget https://packages.microsoft.com/config/ubuntu/22.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo apt install -y dotnet-sdk-8.0  
sudo dpkg -i packages-microsoft-prod.deb
sudo apt update
```
once installed go to the file directory and run the following command
```
dotnet run
```
### Using Wine
while using wine you just have to run the exe file inside the bin file **calculator.exe**
```
sudo apt install wine
wine yourapp.exe
```
## Windows
### Using dotnet frame work 
Download the visual studio code extension and use the Avalonia UI frame work 
[Link](https://marketplace.visualstudio.com/items?itemName=AvaloniaTeam.AvaloniaVS)
### Direct execution 
Navigate to bin -> Debug -> net8.0 and run the **Calculator.exe** to run the application on windows
