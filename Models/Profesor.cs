using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPractico.Models;
public class Profesor : Persona
{
    public string Asignatura { get; set; }
    private double Salario { get; set; }
    public DateTime FechaContratacion { get; set; }
    public List<string> Cursos { get; set; }

    public Profesor(
        string nombre,
        string apellido,
        string tipoDocumento,
        string numeroDocumento,
        string email,
        string telefono,
        string asignatura,
        double salario,
        DateTime fechaContratacion
    ) : base(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono)
    {
    }
    public string? ObtenerCedula()
    {
        return NumeroDocumento;
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
    public void ActualizarSalario(double salario)
    {
        this.Salario = salario;
    }
    public int CalcularAntiguedad()
    {
        return DateTime.Now.Year - FechaContratacion.Year;
    }

    public void ObtenerSalario()
    {
        Console.WriteLine($"Salario: {this.Salario:C} COP");
    }

    public void MostrarCursos()
    {
        foreach (var curso in Cursos)
        {
            Console.WriteLine($"{curso},");
        }
    }

    public override void MostrarDetalles() //override -> sobreescritura del método
    {
        Console.WriteLine($"Rol: Profesor");
        base.MostrarDetalles();
        Console.WriteLine($"Asignatura: {Asignatura}");
        ObtenerSalario();
        Console.WriteLine($"Antiguedad: {CalcularAntiguedad()} años");
        Console.WriteLine($"Cursos: ");
        MostrarCursos();
    }
}