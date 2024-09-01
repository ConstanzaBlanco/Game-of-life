namespace Ucu.Poo.GameOfLife;
//La clase tiene como única responsabilidad guardar el estado del tablero actual
//Tiene algunos métodos para obtener y restablecer el estado del mismo dentro de la clase
//No tiene acceso a dotos que no son de su responsabilidad, cumpliendo con rcp

public class Tablero //Clase que tiene como responsabilidad crear el tablero,obtenerlo y establecerlo
{
    private bool[,] gameBoard; //Atributo privado booleano 
    public int boardWidth { get; private set; }  //Atributo publico que obtiene el ancho del tablero
    public int boardHeight { get; private set; } //Atributo publico que obtiene el alto del tablero
    
    public Tablero(Lector_Archivo lector)//Metodo que crea el tablero teniendo como parametro unaninstancia de la clase "Lector_Archivo"
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
