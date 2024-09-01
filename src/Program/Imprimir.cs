namespace Ucu.Poo.GameOfLife;
using System; //Importa Console,String y Math
using System.Text;//Importa StringBuilder
using System.Threading;//Importa Thread y Thread.Sleep
//Tiene como única responsabilidad imprimir el estado del tablero, construyendolo en string a partir de un StringBuilder
//Tiene el conocimiento suficiente para imprimir el tablero por lo tanto sigue correctamente Expert.
//Decidimos no colocar dentro de esta clase un llamado a la clase Logica y su método Juego.
//Ya que esto haría que la clase tuviera demasiados datos que no son necesarios para imprimir el tablero (No cumpliendo con Expert correctamente)
//Además esto haría que tuviera más responsabilidades que solo imprimir el juego, también rompiendo con el prinicipio de SRP
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
        Thread.Sleep(300);
    }
}