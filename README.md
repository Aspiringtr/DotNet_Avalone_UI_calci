# DotNet_Avalone_UI_calci 🧮

A simple cross-platform calculator built using **Avalonia UI** and **.NET**, designed as a learning project to explore desktop application development with a modern, platform-agnostic UI framework.

## 🚀 Features

- Basic arithmetic operations: addition, subtraction, multiplication, division
- Responsive UI using Avalonia XAML
- Cross-platform support (Windows, Linux, macOS)
- Clean MVVM-friendly structure (optional for future expansion)

## 🛠️ Built With

- [Avalonia UI](https://avaloniaui.net/) — Cross-platform .NET UI framework
- [.NET 7/8](https://dotnet.microsoft.com/) — Modern, fast, and open-source development platform
- C# — Primary programming language

### Getting Started
## Linux
# Using dotnet frame work 
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
# Using Wine
while using wine you just have to run the exe file inside the bin file **calculator.exe**
```
sudo apt install wine
wine yourapp.exe
```
