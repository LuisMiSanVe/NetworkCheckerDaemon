> [Ver en ingles/See in english](https://github.com/LuisMiSanVe/NetworkCheckerDaemon/blob/main/README.md)
# <img src="https://github.com/LuisMiSanVe/NetworkCheckerDaemon/blob/main/NetworkCheckerDaemon/Resources/icon.ico" width="40" alt="NetworkCheckerDaemon Logo"> Demonio Comprobador de Red
[![image](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=csharp&logoColor=white)](https://dotnet.microsoft.com/en-us/languages/csharp)
[![image](https://img.shields.io/badge/.NET-5C2D91?style=for-the-badge&logo=.net&logoColor=white)](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
[![image](https://img.shields.io/badge/Visual_Studio-5C2D91?style=for-the-badge&logo=visual%20studio&logoColor=white)](https://visualstudio.microsoft.com/)

Programa Demonio en WinForms que corre en segundo plano que comprueba tu red y muestra información detallada.

## 📝 Explicación de Tecnología
El programa corre un comando `PING` para comprobar la accesibilidad de tu conexión.

Mientras está en ejecución, un Icono aparecerá en la sección de Iconos Ocultos de la Barra de Tareas, donde puedes comprobar, abrir una ventana con detalles o parar el proceso.

La dirección a la que ataca el `PING` es configurable, por defecto usa la IP del DNS de Google (8.8.8.8)

Cualquier problema de red o interrupción será notificada al usuario, con la opción de dejar de recibir estas notificaciones.

> [!IMPORTANT]
> Ten en cuenta que tenerlo de fondo todo el rato ejecutando comandos `PING` puede sobrecargar el tráfico de red, con la posible consecuencia que la dirección a la que ataca decida bloquear la conexión, por lo que debe usarse de forma periodica o puntual pero nunca constante.

## 🛠️ Instalación
Descarga el ejecutable desde los [Lanzamientos de Github](https://github.com/LuisMiSanVe/NetworkCheckerDaemon/releases) y ejecutalo.

## 🚀 Lanzamientos
Una versión será lanzada solo cuando se cumplan los siguientes puntos:\
Nuevas funciones importantes y arreglos de fallos criticos causarán la salida inmediata de una nueva versión, mientras que otros cambios/arreglos menores deberán esperar una semana desde que se incluyeron en el repositorio antes de ser incluidos en la nueva versión, para que otros posibles cambios puedan ser añadidos tambien.
>[!NOTE]
>Estos posibles nuevos cambios no alargarán la espera de la salida de la nueva versión a más de una semana.

El número de la versión seguirá este formato: \
\[Añadido Importante\].\[Añadido Menor\].\[Arreglos de Errores\]

## 💻 Tecnologías usadas
- Lenguaje de programación: [C#](https://dotnet.microsoft.com/en-us/languages/csharp)
- Framework: [.Net](https://dotnet.microsoft.com/en-us/learn/dotnet/what-is-dotnet)
  - [FreeIcons](https://freeicons.io/) (Images)
- IDE Recomendado: [Visual Studio](https://visualstudio.microsoft.com/) 
