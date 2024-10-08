using System;

class Docente : Persona
{
    public string Materia { get; set; }

    public void ImpartirClase()
    {
        Console.WriteLine($"{Nombre} está impartiendo la clase de {Materia}.");
    }
}
