using System;

namespace Ucu.Poo.GameOfLife
{
    class Program//Clase que su responsabilidad es ejecutar el codigo llamando instancias al inicio y métodos infinitamente
    {
        static void Main(string[] args)//Metodo que ejecuta el codigo
        {
            Lector_Archivo lector = new Lector_Archivo();//Crea una instancia de Lector_Archivo
            Tablero tablero = new Tablero();//Crea una instancia de "Tablero"
            tablero.Crear_Tablero(lector);//Crea el tablero inicial con el archivo gracias al metodo de la clase "Lector_Archivo"
            Logica logica = new Logica(tablero);//Crea una nueva instancia de "Logica" con el tablero
            Imprimir imprimir = new Imprimir(tablero);//Crea una instancia con el constructor de la clase "Imprimir" y como parametro usa el tablero dado
            while (true)//Bucle infinito para mostrar el tablero en la consola cambiando de estado
            {
                imprimir.ImprimirTablero();//Imprime el estado del tablero
                logica.Jugar();//Aplica las reglas del juego al tablero
               
            }
            
        }
    }
}
