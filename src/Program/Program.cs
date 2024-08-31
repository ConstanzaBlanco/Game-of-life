using System;

namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Lector_Archivo lector = new Lector_Archivo();
            Tablero tablero = new Tablero();
            tablero.Crear_Tablero(lector);
            Logica logica = new Logica(tablero);
            Imprimir imprimir = new Imprimir(tablero);
            while (true)
            {
                imprimir.ImprimirTablero();
                logica.Jugar();
               
            }
            
        }
    }
}
