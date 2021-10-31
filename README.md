# Título 

**CibercafeElVicio**

***Hecho por Tomás Friz***

*UTNFra Laboratorio de Computación II - Primer Parcial - Comisión 2do D - 2do cuatrimestre 2021*

[Enunciado del parcial](https://codeutnfra.github.io/programacion_2_laboratorio_2_apuntes/docs/evaluaciones/parciales/2d-primer-parcial/)

___
## Sobre mí

- Hola soy Tomás Agustin Friz y tengo 22 años. 
- Sali de la secundaria y directo a la facultad.
- Durante estos años e hecho muchos cursos tantos virtuales como presenciales, para ampliar mis conocimientos.
- Este parcial fue muy dificil y un dolor de cabeza, pero me gusto la experiencia y fue un gran desafio.
- Si se pudiera hacer algo similar para el parcial 2 pero mas corto y 1 mes para hacerlo, estaria piola.

___
## Resumen

Este programa esta hecho para un cibercafe ,  que sirve para ver la lista de clientes en espera y asignarles una computadora  con las especificaciones que quieren o un telefono. 
Tambien se vera  con colores las computadoras y telefonos  libres o en uso por algun cliente(*rojo* si esta en uso y *verde* si esta libre).  
Tocando sobre  el cuadrito de color del equipo (tiene que ser de color rojo porque no hara nada si esta en verde) podemos desconectar al cliente y cobrar el servicio dado al mismo.
Tambien podemos  ver el historial y mostrar el mismo con diferentes opciones.
En resumen, es un programa de administracion para un cibercafe de los años 2000 y solo es de uso exclusivo del pibe del cibercafe.
Espero que le sea de su agrado.
___
## Diagrama de clases

![DiagramaDelCibercafe](https://user-images.githubusercontent.com/36195779/139595947-8ddc097f-248d-4a61-89cf-d9c6b534ac3f.png)

![DiagramaDeEntidades](https://user-images.githubusercontent.com/36195779/139595958-36c8adf0-4424-40a8-9b87-3b92a7142b9f.png)

___
## Justificación técnica

### Clase 1 -  Introducción a .NET y C #
La aplicación está desarollada en el lenguaje C # utilizando el IDE de core 5.0 de Visual Studio 2019, respetando las reglas de estilo establecidas en la cátedra. También se han documentado las clases y sus miembros con la herramienta de documentación xml.

### Clase 2 - Clases y métodos estáticos
Se utilizó la clase estática Usuario, ya que por la naturaleza de la aplicación no es necesario crear una instancia de la misma. En esta clase se manejan las relaciones entre distintos objetos y clases con relacion al funcionamiento del cibercafe. Todos los métodos y atributos de esa clase son estáticos.

### Clase 3 - Programación orientada a objetos
El proyecto está diseñado bajo el paradigma de la Programación Orientada a Objetos:
- Abstracción: Se identicaron entidades en base a las necesidades del cliente, se destacaron sus características más relevantes y se descartaron características no relevantes para la lógica de negocios.
- Encapsulamiento: Se ocultaron los detalles de la implementación, pudiendo acceder a los atributos solamente a traves de propiedades o métodos.
- Herencia: Se buscaron características y comportaminetos en común y se crearon clases más especializadas a partir de clases más generales.
- Polimorfismo: Se utiliza el poliformismo en el método OrdenamientoDecendenteTiempo(). Si bien solo manejamos variables de tipo Equipo, cuando en tiempo de ejecución el tipo del objeto sea Telefono, se van a mostrar los telefonos con su correspondiente implementación del método ToString() y cuando se trate de Computadora se va a llamar al implementación de ToString() de esa clase.

### Clase 4 - Sobrecarga
- Sobrecarga de métodos: Se aplica la sobrecarga del método RevisarRequisitos() de la clase Usuario. Así se le puede pasar por parámetro tanto un juego, un software o un periferico, y devuelve un booleano indicando si está disponible en esa instancia o no.
- Sobrecarga de constructores: La clase Computadora tiene una sobrecarga de constructor: En el primero, que es privado, no se reciben parámetros y se crean las listas de juegos, perifericos y software, así como el diccionario de especificaciones de hardware. En el segundo constructor, que llama al primero a través de: this (), se reciben todos esos atributos como parámetros.
- Sobrecarga de operadores: En todas las jerarquías de herencia se utiliza la sobrecarga del operador de igualdad y su opuesto para redefinir su comportamiento al comparar dos objetos.

### Clase 5 - Formularios de Windows
La aplicación es un proyecto de Windows Forms, el cual nos brinda un entorno gráfico para que sea más amigable para el usuario. Para ello, se separó físicamente la capa de presentación que es(Cibercafe_ElVicio) de la lógica de negocio que es(Entidades).
Para ello se utiliza todo tipo de controles y eventos:
- Se eligió un Listbox para visualizar la lista de clientes en espera y para cargar los datos de los clientes en el FrmComputadoras y FrmTelefonos.
- Se utilizó un ComboBox para mostrar y seleccionar los puestos disponibles, y se fijó su propiedad DropdownList en DropDownStyle, para que no se puedan ingresar nuevos valores o modificar esos valores. Luego se busca la opción seleccionada con un foreach().
- Se usaron RadioButton para seleccionar el tipo de tiempo(Tiempo ilimitado o Tiempo limatado), ya que solo se debe poder seleccionarse una, y se selecciona la opción tiempo ilimitado por defecto para que no exista la opción de no seleccionar el tiempo limite.
- Si selecciona la opción Tiempo Limitado, se muestra un NumericUpDown, para ingresar el tiempo solicitado en minutos. El valor mínimo inciial es 30. Seleccionandolo con las flechas solo pueden ingresar múltiplos de 30. No se ingresara manualmente otro valor ya que estara controlado y bloqueado.

### Clase 6 - Colecciones
Se utilizan colecciones genéricas: List, Diccionary, Queue.
- Las List se usaron para listar perifericos, juegos y software, para registrar los servicios de un equipo y los equipos del usuario. Se usó este tipo de colección porque no es necesario asignar una clave pero si es necesario poder acceder a los elementos con un foreach o un índice.
- El Diccionary se utilizó para las especificaciones del hardware, ya que se necesita asociar una clave (especificación) a un valor. Habrá una sola específicacion de cada tipo y va a tener un solo valor.
- Se usó un Queue para los clientes en espera, ya que siempre el próximo cliente en ser seleccionado va a ser el que llegó antes (orden FIFO), y hasta que no terminemos con ese cliente no trabajaramos con el resto.

### Clase 7 - Encapsulamiento
Los atributos se encuentran ocultos (privada/protegida), solo pudiendo acceder a ellos a través de propiedades tanto de lectura como de lectura/escritura. Tambien se oculta la implementación de algunos métodos que son de uso interno de la clase.
- Enumerados: Se utilizan diversos enumerados para definir los valores que le podemos dar a un atributo, los cuales están declarados en una clase de codigo vacio.

### Clase 8 - Herencia
- Herencia de clases:
En el proyecto se heredan varias clases, que tienen una relación semántica con la clase base. EJ: las clases de Computadora y Telefono comparten varias carácterísticas como id, estado y lista de servicios y métodos como CalcularMinutos() , por lo que heredan de la clase Equipo. Lo mismo ocurre con las clase de ClienteComputadora y ClienteTelefono, que son tipos de Servicio, sobre los cuales podemos calcular el costo y agregarle IVA.

### Clase 9 - Polimorfismo y clases abstractas
Poliformismo Se utiliza el poliformismo en el método OrdenamientoDecendenteTiempo(). Si bien solo manejamos variables de tipo Equipo, cuando en tiempo de ejecución el tipo del objeto sea Telefono, se van a mostrar los telefonos con su correspondiente implementación del método ToString() y cuando se trate de Computadoras, se va a llamar a la implementación de ToString() de esa clase.
- Clases abstractas: Se utilizan dos clases abstractas: Equipo y Servicio. Estas clases no tienen utilidad sin las características que se asignan en sus clases derivadas, por lo que no deben poder instanciarse. Contienen tanto métodos abstractos como métodos que son implementados por las clases derivadas y métodos no abstractos, que son utilizados por estas.
- Clases selladas: ClienteComputadora, ClienteTelefono, Computadora y Telefono son clases selladas. No se debe poder heredar de ellas, ya que contienen toda la información e implementación necesaria para su funcionamiento.

___
## Propuesta de valor agregado

### Instalacion y uso de 2 paquetes nuget:

- El paquete **FluentValidation** que es un paquete muy popular de validaciones, con llamados de errores, validar la cantidad con un valor minimo y un valor maximo, validar que los numeros sean enteros y evitar que el campo se nulo.  
Este paquete se usa en la validacion de la llamada para el ingreso del codigo, localidad y numero telefonico cuando el cliente va a marcar los numeros para llamar.
[Como usar FluentValidation](https://enmilocalfunciona.io/valida-tu-modelo-de-datos-con-fluentvalidation-en-c/)
[Donde descargarlo](https://fluentvalidation.net/)
- El  paquete **FontAwesome.Sharp** que es un paquete de diseño para colocar iconos en los botones y en imagenes. Lo uso para darle un poco de estilo a los botones de ayuda del form.
[Como usar FontAwesome.Sharp](https://www.youtube.com/watch?v=K2lgEPdhGcg)
[Donde descargarlo](https://www.nuget.org/packages/FontAwesome.Sharp/)

### Agregado de promoción:
- Agregue como funcionalidad de promoción la selección de aperitivos en el sector de facturacion.
El pibe del cibercafe le marcara en el check correspondiente la bebida y/o comida que pidio el cliente y se le sumara al costo del tiempo de uso del equipo que utilizo el cliente.

### Posibles defectos:
- Como las especificaciones del cliente son aleatorias posiblemente ocurra que no halla una computadora para el mismo.
Se puede dar el caso si se desconecta un cliente diferente y ese cliente en espera lo puede ocupar, pero si no cumple las especificaciones del mismo, la cola de clientes se detendra.

___
