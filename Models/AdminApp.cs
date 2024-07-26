using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPractico.Models;
public class AdminApp
{
    public static List<Estudiante> Estudiantes = new List<Estudiante>();
    public static List<Profesor> Profesores = new List<Profesor>();

    public static Estudiante PedirDatosEstudiante()
    {
        Console.WriteLine("Ingrese los datos del estudiante:");

        Console.WriteLine("Nombre: ");
        string? nombre = Console.ReadLine();

        Console.WriteLine("Apellido: ");
        string? apellido = Console.ReadLine();

        Console.WriteLine("Tipo de documento: ");
        string? tipoDocumento = Console.ReadLine();

        Console.WriteLine("Número de documento: ");
        string? numeroDocumento = Console.ReadLine();

        Console.WriteLine("Email: ");
        string? email = Console.ReadLine();

        Console.WriteLine("Teléfono: ");
        string? telefono = Console.ReadLine();

        Console.WriteLine("Nombre Acudiente: ");
        string? nombreAcudiente = Console.ReadLine();

        Console.WriteLine("Curso Actual: ");
        string? curso = Console.ReadLine();

        Console.WriteLine("Ingresa la fecha de nacimiento del estudiante: año/mes/día ");
        DateOnly fechaNacimiento = DateOnly.FromDateTime(Convert.ToDateTime(Console.ReadLine()));

        return new Estudiante(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, nombreAcudiente, curso, fechaNacimiento);
    }

    public static void PedirCalificaciones(Estudiante estudiante)
    {
        Console.WriteLine("Cuántas notas vas a agregar?: ");
        var notas = Convert.ToInt32(Console.ReadLine());
        for (int i = 1; i <= notas; i++)
        {
            Console.WriteLine($"Tu nota {i}:");
            var nota = Convert.ToDouble(Console.ReadLine());
            estudiante.AgregarCalificaciones(nota);
        }
    }

    public static void AgregarEstudiante(Estudiante estudiante)
    {
        Estudiantes.Add(estudiante);
        Console.WriteLine($"El estudiante fue añadido correctamente");
    }

    public static Profesor PedirDatosProfesor()
    {
        Console.WriteLine("Ingrese los datos del profesor:");

        Console.WriteLine("Nombre: ");
        string? nombre = Console.ReadLine();

        Console.WriteLine("Apellido: ");
        string? apellido = Console.ReadLine();

        Console.WriteLine("Tipo de documento: ");
        string? tipoDocumento = Console.ReadLine();

        Console.WriteLine("Número de documento: ");
        string? numeroDocumento = Console.ReadLine();

        Console.WriteLine("Email: ");
        string? email = Console.ReadLine();

        Console.WriteLine("Teléfono: ");
        string? telefono = Console.ReadLine();

        Console.WriteLine("Asignatura: ");
        string? asignatura = Console.ReadLine();

        Console.WriteLine("Salario: ");
        double salario = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingresa la fecha de contratación: año/mes/día ");
        DateTime fechaContratacion = Convert.ToDateTime(Console.ReadLine());

        return new Profesor(nombre, apellido, tipoDocumento, numeroDocumento, email, telefono, asignatura, salario, fechaContratacion);
    }

    public static void AgregarProfesor(Profesor profesor)
    {
        Profesores.Add(profesor);
        Console.WriteLine($"El profesor fue añadido correctamente");
    }

    public static void MostrarEstudiantes()
    {
        foreach (var estudiante in Estudiantes)
        {
            estudiante.MostrarDetalles();
        }
    }

    public static void MostrarProfesores()
    {
        foreach (var profesor in Profesores)
        {
            profesor.MostrarDetalles();
        }
    }

    public static void EliminarEstudiante()
    {
        Console.WriteLine("Ingrese la cédula del estudiante a eliminar: ");
        string? cedulaEstudiante = Console.ReadLine();
        Estudiante? estudiante = BuscarEstudiantePorCedula(cedulaEstudiante);
        if (estudiante != null)
        {
            Estudiantes.Remove(estudiante);
            Console.WriteLine("Estudiante eliminado.");
        }
        else
        {
            Console.WriteLine("La cédula ingresada no coincide.");
        }
    }

    private static Estudiante? BuscarEstudiantePorCedula(string? numeroDocumento)
    {
        foreach (var estudiante in Estudiantes)
        {
            if (estudiante.ObtenerCedula() == numeroDocumento)
            {
                return estudiante;
            }
        }
        return null;
    }

    public static void EliminarProfesor()
    {
        Console.WriteLine("Ingrese la cédula del profesor a eliminar: ");
        string? cedulaProfesor = Console.ReadLine();
        Profesor? profesor = BuscarProfesorPorCedula(cedulaProfesor);
        if (profesor != null)
        {
            Profesores.Remove(profesor);
            Console.WriteLine("Profesor eliminado.");
        }
        else
        {
            Console.WriteLine("La cédula ingresada no coincide.");
        }
    }

    private static Profesor? BuscarProfesorPorCedula(string? numeroDocumento)
    {
        foreach (var profesor in Profesores)
        {
            if (profesor.ObtenerCedula() == numeroDocumento)
            {
                return profesor;
            }
        }
        return null;
    }

    public static void EditarEstudiante()
    {
        Console.WriteLine("Ingrese la cédula del profesor a eliminar: ");
        string? cedulaEstudiante = Console.ReadLine();
        Estudiante? estudiante = BuscarEstudiantePorCedula(cedulaEstudiante);
        if (estudiante != null)
        {
            Console.WriteLine("Vamos a modificar el estudiante!");

            Console.WriteLine("Nombre nuevo: ");
            var NuevoNombre = Console.ReadLine();
            estudiante.Nombre = NuevoNombre;

            Console.WriteLine("Apellido Nuevo: ");
            var NuevoApellido = Console.ReadLine();
            estudiante.Apellido = NuevoApellido;

            Console.WriteLine("Tipo de documento nuevo: ");
            var NuevoTipoDocumento = Console.ReadLine();
            estudiante.TipoDocumento = NuevoTipoDocumento;

            Console.WriteLine("Número de documento nuevo: ");
            var NuevoNumeroDocumento = Console.ReadLine();
            estudiante.NumeroDocumento = NuevoTipoDocumento;

            Console.WriteLine("Email nuevo: ");
            var NuevoEmail = Console.ReadLine();
            estudiante.Email = NuevoEmail;

            Console.WriteLine("Teléfono nuevo: ");
            var NuevoTelefono = Console.ReadLine();
            estudiante.Telefono = NuevoTelefono;

            Console.WriteLine("Nombre acudiente nuevo: ");
            var NuevoAcudiente = Console.ReadLine();
            estudiante.NombreAcudiente = NuevoAcudiente;

            Console.WriteLine("Curso actual nuevo: ");
            var NuevoCurso = Console.ReadLine();
            estudiante.CursoActual = NuevoCurso;
        }
        else
        {
            Console.WriteLine("La cédula ingresada no coincide.");
        }
    }

    public static void EditarProfesor()
    {
        Console.WriteLine("Ingrese la cédula del profesor a eliminar: ");
        string? cedulaProfesor = Console.ReadLine();
        Profesor? profesor = BuscarProfesorPorCedula(cedulaProfesor);
        if (profesor != null)
        {
            Console.WriteLine("Vamos a modificar el profesor!");

            Console.WriteLine("Nombre nuevo: ");
            var NuevoNombre = Console.ReadLine();
            profesor.Nombre = NuevoNombre;

            Console.WriteLine("Apellido nuevo: ");
            var NuevoApellido = Console.ReadLine();
            profesor.Apellido = NuevoApellido;

            Console.WriteLine("Tipo de documento nuevo: ");
            var NuevoTipoDocumento = Console.ReadLine();
            profesor.TipoDocumento = NuevoTipoDocumento;

            Console.WriteLine("Número de documento nuevo: ");
            var NuevoNumeroDocumento = Console.ReadLine();
            profesor.NumeroDocumento = NuevoTipoDocumento;

            Console.WriteLine("Email nuevo: ");
            var NuevoEmail = Console.ReadLine();
            profesor.Email = NuevoEmail;

            Console.WriteLine("Teléfono nuevo: ");
            var NuevoTelefono = Console.ReadLine();
            profesor.Telefono = NuevoTelefono;

            Console.WriteLine("Asignatura nueva: ");
            var NuevaAsignatura = Console.ReadLine();
            profesor.Asignatura = NuevaAsignatura;

            Console.WriteLine("Salario nuevo: ");
            var NuevoSalario = Convert.ToDouble(Console.ReadLine());
            profesor.Salario = NuevoSalario;

            Console.WriteLine("Salario nuevo: ");
            var NuevaFechaContratacion = Convert.ToDateTime(Console.ReadLine());
            profesor.FechaContratacion = NuevaFechaContratacion;
        }
        else
        {
            Console.WriteLine("La cédula ingresada no coincide.");
        }
    }
    public static void ImprimirMenu()
    {
        Console.WriteLine("==============================================================================");
        Console.WriteLine("                           Gestión del sistema escolar                        ");
        Console.WriteLine("==============================================================================");
        Console.WriteLine("                             1. Agregar Estudiante                            ");
        Console.WriteLine("                             2. Agregar Profesor                              ");
        Console.WriteLine("                             3. Mostrar Estudiantes                           ");
        Console.WriteLine("                             4. Mostrar Profesores                            ");
        Console.WriteLine("                             5. Editar Estudiante                             ");
        Console.WriteLine("                             6. Editar Profesor                               ");
        Console.WriteLine("                             7. Eliminar Estudiante                           ");
        Console.WriteLine("                             8. Eliminar Profesor                             ");
        Console.WriteLine("                             9. Consultas LINQ                                ");
        Console.WriteLine("                             0. Salir                                         ");
        Console.WriteLine("==============================================================================");
        Console.Write("Selecciona una opción: ");
    }

    public static void PausarMenu()
    {
        Console.WriteLine("Presiona una tecla para continuar...");
        Console.ReadKey();
    }

}