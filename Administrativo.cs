using System;

class Administrativo : Persona
{
    public string Departamento { get; set; }

    public void GestionarAdministracion()
    {
        Console.WriteLine($"{Nombre} está gestionando tareas del departamento de {Departamento}.");
    }
}
