# Parcia2
* **Titulo:** "CeliTruco" - aplicacion de simulacion de partida de truco entre dos jugadores.

* **Sobre mí:** Soy Rodrigo Fernandez Barbero, tengo 22 años,  estudiante de la carrera Tecnicatura superior en programacion. Llevo preogramando desde 2019 de manera casual haciendo cursos pequeños online, pero ahora decidi enfocarme en la programacion mas de lleno. 

* **Resumen:** La aplicacion que desarrolle es un juego de truco, en esta se simulan partidas de truco a tiempo real entro dos jugadores en una sala de juego. Son partidas a 15 puntos y el usuario de la aplicacion generara tantas mesas de juego como quiera. En esta se visualizara la partida y se obtendra un ganador. Tambien se podran ver estadisticas de partidas antiguas como tambien registrar nuevos jugadores para que jueguen.

* **Diagrama de clases:**

![image](https://photos.app.goo.gl/xK9NtoBygMVfu6qc7)



* **Justificacion técnica:** 
*

    Tema 1:
SQL:
El tema Sql, lo pense para guardar los datos de los jugadores, las mesas de juegos y estaditicas de partidas antiguas. Usando la base de datos traia los datos a la aplicacion para su uso, se puede saber si, en caso de registrar un jugador nuevo como uno que ya existe dara error, agregar y eliminar mesas de juego y guardar datos de partidas previas.
El tema me ayudo pra tener un registro de los datos que uso, establece un orden para que no se pierda ningun dato y este perdure en caso de algun error. Con el uso de las tablas pude ordenar la informacion y asi, al momento de usarla en la aplicacion, identificar facilmente el dato en la base de datos y poder traerlo al sistema.
Cada base de datos Sql tiene su clase para el manejo de datos, es decir, poder traer las tablas, agregar nueva información a las tablas, actualizar estado de jugadores de las tablas y gracias a las consultas parametrizadas poder hacer informes.

En clases y/o formularios: RegistrarJugador(para guardar jugador), Jugador(para obtener estado, el jugador en si, su nombre), MostrarPartida(para modificar datos del jugador), JugadorSql(para acceder a la informacion), PartidasJugadasSql(para obtener ultimos id y guardar datos) MesaDeJuegoSql(para usar sus datos).

Conclusión SQL:

Es una gran herramienta a la hora de manejar bases de datos ya que de manera sencilla uno puede acceder a la informacion, utilizarla y actualizarla a medida que se usa la aplicacion.


     Tema 2:
Excepciones:
Utilice el manejo de excepciones para controlar cualquier error en tiempo de ejecucion en cual cerraria la aplicacion.
Lo pense principalmente para las consultas con la base de datos SQL y a la hora de traer datos que estos no sean nulos, vacios u otro tipo de dato.
Me ayudo bastante a entender errores que lanzaban una excepcion ya que de manera escrita me decia que tipo de error era para el cual busque la solucion.

En clases y/o formularios: RegistrarJugador(para validar ingreso de datos), clases SQL(al momento de abrir conexiones), etc.

Conclusión Manejo de excepciones:

Gracias a los bloques try catch pude solucionar muchos errores de codigo que tenia y evitar que la aplicacion se cerrara. Es un gran metodo para evitar que ocurran situaciones que puedan perjudicar la experiencia del usuario que usa la aplicacion.

     Tema 3:
Unit Testing: 
El tema Unit Testing, lo implemente en un principio para testear los metodos que mas problemas me podian dar, luego antes de crear un metodo nuevo lo hacia a la par que lo testeaba para encontrar todos los posibles errores.
Lo pense para sacarme las dudas que tenia con el funcionamiento de algunos metodos y asi encontrarle la solucion.

En clases y/o formularios: Testeadora(se testan los metodos).

Conclusión Unit Testing: 

Es una gran herramienta para evitar posibles errores en el codigo y no tener que estar ejecutando todo un codigo entero para saber como funciona una parte de codigo, el cual podria ser un metodo de actualizar un valor, ahorrandome tiempo.

    Tema4: 

Generics:
Lo implemente en la clase serializadora, ya que al usarlo en el metodo que deserializa, este traera cualquier tipo de dato de un archivo, este metodo retornara un objeto generico en este caso lo use para traer una carta.
El archivo en cuestion no se sabe que dato retornara por lo que usar un generico es la mejor manera de ahorrar codigo.

En clases y/o formularios: Serializadora(para serializar/deserializar todo tipo de datos).

Conclusion Generics:
Utilizar un tipo generico por lo que entendi no sirve para ahorrar codigo y tiempo ya que se pueden hacer metodos que traigan cada uno un tipo de dato de un archivo o un solo metodo que traiga cualquier tipo de dato.

    Tema 5:
Serializacion:
Este tema va de la mano con el anterior ya que lo uso para guardar una mazo de cartas en un archivo Xml (asignandole a cada carta un valor distinto para que se entienda cual es mejor que otra).
Este archivo es el que luego deserializo para crear el mazo y tener todo ordenado. Los datos en el archivo se guardan en una lista de cartas.

En clases y/o formularios: UnitTest(para verificar si toma los datos), Truco(para traer el valor de las cartas y pasarlas al mazo).


Conclusion serializacion:
Es algo que no habia entendido bien en el primer parcial pero aca le pude buscar la vuelta y entenderlo mejor. Nos permite guardar datos para luego utilizarlos en un futuro y que la informacion persista.

    Tema 6:
Escritura en archivos: 
Este tema lo pense como algo sencillo que guarda de manera facil el historial de las partidas, se crea un archivo.txt en el que se guarda la informacion de la partida.

En clases y/o formularios: MostrarPartida(para guardar los datos de la partida en un archivo al termina la partida).

Conclusion Escritura en archivos:
Es un metodo que se puede utilizar para guardar datos en un archivo no tan relevantes a los que se debe acceder de manera manual.

    Tema 7.
Interfaces: 
Lo pense como una forma de mostrar algo en todos los formularios, implemente una clase interfaz a la que cada formulario se suscribe y debe usarlo de manera obligatoria, en este caso es un mensaje de bienvenida a cada form. 

En clases y/o formularios: En cada formulario se utliza el metodo MostrarMensaje de la clase IMensajeFormulario

    Tema 8:
Delegados: 
Este tema se me complico aplicarlo y logre darle una logica de que al momento de crearse la sala se muestra la informacion de lo que esta ocurriendo en la misma a traves del metodo JugarPartida.
Use un delegado tipo action
Al usar los delegados le di delay a cada jugada para que parezca real, usando la clase Thread y luego el delegado que muestra los datos en un richtextbox.El método Invoke del delegado se utiliza para llamar a los métodos registrados en el delegado y pasarles los parámetros correspondientes. 

En clases y/o formularios: MostrarPartida(cuando se usa el delegado DelegadoCartas se invoca al metodo que muestra los datos de la partida), MesaDeJuego(invoca a metodos que suman los puntos de los jugadores o los acumulan o para mostrar un texto y para mostrar los datos de la partida en curso)

Conclusion Delegados:
Es un tema que me cuesta mucho ver en donde usarlos, pero al usarlos cada vez q queria llamar a un metodo que guarde los datos del jugador en la partida.

    Tema 9:
Task:
Utilice task para al momento de crear una partida este crea una tarea que ejecuta el método JugarUnaPartida en segundo plano, permitiendo que el programa principal continue ejecutandose y la partida se cree en un hilo aparte y al termina se eliminara. Se puede cancelar el hilo utilizando el boton cancelar partida que utilizara el cancellationToken para detener el hilo.

En clases y/o formularios: MostrarPartida(se crea el hilo en el que se va a jugar la partida y si se termina se utiliza para mostrar los resultados)

Conclusion Task:
Es la manera de manejar hilos permitiendo flexibilidad al programa.


    Tema 10:
Eventos: 
Este tema lo implemente de una forma básica.
Al disparar el evento se informara, en el caso de que un jugador ya exista, el nombre de dicho jugador con un messagebox.  


En clases y/o formularios: RegistrarJugador(para informar en el caso de que se haya introducido el mismo nombre de jugador).



****************
****************

Extra: Uso de Biblioteca externa Regex para validar numeros y letras.
