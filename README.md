https://zero907-23-18808finalanalisis1danilo.onrender.com





PROMTS ENVIADOS PARA LA IA:
Prompt: "Este examen hazlo paso a paso para que todo salga bien, sin que ocurra error, 
la base de datos la vamos hacer usando postgres, levantarla con docker, Y empezar a trabajar."

Lo que hizo la IA: Generó un plan general dividido en 8 pasos, desde las historias de usuario hasta el deploy en Render.com.
2. Historias de usuario

Prompt: "Si en orden please"

Lo que hizo la IA: Generó 11 historias de usuario con formato estándar (Como, Quiero, Para)
incluyendo criterios de aceptación para cada una, cubriendo los roles de Administrador, Técnico y Sistema.


3. Estructura del proyecto

Prompt: "El proyecto ya lo tengo creado en visual studio estoy solo para pegar codigo"

Lo que hizo la IA: Adaptó los pasos al entorno ya existente, proporcionando el código para AppDbContext, appsettings.json y Program.cs listo para pegar.


4. Base de datos con Docker

Prompt: "Dame eso en una sola cadena"

Lo que hizo la IA: Generó el comando Docker en una sola línea para levantar PostgreSQL fácilmente desde terminal.


5. Modelos

Prompt: "Si paso 3"

Lo que hizo la IA: Generó los 4 modelos completos: Tecnico, Sitio, Incidente e HistorialIncidente con sus relaciones y propiedades, además de actualizar el AppDbContext con los DbSets correspondientes.


6. Controllers y Endpoints

Prompt: "Ya esta todo bien"

Lo que hizo la IA: Generó 3 controllers completos (TecnicosController, SitiosController, IncidentesController) con 12 endpoints implementando todas las reglas de negocio del examen.


7. Escalado automático

Prompt: "Si paso 3" (continuando el orden)

Lo que hizo la IA: Generó el EscaladoService como BackgroundService que revisa cada 5 minutos los incidentes 
Críticos o Urgentes con más de 2 horas en estado Registrado y los escala automáticamente.


8. Pruebas unitarias


Lo que hizo la IA: Generó 7 pruebas unitarias con xUnit usando base de datos InMemory para probar los controllers sin depender de la base de datos real.


9. Deploy

Prompt: "Para subirlo a render"

Lo que hizo la IA: Guió paso a paso la creación del Dockerfile, subida a GitHub y configuración del Web 
Service en Render.com incluyendo variables de entorno y base de datos PostgreSQL en la nube.


LO QUE HICE YO 

Crear el proyecto en Visual Studio 2022 como ASP.NET Core Web API
Instalar los paquetes NuGet necesarios desde el administrador de paquetes
Levantar  la base de datos PostgreSQL usando Docker desde la terminal
Conectar la base de datos en DBeaver y verificó las tablas creadas
Organizar las carpetas del proyecto (Controllers, Data, DTOs, Models, Services)
Pegar y revisar el código generado por la IA en cada archivo correspondiente
Ejecutar las migraciones desde la Package Manager Console
Corregir errores de versiones incompatibles de paquetes NuGet (net8.0 vs net9.0)
Crear el proyecto de pruebas xUnit y referenciar al proyecto principal
Ejecutar las pruebas unitarias y verificar que pasaran correctamente
Crear el repositorio en GitHub y subir el código
Configurar el deploy en Render.com conectando el repositorio y la base de datos en la nube
Crear el Dockerfile para el despliegue en contenedor
Elaboró el diagrama de flujo a mano en el cuadernillo del examen.


