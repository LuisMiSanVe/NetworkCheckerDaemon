> [See in spanish/Ver en español](https://github.com/LuisMiSanVe/NetworkCheckerDaemon/blob/main/README.es.md)
# <img src="https://github.com/LuisMiSanVe/NetworkCheckerDaemon/blob/main/NetworkCheckerDaemon/Resources/icon.ico" width="40" alt="NetworkCheckerDaemon Logo"> Network Checker Daemon
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

Daemon WinForms program that runs on the background checking your network and displaying detailed info about it.

## 📝 Technology Explanation
The program runs a `PING` command to check the accessibility of your network.

While is running, a System Tray Icon appears on the hidden icons section of the Taskbar, where you can monitor, open the detailed window or stop the process.

The host that the `PING` attacks is customizable, by default it uses Google's DNS IP (8.8.8.8)

Any network problem or disruption will be notified to the user, with the option to stop recieving these notifications.

## 🛠️ Setup
Download the executable from the [Github Releases](https://github.com/LuisMiSanVe/NetworkCheckerDaemon/releases) and add it to the Windows startup programs so it opens automaticly.

## 🚀 Releases
The version will be released using these versioning policies:\
New major features and critical bug fixes will cause the immediate release of a new version, while other minor changes or fixes will wait one week since the time the change is introduced in the repository before being included in the new version, so that other potential changes can be added.
>[!NOTE]
>These potencial new changes will not increase the wait time for the new version beyond one week.

The version number will follow this format: \
\[Major Feature\].\[Minor Feature\].\[Bug Fixes\]

## 💻 Technologies Used
- Programming Language: [C#](https://dotnet.microsoft.com/en-us/languages/csharp)
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
- Other:
  - [FreeIcons](https://freeicons.io/) (Images)
- Recommended IDE: [Visual Studio](https://visualstudio.microsoft.com/) 
