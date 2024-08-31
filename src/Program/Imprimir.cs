namespace Ucu.Poo.GameOfLife;
using System; //Importa Console,String y Math
using System.Text;//Importa StringBuilder
using System.Threading;//Importa Thread y Thread.Sleep

public class Imprimir
{
    private Tablero tablero;

    public Imprimir(Tablero tablero)
    {
        this.tablero = tablero;
    }

    public void ImprimirTablero()
    {
        Console.Clear();
        Console.WriteLine("\x1b[3J");
        StringBuilder s = new StringBuilder();
        bool[,] b = tablero.Obtener_gameBoard(); //b obtiene el nuevo estado del tablero
        for (int y = 0; y < tablero.boardHeight; y++)
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

        Console.WriteLine(s.ToString());
        
        //=================================================
        //Invocar método para calcular siguiente generación
        //=================================================
        Thread.Sleep(300);
    }
}