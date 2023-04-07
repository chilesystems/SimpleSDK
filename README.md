# SimpleSDK .NET

SDK para la integración con el Servicio de Impuestos Internos, Chile. 

SimpleSDK es una solución realizada en C# y puede ser consumida desde cualquier lenguaje compatabible con .NET Standard 2.0, 
consta de una completa biblioteca de clases que permiten realizar todas las operaciones permitidas por el SII respecto a la generación,
timbre, firma y envío de DTE al Servicio de Impuestos Internos. 

Permite generar todos los documentos electrónicos disponibles en el SII y actuar en ambiente de certificación o de producción.

## Requisitos:
 - Target compatible con .NET Standard 2.0

## Dependencias
Al realizar la instalación con NuGet las dependencias
debieran instalarse automáticamente.

- [Newtonsoft 13.0.1](https://www.newtonsoft.com/json)
- [NETStandard.Library 2.0.3](https://dotnet.microsoft.com/)

## Instalación

### Instalar con NuGet

Desde una línea de comandos:

```bash
nuget install SimpleSDK
```

Desde Package Manager:

```bash
PM> Install-Package SimpleSDK
```

Con .Net CLI:

```bash
dotnet add package SimpleSDK
```

Desde Visual Studio:

1. Abrir el explorador de soluciones.
2. Clic derecho en un proyecto dentro de tu solución.
3. Clic en Administrar paquetes NuGet.
4. Clic en la pestaña Examinar y busque `SimpleSDK`
5. Clic en el paquete `SimpleSDK`, seleccione la versión que desea utilizar y finalmente selecciones instalar.

## Documentación 

Puedes encontrar toda la documentación de cómo usar este SDK en el sitio https://www.simple-api.cl.

La documentación relevante para usar este SDK es:

- Documentación general:
  [Sitio Simple API](https://www.simpleapi.cl/Productos/SDK) y
  [Proyecto Demo](https://www.simpleapi.cl/Documentacion/Demostracion).
- Canal de Youtube con [ejemplos, explicaciones y tutoriales](https://www.youtube.com/playlist?list=PLA3lqxJkDQaZWAiEmWA8m7YxuNCn1ZVe9).
