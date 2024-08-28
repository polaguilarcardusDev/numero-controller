# 📞 Numero Controller API

Este es un proyecto de API RESTful desarrollado en ASP.NET Core 7.0. La API permite enviar un número a través de una solicitud POST y devuelve ese número incrementado en 1. El proyecto también incluye la configuración de Swagger para facilitar las pruebas locales.

## 🛠️ Requisitos Previos

- 🟢 .NET 7.0 SDK
- 🖥️ Visual Studio 2022 (o superior) o cualquier otro entorno compatible con .NET
- 🛠️ Git (para clonar el repositorio, si es necesario)

🧪 Ejemplos de Prueba en Swagger

- Abre Swagger UI en tu navegador (normalmente en http://localhost:5000/ o https://localhost:5001/).
- En Swagger UI, busca el endpoint POST /api/Numero/Incrementar.
- Haz clic en "Try it out", introduce un número en el cuerpo de la solicitud y presiona "Execute".
- La respuesta mostrará el número incrementado en 1.

▶️ Ejecutar el Proyecto

- Presiona F5 en Visual Studio para ejecutar la aplicación en modo Desarrollo.
- Una vez que la aplicación esté corriendo, Swagger UI debería abrirse automáticamente en tu navegador en http://localhost:5000/ o https://localhost:5001/.

🚀 Uso de la API

🔢 Endpoint para Incrementar un Número

- URL: /api/Numero/Incrementar
- Método HTTP: POST
- Descripción: Recibe un número y devuelve ese número incrementado en 1.
