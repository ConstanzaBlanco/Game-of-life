namespace Ucu.Poo.GameOfLife;

public class Tablero
{
    private bool[,] gameBoard;
    public int boardWidth { get; private set; }
    public int boardHeight { get; private set; }

    public void Crear_Tablero(Lector_Archivo lector)
    {
        gameBoard = lector.ReadArchive();
        boardWidth = gameBoard.GetLength(0);
        boardHeight = gameBoard.GetLength(1);
    }

    public bool[,] Obtener_gameBoard()
    {
        return gameBoard;
    }

    public void Establecer_gameBoard(bool[,] nuevogameBoard)
    {
        gameBoard = nuevogameBoard;
    }
}