namespace Ucu.Poo.GameOfLife;
//La clase organizador tiene como única responsabilidad crear a las distintas instancias necesarias para el juego y tener su propio método para arrancar el jeugo a travez de estos
//Controla el juego y su propio flujo
//Es experta teniendo como atributos a las distintas instancias de las otras clases y utilizando sus métodos, utlizando para sus métodos los datos de sus propios atributos
public class Organizador
{
    private Tablero tablero;
    private Logica logica;
    private Imprimir imprimir;
    private Lector_Archivo lectorarchivo;
    public Organizador()
    {
        this.lectorarchivo = new Lector_Archivo();
        this.tablero = new Tablero(this.lectorarchivo);
        this.logica = new Logica(this.tablero);
        this.imprimir = new Imprimir(this.tablero);
    }
    public void EjecutarJuego()
    {
        while (true)
        {
            imprimir.ImprimirTablero();
            logica.Jugar();
        }
    }
}