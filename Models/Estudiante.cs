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
        this.NombreAcudiente = nombreAcudiente;
        this.CursoActual = cursoActual;
        this.FechaNacimiento = fechaNacimiento;
        this.Calificaciones = new List<double>();
    }
    public string? ObtenerCedula()
    {
        return NumeroDocumento;
    }
    public string ObtenerNombreCompleto()
    {
        return $"{Nombre} {Apellido}";
    }
    public string? ObtenerApellido()
    {
        return Apellido;
    }
    public void ActualizarNombre(string? nuevoNombre)
    {
        Nombre = nuevoNombre;
    }

    public void ActualizarApellido(string? nuevoApellido)
    {
        Apellido = nuevoApellido;
    }

    public void ActualizarTipoDocumento(string? nuevoTipoDocumento)
    {
        TipoDocumento = nuevoTipoDocumento;
    }

    public void ActualizarDocumento(string? nuevoDocumento)
    {
        NumeroDocumento = nuevoDocumento;
    }

    public void ActualizarEmail(string? nuevoEmail)
    {
        Email = nuevoEmail;
    }

    public void ActualizarTelefono(string? nuevoTelefono)
    {
        Telefono = nuevoTelefono;
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
            Console.Write($"{calificacion,-5}");
        }
    }

    public override void MostrarDetalles()
    {
        Console.WriteLine($"Rol:        Estudiante");
        base.MostrarDetalles();
        Console.WriteLine($"Nombre Acudiente: {NombreAcudiente}");
        Console.WriteLine($"Curso Actual: {CursoActual}");
        Console.WriteLine($"Edad: {CalcularEdad()} años");
        Console.WriteLine("Calificaciones: ");
        MostrarCalificaciones();
        Console.WriteLine();
        CalcularPromedio();
        Console.WriteLine();
    }
}