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
        //Ejercicio 1: Estudiantes con promedio mayor a 85
        Console.WriteLine();
        Console.WriteLine("--------------------Ejercicio 1--------------------");
        var estudiantesConPromedioAlto = AdminApp.Estudiantes.Where(e => e.Calificaciones.Any() && e.Calificaciones.Average() > 85).ToList();
        foreach (var estudiante in estudiantesConPromedioAlto)
        {
            estudiante.MostrarDetalles();
        }
        //Ejercicio 2: Profesores que mas cursos enseñan
        Console.WriteLine("--------------------Ejercicio 2--------------------");
        var profesoresConMultiplesCursos = AdminApp.Profesores.Where(p => p.Cursos.Count > 2).ToList();
        foreach (var profesor in profesoresConMultiplesCursos)
        {
            profesor.MostrarDetalles();
        }
        //Ejercicio 3: Estudiantes cuya edad es mayor a 16
        Console.WriteLine();
        Console.WriteLine("--------------------Ejercicio 3--------------------");
        var estudiantesMayoresDe16 = AdminApp.Estudiantes.Where(e => e.CalcularEdad() > 16).ToList();
        foreach (var estudiante in estudiantesMayoresDe16)
        {
            estudiante.MostrarDetalles();
        }
        //Ejercicio 4: Ordenar estudiantes por apellido ascendente
        Console.WriteLine("--------------------Ejercicio 4--------------------");
        var estudiantesOrdenadosPorApellido = AdminApp.Estudiantes.OrderBy(e => e.ObtenerApellido()).ToList();
        foreach (var estudiante in estudiantesOrdenadosPorApellido)
        {
            estudiante.MostrarDetalles();
        }

        //Ejercicio 5: Calcular salario total de profesores
        Console.WriteLine("--------------------Ejercicio 5--------------------");
        double salarioTotal = AdminApp.Profesores.Sum(p => p.ObtenerSalarioLINQ());
        Console.WriteLine($"Salario total de todos los profesores: {salarioTotal:C}");

        //Ejercicio 6: Calcular estudiante con la calificacion mas alta
        Console.WriteLine("--------------------Ejercicio 6--------------------");
        var estudianteConCalificacionMasAlta = AdminApp.Estudiantes.OrderByDescending(e => e.Calificaciones.DefaultIfEmpty(0).Max()).FirstOrDefault();
        if (estudianteConCalificacionMasAlta != null)
        {
            Console.WriteLine("Estudiante con la calificación más alta:");
            estudianteConCalificacionMasAlta.MostrarDetalles();
        }

        //Ejercicio 7: Numero de estudiantes en cada curso
        Console.WriteLine("--------------------Ejercicio 7--------------------");
        var estudiantesPorCurso = AdminApp.Estudiantes.GroupBy(e => e.CursoActual).Select(grupo => new { Curso = grupo.Key, NumeroDeEstudiantes = grupo.Count() }).ToList();
        foreach (var curso in estudiantesPorCurso)
        {
            Console.WriteLine($"Curso: {curso.Curso}, Número de estudiantes: {curso.NumeroDeEstudiantes}");
        }

        //Ejercicio 8: Filtrar profesores con mas de 10 años de antiguedad
        Console.WriteLine("--------------------Ejercicio 8--------------------");
        var profesoresAntiguos = AdminApp.Profesores.Where(p => p.CalcularAntiguedad() > 10).ToList();
        foreach (var profesor in profesoresAntiguos)
        {
            profesor.MostrarDetalles();
        }

        //Ejercicio 9: Lista de asignaturas unicas que se imparten en la escuela
        Console.WriteLine("--------------------Ejercicio 9--------------------");
        var asignaturasUnicas = AdminApp.Profesores.SelectMany(p => p.Asignatura).Distinct().ToList();
        Console.WriteLine("Asignaturas únicas impartidas:");
        foreach (var asignatura in asignaturasUnicas)
        {
            Console.WriteLine(asignatura);
        }

        //Ejercicio 10: Buscar estudiantes cuyo nombre de acudiente sea María
        Console.WriteLine("--------------------Ejercicio 10-------------------");
        var estudiantesConAcudienteMaria = AdminApp.Estudiantes.Where(e => e.NombreAcudiente.Contains("María")).ToList();
        foreach (var estudiante in estudiantesConAcudienteMaria)
        {
            estudiante.MostrarDetalles();
        }

        //Ejercicio 11: Ordenar profesores por salario de forma descendente
        Console.WriteLine("--------------------Ejercicio 11-------------------");
        var profesoresOrdenadosPorSalario = AdminApp.Profesores.OrderByDescending(p => p.ObtenerSalarioLINQ()).ToList();
        foreach (var profesor in profesoresOrdenadosPorSalario)
        {
            profesor.MostrarDetalles();
        }

        //Ejercicio 12: Calcular el promedio de edad de los estudiantes
        Console.WriteLine("--------------------Ejercicio 12-------------------");
        double promedioEdad = AdminApp.Estudiantes.Average(e => e.CalcularEdad());
        Console.WriteLine($"Promedio de edad de los estudiantes: {promedioEdad:F2} años");

        //Ejercicio 13: Encontrar profesores que enseñan Matemáticas
        Console.WriteLine("--------------------Ejercicio 13-------------------");
        var profesoresMatematicas = AdminApp.Profesores.Where(p => p.Asignatura == "Matemáticas").ToList();
        foreach (var profesor in profesoresMatematicas)
        {
            profesor.MostrarDetalles();
        }

        //Ejercicio 14: Estudiantes con mas de 3 calificaciones registradas
        Console.WriteLine("--------------------Ejercicio 14-------------------");
        var estudiantesConMasDeTresCalificaciones = AdminApp.Estudiantes.Where(e => e.Calificaciones.Count > 3).ToList();
        foreach (var estudiante in estudiantesConMasDeTresCalificaciones)
        {
            estudiante.MostrarDetalles();
        }

        //Ejercicio 15: Calcular antiguedad promedio de los profesores
        Console.WriteLine("--------------------Ejercicio 15-------------------");
        double antiguedadPromedio = AdminApp.Profesores.Average(p => p.CalcularAntiguedad());
        Console.WriteLine($"Antigüedad promedio de los profesores: {antiguedadPromedio:F2} años");
    }
}