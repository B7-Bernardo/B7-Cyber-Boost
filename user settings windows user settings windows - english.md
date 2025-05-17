---

## ⚙️ **Windows Settings – B7 Cyber Boost Guide**

### 🧠 Smart Automated Settings

All optimizations are applied automatically, with no need for manual tweaking.

The program analyzes your system specs — such as RAM size, GPU model, processor type, and more — and based on that data, selects and applies the most suitable adjustments.

✅ Just click the desired configuration button, and the system will automatically choose the best parameters for your PC.

---

## 🔻 Task (Service) Disabling

### 🎯 Objective:

Improve overall performance by disabling Windows services considered unnecessary for most users.

### 📋 Suggested services to disable:

| Service                                    | Function                                                           |
| ------------------------------------------ | ------------------------------------------------------------------ |
| `diagnosticshub.standardcollector.service` | Collects diagnostic data from the system.                          |
| `DiagTrack`                                | Telemetry and usage tracking.                                      |
| `dmwappushservice`                         | Microsoft push message support.                                    |
| `lfsvc`                                    | Geolocation service.                                               |
| `MapsBroker`                               | Manages offline maps.                                              |
| `NetTcpPortSharing`                        | TCP port sharing.                                                  |
| `RemoteAccess`                             | VPN and remote access support.                                     |
| `RemoteRegistry`                           | Allows remote editing of Windows Registry.                         |
| `SharedAccess`                             | Internet connection sharing.                                       |
| `WbioSrvc`                                 | Biometric authentication support.                                  |
| `WMPNetworkSvc`                            | Media sharing with other devices on the network.                   |
| `XblAuthManager`                           | Xbox Live authentication.                                          |
| `XblGameSave`                              | Xbox game save synchronization.                                    |
| `XboxNetApiSvc`                            | Xbox Live networking.                                              |
| `ndu`                                      | Network data usage monitor.                                        |
| `SysMain` *(Superfetch)*                   | App preloading in RAM. Potential security risk.                    |
| `TeamViewer`                               | Remote control. May run in background and contain vulnerabilities. |

### ⚠️ Why disable *TeamViewer*?

* **Security:** History of security flaws.
* **Performance:** Can consume CPU/RAM even when idle.
* **Privacy:** Prevents unauthorized remote access.

### ⚠️ Why disable *SysMain*?

* **Privacy/Security:** Previously linked to malware reinstalls (*Source: Kaspersky*).
* **Performance:** Questionable performance gain on SSD-equipped systems.

---

## 🎮 Disable Game Bar

### 🧩 Reasons to disable the Game Bar:

* **Performance:** May cause stuttering or FPS drops.
* **Compatibility:** Conflicts with third-party recording tools.
* **Optimization:** Frees system resources.
* **Stability:** Tests show reduced bugs and crashes in games.

**✅ Recommended to disable if not actively used.**

---

## 📉 Disable Telemetry

### 📌 What it is and why disable it:

* **Resource usage:** Some telemetry processes consume CPU and disk.
* **Privacy:** Limits the data sent to Microsoft.
* **Performance:** Reduces background processes.

> ℹ️ *Note:* Telemetry also provides benefits like system improvements based on real-world data. The goal here is to optimize without fully disabling it.

**🛠️ The B7 Cyber Boost tool applies balanced adjustments for both performance and privacy.**

---

## 🚀 Performance Optimizations

### 🔧 What's included:

* **Fine-tuning of the operating system.**
* **Advanced commands for supporters.**
* **Focus on responsiveness and stability.**

Explore these options to boost Windows' overall responsiveness.

---

## 🧠 Latency Reduction (Parts 1 & 2)

### 🎯 Benefits:

* **Lower overall response time.**
* **Ideal for gamers, audio producers, and power users.**
* **Extra commands available for supporters, with full documentation.**

**Use this function to ensure maximum performance in latency-sensitive tasks.**

---

## ⚡ Faster Menu Navigation

### 🪄 Optimize Windows navigation:

* **Removes delays from menus and animations.**
* **Speeds up menus, Explorer, and even in-game HUDs.**

### 🛠️ Applied tweaks:

1. **Remove menu delay:**

   ```csharp
   Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "MenuShowDelay", "0");
   ```
2. **Disable system animations:**

   ```csharp
   Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "DragFullWindows", "0");
   Registry.SetValue("HKEY_CURRENT_USER\\Control Panel\\Desktop", "UserPreferencesMask", "0");
   ```

> ✨ *Other advanced tweaks are automatically applied for supporters.*

---

## 🧠 CPU Core Parking

### 🔍 What is it?

Core Parking disables idle CPU cores to save power, but this can cause:

* **Performance loss in games.**
* **Stuttering in high-demand applications.**

### 🛠️ What B7 Cyber Boost does:

* Adjusts the power plan to prevent core parking.
* Ensures all cores stay active under load.
* Offers more control for advanced users (optional).

---

## 🔧 Windows Update

### Windows Update in B7 Cyber Boost:

🔍 This feature of B7 Cyber Boost **does not disable** Windows Updates, as they are essential for security and proper system operation.

* **Removes Delivery Optimization:** Disables sharing updates with other PCs on the network, reducing risk if infected.
* **Blocks notifications:** Prevents annoying “Updates available” messages.

In short, the Windows Update function in B7 Cyber Boost focuses on security and avoiding interruptions, keeping your system updated directly from Microsoft without intrusive notifications.

---
