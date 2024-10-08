using System;

class Program
{
    static void Main(string[] args)
    {
        // Crear una instancia de Docente
        Docente docente1 = new Docente
        {
            Nombre = "Juan Pérez",
            Edad = 40,
            Materia = "Matemáticas"
        };
        docente1.MostrarInformacion();
        docente1.ImpartirClase();

        // Crear una instancia de Estudiante
        Estudiante estudiante1 = new Estudiante
        {
            Nombre = "Ana López",
            Edad = 20,
            Carrera = "Ingeniería de Software"
        };
        estudiante1.MostrarInformacion();
        estudiante1.Estudiar();

        // Crear una instancia de Administrativo
        Administrativo administrativo1 = new Administrativo
        {
            Nombre = "Carlos Martínez",
            Edad = 35,
            Departamento = "Recursos Humanos"
        };
        administrativo1.MostrarInformacion();
        administrativo1.GestionarAdministracion();
    }
}
