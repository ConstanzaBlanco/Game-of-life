namespace Ucu.Poo.GameOfLife;
using System.IO;
//Tiene como única responsabilidad leer el archivo de tipo .txt para configurar el tablero.
//Traspasa los 0´s y 1´s a valores booleanos contenidos en una lista (es decir una matriz)
//Esta clase es experta en leer el archivo y convertir los datos de este.
public class Lector_Archivo
{
    public bool[,] ReadArchive()
    {
        string url = "board.txt";
        string content = File.ReadAllText(url);
        string[] contentLines = content.Split('\n');
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];
        for (int y = 0; y < contentLines.Length; y++)
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[x, y] = true;
                }
            }
        }
        return board;
    }
}