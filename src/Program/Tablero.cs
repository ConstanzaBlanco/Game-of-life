namespace Ucu.Poo.GameOfLife;
//La clase tiene como única responsabilidad guardar el estado del tablero actual
//Tiene algunos métodos para obtener y restablecer el estado del mismo dentro de la clase
//No tiene acceso a dotos que no son de su responsabilidad, cumpliendo con rcp

public class Tablero
{
    private bool[,] gameBoard;
    public int boardWidth { get; private set; } 
    public int boardHeight { get; private set; }

    public Tablero(Lector_Archivo lector)
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