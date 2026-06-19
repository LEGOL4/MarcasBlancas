# MarcasBlancas - Mini App Web

## Descripción
Esta es una mini aplicación web ASP.NET Core MVC diseñada para comparar marcas blancas de supermercados. Muestra un listado de productos de bajo costo y calidad garantizada, resaltando aquellos que pertenecen a marcas blancas.

## Tecnologías
- **ASP.NET Core 8.0 (MVC)**: Para el desarrollo del backend, controladores y vistas HTML dinámicas.
- **xUnit**: Framework de pruebas unitarias utilizado para validar la lógica del modelo `Producto`.
- **Jenkins**: Automatización de la integración y entrega continua (CI/CD) mediante un pipeline declarativo.

## Cómo ejecutar
Para ejecutar la aplicación localmente, navega a la carpeta del proyecto y ejecuta el comando de dotnet:

```bash
cd MarcasBlancas
dotnet run
```

Una vez que la aplicación se esté ejecutando, abre tu navegador y accede a:
[http://localhost:5000/Producto](http://localhost:5000/Producto) o la URL de desarrollo mostrada en tu terminal.

## Cómo testear
Para ejecutar las pruebas unitarias y verificar el correcto funcionamiento del modelo `Producto`, navega a la carpeta de pruebas y ejecuta:

```bash
cd MarcasBlancas.Tests
dotnet test
```

## Flujo CI/CD
El proyecto incluye un archivo `Jenkinsfile` configurado para automatizar el proceso de integración continua en Jenkins. El pipeline incluye los siguientes stages:
1. **Clonar**: Simula la descarga del repositorio del código.
2. **Restaurar**: Restaura las dependencias de NuGet del proyecto web.
3. **Compilar**: Compila el proyecto en modo `Release`.
4. **Pruebas**: Ejecuta las pruebas unitarias automáticas con xUnit.
5. **Publicar**: Empaqueta y publica el artefacto de la aplicación en la carpeta `./publish`.
