# `tequipo` Prueba de admisión 

## Explicación
El fin de esta prueba es evaluar tus capacidades de programación y resolución de problemas.


La actividad consiste en desarrollar:
- Dos rutas de API, una para obtener registros de una base de datos y otra para añadirlos.
- Dos páginas para interactuar con dichas rutas, una con una tabla para mostrar los registros y otra con un formulario para añadirlos.

## Conocimientos requeridos
- C# (ASP .NET Core y EntityFramework)
- Angular y las tecnologías web correspondientes (HTML, CSS y Typescript)

## Ejercicios

### 1. Backend
En la carpeta `backend` encontrarás un proyecto de C# y dentro del mismo una base de datos SQLite (`customers.db`). Esta base de datos consiste de una única tabla (`Customers`) que tiene una lista de clientes.

Sobre el controlador existente (`CustomerController`) es necesario desarrollar dos rutas:

- `GET /customers`: Esta ruta debe obtener los clientes de la base de datos y devolverlos en formato JSON. No es necesario realizar ningún tipo de filtrado ni paginado.
- `POST /customers/add`: Esta ruta debe recibir un cliente en formato JSON y guardarlo en la base de datos. Es necesario realizar comprobaciones básicas controlando posibles errores que puedan ocurrir en el proceso de guardado. 

### 2. Frontend
En la carpeta `frontend` encontrarás un proyecto de Angular. Sobre este debes añadir dos páginas y sus respectivas rutas:

- `/customers`: Esta página debe obtener la lista de clientes del backend y mostrarla por completo en una tabla.
- `/customers/add`: Esta página debe contener un formulario que permita rellenar los datos de un cliente y enviarlos al backend para que sean añadidos a la base de datos. Dicho formulario debe tener validaciones para los campos. Además es recomendable informar del resultado de la inserción (con un simple `alert()` vale).

> [!NOTE]
> Dentro de la carpeta `src/app/types` puedes encontrar el tipo correspondiente a la entidad `Customer` del backend

> [!NOTE]
> El proyecto tiene un proxy configurado de manera que puedes usar **/api/\<ruta\>** para contactar con el backend.

> [!WARNING] 
> Se desaconseja el uso de librerías o paquetes externos.