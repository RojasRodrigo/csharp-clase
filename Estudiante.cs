using System;

class Estudiante : Persona
{
    public string Carrera { get; set; }

    public void Estudiar()
    {
        Console.WriteLine($"{Nombre} está estudiando la carrera de {Carrera}.");
    }
}
