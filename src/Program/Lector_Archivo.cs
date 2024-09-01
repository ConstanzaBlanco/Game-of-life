namespace Ucu.Poo.GameOfLife;
using System.IO;
//Tiene como única responsabilidad leer el archivo de tipo .txt para configurar el tablero.
//Traspasa los 0´s y 1´s a valores booleanos contenidos en una lista (es decir una matriz)
//Esta clase es experta en leer el archivo y convertir los datos de este.
public class Lector_Archivo//Clase que su responsabilidad es leer el archivo dado
{
    public bool[,] ReadArchive()//Metodo para leer el archivo
    {
        string url = "board.txt";//Busca el archivo con ese nombre
        string content = File.ReadAllText(url);//Lee el texto
        string[] contentLines = content.Split('\n');//Divide el texto en lineas
        bool[,] board = new bool[contentLines.Length, contentLines[0].Length];//Crea una matriz de booleanos con los mismos numeros de filas y columnas que las lineas y caracteres del texto
        for (int y = 0; y < contentLines.Length; y++)//Recorre cada fila del texto en binario y si hay un "1" devuelve True para "board[x,y]
        {
            for (int x = 0; x < contentLines[y].Length; x++)
            {
                if (contentLines[y][x] == '1')
                {
                    board[x, y] = true;
                }
            }
        }
        return board;//Devuelve el tablero
    }
}
