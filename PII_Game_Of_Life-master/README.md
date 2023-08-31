Tarjetas CRC:

Nombre: Board

Responsabilidades:

* Cargar un tablero de juego de un archivo de texto.
* Imprimir un tablero de juego en la consola.

Atributos:

* _board: Un array de booleans que representa el estado de cada celda en el tablero.
* _width: El ancho del tablero.
* _height: El alto del tablero.

Nombre: FileManager

Responsabilidades:

* Leer el contenido de un archivo de texto.
* Convertir el contenido de un archivo de texto en un array de booleans.
* Validar el contenido de un archivo de texto.

Atributos:

* _filename: El nombre del archivo de texto a leer.


Nombre: Program

Responsabilidades:

Crear una instancia de la clase FileManager.
Llamar al método LoadBoard() de la clase FileManager para cargar un tablero de juego.
Crear una instancia de la clase Board y pasarle el tablero de juego cargado como argumento al constructor.
Llamar al método Print() de la clase Board para imprimir el tablero de juego.
Implementar el ciclo de juego del juego de la vida.
Atributos:

_args: Los argumentos de la línea de comandos.

Ejecutar el programa.

Equipo: Rodrigo Perdomo, Fabricio Buzó, Matías Danten, Guillermo 
