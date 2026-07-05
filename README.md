# 🛒 Ecommerce Blazor Project

Proyecto personal de e-commerce desarrollado con **C#, .NET (Core 10) y Blazor WebAssembly**, construido con una arquitectura por capas para practicar separación de responsabilidades, buenas prácticas de diseño y consumo de APIs REST desde un front-end en Blazor.

## 📌 Descripción

Este proyecto simula una plataforma de comercio electrónico, aplicando un diseño en capas que separa claramente la lógica de negocio, el acceso a datos y la interfaz de usuario. Fue creado como proyecto personal para reforzar experiencia con **.NET moderno (Core)**, más allá del .NET Framework utilizado en proyectos anteriores.

## 🏗️ Arquitectura

El proyecto está organizado en los siguientes módulos:

| Proyecto | Responsabilidad |
|---|---|
| `Ecommerce.API` | Exposición de endpoints REST (backend) |
| `Ecommerce.DTO` | Objetos de transferencia de datos entre capas |
| `Ecommerce.Model` | Entidades y modelos de dominio |
| `Ecommerce.Repositorio` | Acceso a datos y consultas a base de datos |
| `Ecommerce.Servicio` | Lógica de negocio |
| `Ecommerce.Utilidades` | Funciones y helpers compartidos |
| `Ecommerce.WebAssembly` | Front-end en Blazor WebAssembly |

## 🛠️ Tecnologías utilizadas

- **Backend:** C#, .NET (Core)
- **Front-end:** Blazor WebAssembly
- **Base de datos:** SQL Server (script incluido en `EcommerceDB.sql`)
- **Arquitectura:** Por capas (API - DTO - Model - Repositorio - Servicio)

## 🚀 Cómo ejecutar el proyecto

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/eduardo-marmolejo/Ecommerce_Blazor-Project.git
   ```
2. Restaurar la base de datos ejecutando el script `EcommerceDB.sql` en SQL Server.
3. Abrir `Ecommerce.slnx` con Visual Studio 2022 o superior.
4. Configurar la cadena de conexión a la base de datos en el proyecto `Ecommerce.API`.
5. Ejecutar el proyecto `Ecommerce.API` (backend) y `Ecommerce.WebAssembly` (front-end).

## 📄 Licencia

Este proyecto está bajo la licencia MIT. Ver el archivo [LICENSE](./LICENSE) para más detalles.

## 👤 Autor

**Eduardo Marmolejo Ornelas**
Ingeniero en Tecnologías de la Información | Software Developer
[LinkedIn](https://www.linkedin.com/in/eduardo-marmolejo-ornelas) · [Portafolio](https://myportafoliomarmolejodev.netlify.app/) · [GitHub](https://github.com/eduardo-marmolejo)
