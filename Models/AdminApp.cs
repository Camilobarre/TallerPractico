using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TallerPractico.Models;
public static class AdminApp
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
            Console.WriteLine($"El estudiante fue eliminado correctamente");
        }
        else
        {
            Console.WriteLine($"Estudiante no encontrado");
        }
    }

    public static void EliminarProfesor()
    {
        Console.WriteLine("Ingrese la cédula del profesor a eliminar: ");
        string? cedulaProfesor = Console.ReadLine();
        Profesor? profesor = BuscarProfesorPorCedula(cedulaProfesor);
        if (profesor != null)
        {
            Profesores.Remove(profesor);
            Console.WriteLine($"El profesor fue eliminado correctamente");
        }
        else
        {
            Console.WriteLine($"Profesor no encontrado");
        }
    }

    public static void EditarEstudiante()
    {
        Console.WriteLine("Ingrese la cédula del estudiante a editar: ");
        string? cedulaEstudiante = Console.ReadLine();
        Estudiante? estudiante = BuscarEstudiantePorCedula(cedulaEstudiante);
        if (estudiante != null)
        {
            bool salir = false;
            do
            {
                Console.WriteLine($"Estudiante {estudiante.ObtenerNombreCompleto()}");
                Console.WriteLine("Qué deseas modificar: ");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Apellido");
                Console.WriteLine("3. Tipo de documento");
                Console.WriteLine("4. Número de documento");
                Console.WriteLine("5. Email");
                Console.WriteLine("6. Teléfono");
                Console.WriteLine("7. Nombre acudiente");
                Console.WriteLine("8. Curso actual");
                Console.WriteLine("9. Salir");

                var opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nuevo nombre: ");
                        estudiante.ActualizarNombre(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nuevo apellido: ");
                        estudiante.ActualizarApellido(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nuevo tipo de documento: ");
                        estudiante.ActualizarTipoDocumento(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el nuevo número de documento: ");
                        estudiante.ActualizarDocumento(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el nuevo email: ");
                        estudiante.ActualizarEmail(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el nuevo teléfono: ");
                        estudiante.ActualizarTelefono(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Ingrese el nuevo nombre del acudiente: ");
                        estudiante.NombreAcudiente = Console.ReadLine();
                        break;
                    case 8:
                        Console.WriteLine("Ingrese el nuevo curso: ");
                        estudiante.CursoActual = Console.ReadLine();
                        break;
                    case 9:
                        salir = true;
                        break;
                }
            } while (!salir);
        }
        else
        {
            Console.WriteLine("Estudiante no encontrado.");
        }
    }

    public static void EditarProfesor()
    {
        Console.WriteLine("Ingrese la cédula del profesor a editar: ");
        string? cedulaProfesor = Console.ReadLine();
        Profesor? profesor = BuscarProfesorPorCedula(cedulaProfesor);
        if (profesor != null)
        {
            bool salir = false;
            do
            {
                Console.WriteLine($"Profesor {profesor.ObtenerNombreCompleto()}");
                Console.WriteLine("Qué deseas modificar: ");
                Console.WriteLine("1. Nombre");
                Console.WriteLine("2. Apellido");
                Console.WriteLine("3. Tipo de documento");
                Console.WriteLine("4. Número de documento");
                Console.WriteLine("5. Email");
                Console.WriteLine("6. Teléfono");
                Console.WriteLine("7. Salario");
                Console.WriteLine("8. Asignatura");
                Console.WriteLine("9. Salir");

                var opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nuevo nombre: ");
                        profesor.ActualizarNombre(Console.ReadLine());
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nuevo apellido: ");
                        profesor.ActualizarApellido(Console.ReadLine());
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el nuevo tipo de documento: ");
                        profesor.ActualizarTipoDocumento(Console.ReadLine());
                        break;
                    case 4:
                        Console.WriteLine("Ingrese el nuevo número de documento: ");
                        profesor.ActualizarDocumento(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Ingrese el nuevo email: ");
                        profesor.ActualizarEmail(Console.ReadLine());
                        break;
                    case 6:
                        Console.WriteLine("Ingrese el nuevo teléfono: ");
                        profesor.ActualizarTelefono(Console.ReadLine());
                        break;
                    case 7:
                        Console.WriteLine("Ingrese el nuevo salario: ");
                        profesor.ActualizarSalario(Convert.ToDouble(Console.ReadLine()));
                        break;
                    case 8:
                        Console.WriteLine("Ingrese la nueva asignatura: ");
                        profesor.Asignatura = Console.ReadLine();
                        break;
                    case 9:
                        salir = true;
                        break;
                }
            } while (!salir);
        }
        else
        {
            Console.WriteLine("Profesor no encontrado.");
        }
    }

    private static Estudiante? BuscarEstudiantePorCedula(string cedula)
    {
        return Estudiantes.FirstOrDefault(estudiante => estudiante.ObtenerCedula() == cedula);
    }

    private static Profesor? BuscarProfesorPorCedula(string cedula)
    {
        return Profesores.FirstOrDefault(profesor => profesor.ObtenerCedula() == cedula);
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
        Console.Clear();
    }
    public static void ConsultasLinq()
    {
        
    }
}