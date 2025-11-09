# MeteoSat Ground Station – WPF Data Visualization App

This repository contains the desktop application developed by the **MeteoSat CanSat Team** for the **European Space Agency CanSat Competition**.  
The application serves as the **ground station visualization software**, receiving telemetry data from the MeteoSat CanSat in real time via serial communication.

---

## 🛰️ Project Overview

The MeteoSat CanSat mission was designed to:
- Measure **temperature** and **atmospheric pressure** (primary mission)
- Monitor **smog-related gases** such as **CH₄ (methane)** and **CO (carbon monoxide)** (secondary mission)
- Record and visualize **flight path**, **altitude**, and **rotation** during descent

---

## ⚙️ Technologies Used

- **C# / .NET (WPF)**
- **LiveCharts** – for real-time graphs and telemetry charts  
- **NetDock.WPF** (modified) – for modular docking interface ([GitHub repo](https://github.com/felbsn/NetDock.WPF))
- **SerialUSB** communication via Arduino and CanSat boards

---

## 🧩 Architecture Overview

```
CanSat → Radio Transmitter → Ground Antennas (Yagi + X50N)
                            ↓                            
                Arduino M0 / CanSat Board
                            ↓
                  SerialUSB Data Stream
                            ↓
         WPF Visualization App (this repository)        
                            ↓
      Live telemetry + GNSS path + database logging
```

---

## 📈 Main Functionalities

| Functionality | Description | Done |
|-------------|-------------|-------------|
| **Data Reception** | Receives serial data from serial port | &check; |
| **Windows docking** | A modern window docking system | &check; |
| **Telemetry Visualization** | Displays live sensor readings (temperature, pressure, gas levels) | &cross; |
| **GNSS Path Tracking** | Visualizes CanSat’s flight path on a map | &cross; |
| **Rotation Visualization** | Shows rotation and orientation from IMU data | &cross; |
| **Database Logging** | Saves telemetry data for later analysis | &cross; |

---

## 🚀 Usage

### Prerequisites
- Windows 10/11
- .NET 8.0 SDK or newer
- Two serial devices connected (Arduino M0 + CanSat Kit board)
- Properly configured COM ports

### Running the Application
1. Clone the repository  
   ```bash
   git clone https://github.com/<your-repo>/MeteoSat-GroundStation.git
   ```
2. Open the project in **Visual Studio**  
3. Build and run the application  
4. Select the available COM ports  
5. Press **Start Telemetry** to begin live visualization

---
