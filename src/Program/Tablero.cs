namespace Ucu.Poo.GameOfLife;

public class Tablero//Clase que tiene como responsabilidad crear el tablero,obtenerlo y establecerlo
{
    private bool[,] gameBoard;//Atributo privado booleano 
    public int boardWidth { get; private set; }//Atributo publico que obtiene el ancho del tablero
    public int boardHeight { get; private set; }//Atributo publico que obtiene el alto del tablero

    public void Crear_Tablero(Lector_Archivo lector)//Metodo que crea el tablero teniendo como parametro unaninstancia de la clase "Lector_Archivo"
    {
        gameBoard = lector.ReadArchive();//Obtiene el tablero
        boardWidth = gameBoard.GetLength(0);//Obtiene el ancho del tablero
        boardHeight = gameBoard.GetLength(1);//Obtiene el alto del tablero
    }

    public bool[,] Obtener_gameBoard()//Metodo que devuelve el tablero
    {
        return gameBoard;
    }

    public void Establecer_gameBoard(bool[,] nuevogameBoard)//Metodo que cambia el tablero por el tablero con las reglas aplicadas
    {
        gameBoard = nuevogameBoard;
    }
}