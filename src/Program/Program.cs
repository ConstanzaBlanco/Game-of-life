﻿using System;
//Tiene como única responsabilidad crear una instancia de organizador y llamar a su método que inicia el juego
//Es experta manejando solo la instancia de Organizador y llamar a su método para jugar, sin saber nada más de las otras clases
namespace Ucu.Poo.GameOfLife
{
    class Program
    {
        static void Main(string[] args)
        {
            Organizador Juego = new Organizador();
            Juego.EjecutarJuego();
        }
    }
}
