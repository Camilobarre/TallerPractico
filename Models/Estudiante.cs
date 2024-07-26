using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPractico.Models;
public class Estudiante : Persona
{
    public string NombreAcudiente { get; set; }
    public string CursoActual { get; set; }
    public DateOnly FechaNacimiento { get; set; }
    public List<double> Calificaciones { get; set; }

    public Estudiante(string nombre,
    string apellido,
    string tipoDocumento,
    string numeroDocumento,
    string email,
    string telefono,
    string nombreAcudiente,
    string cursoActual,
    DateOnly fechaNacimiento
    ) : base(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono)
    {
    }
    public string? ObtenerCedula()
    {
        return NumeroDocumento;
    }

    public string? ObtenerNombre()
    {
        return Nombre;
    }

    public void AgregarCalificaciones(double calificacion)
    {
        Calificaciones.Add(calificacion);
    }

    private void CalcularPromedio()
    {
        Console.WriteLine($"Promedio: {Calificaciones.Average():F2}");
    }

    public int CalcularEdad()
    {
        return DateTime.Now.Year - FechaNacimiento.Year;
    }

    public void MostrarCalificaciones()
    {
        foreach (var calificacion in Calificaciones)
        {
            Console.WriteLine($"{calificacion},");
        }
    }

    public override void MostrarDetalles() //override -> sobreescritura del método
    {
        base.MostrarDetalles();
        Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
        Console.WriteLine($"Curso Actual: {CursoActual}");
        Console.WriteLine($"Edad: {CalcularEdad()} años");
        Console.WriteLine("Calificaciones: ");
        MostrarCalificaciones();
        CalcularPromedio();
    }
}