# PermisosApp
Code Challenge .NET Core + Angular

FrontEnd 
* Desarrollado en Angular7
* Bootstrap + FontAwesome
* Routing de dos componentes
* Se conecta con la WebApi en .NET Core

Backend
* Arquitectura Clean, separada en 3 proyectos
* Infraestructura, con toda la capa de datos despegada del middleware y de la capa API
* Core, es el middleware de conexion entre la API y los datos, maneja Entidades propias 
* WepApi, esta desacoplado en services extensions
* Use Automapper, inyeccion de dependendencia nativa de Core, EF Core sin scafolding

Nota
Tiene varios enhancements para poder realizarle como por ejemplo manejar objetos personalizados en REQUEST Y RESPONSE para hacerlo mas limpio y aislado, 
pero no me dio el tiempo para implementarlo.


