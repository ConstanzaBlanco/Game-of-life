namespace Ucu.Poo.GameOfLife;
using System; //Importa Console,String y Math
using System.Text;//Importa StringBuilder
using System.Threading;//Importa Thread y Thread.Sleep

public class Imprimir//Clase que su responsabilidad es imprimir el tablero en la consola
{
    private Tablero tablero;//Atributo privado que almacena el tablero

    public Imprimir(Tablero tablero)//Constructor que usa como parametro una instancia de tablero
    {
        this.tablero = tablero;//Asigna la instancia al atributo privado tablero
    }

    public void ImprimirTablero()//Metodo para imprimir el tablero en la consola
    {
        Console.Clear();//Borra la consola
        Console.WriteLine("\x1b[3J");
        StringBuilder s = new StringBuilder();//Crea una nueva instancia de la clase "StringBuilder"
        bool[,] b = tablero.Obtener_gameBoard(); //b obtiene el nuevo estado del tablero
        for (int y = 0; y < tablero.boardHeight; y++)//Recorre cada fila y si "b[x,y]" es True, pone una celula, sino pone "___"
        {
            for (int x = 0; x < tablero.boardWidth; x++)
            {
                if (b[x, y])
                {
                    s.Append("|X|");
                }
                else
                {
                    s.Append("___");
                }
            }
            s.Append("\n");
        }

        Console.WriteLine(s.ToString());//Convierte el tablero a string
        
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);//Hace un timeout de 300ms por cada ciclo del tablero hecho
    }
}