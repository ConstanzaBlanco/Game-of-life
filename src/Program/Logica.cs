namespace Ucu.Poo.GameOfLife;
//La clase Lógica tiene como única responsabilidad manejar la parte
//lógica del juego a travez de un Tablero(el cual un atributo de la misma), calcula y rehace el tablero con los nuevos valores.
//Modifica el tablero a travéz del método Jugar cada vez que se le pida
//Cumple con Expert ya que solo tiene conocimiento que necesita para cumplir su responsabilidad

public class Logica
{
    private Tablero tablero;

    public Logica(Tablero tablero)
    {
        this.tablero = tablero;
    }

    public void Jugar()
    {
        bool[,] gameBoard = tablero.Obtener_gameBoard();
        bool[,] cloneboard = new bool[tablero.boardWidth, tablero.boardHeight];
        for (int x = 0; x < tablero.boardWidth; x++)
        {
            for (int y = 0; y < tablero.boardHeight; y++)
            {
                int aliveNeighbors = 0;
                for (int i = x - 1; i <= x + 1; i++)
                {
                    for (int j = y - 1; j <= y + 1; j++)
                    {
                        if (i >= 0 && i < tablero.boardWidth && j >= 0 && j < tablero.boardHeight && gameBoard[i, j])
                        {
                            aliveNeighbors++;
                        }
                    }
                }

                if (gameBoard[x, y])
                {
                    aliveNeighbors--;
                }

                if (gameBoard[x, y] && aliveNeighbors < 2)
                {
                    //Celula muere por baja población
                    cloneboard[x, y] = false;
                }
                else if (gameBoard[x, y] && aliveNeighbors > 3)
                {
                    //Celula muere por sobrepoblación
                    cloneboard[x, y] = false;
                }
                else if (!gameBoard[x, y] && aliveNeighbors == 3)
                {
                    //Celula nace por reproducción
                    cloneboard[x, y] = true;
                }
                else
                {
                    //Celula mantiene el estado que tenía
                    cloneboard[x, y] = gameBoard[x, y];
                }
            }
        }

        tablero.Establecer_gameBoard(cloneboard);
    }
}