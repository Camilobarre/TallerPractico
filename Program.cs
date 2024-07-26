using TallerPractico.Models;

AdminApp.Estudiantes.Add(new Estudiante("Juan", "Pérez", "CC", "123456789", "juan.perez@email.com", "3001234567", "Ana Pérez", "10A", new DateOnly(2005, 5, 15)
)
{ Calificaciones = new List<double> { 4.5, 3.7, 4.8 } });

AdminApp.Estudiantes.Add(new Estudiante("María", "García", "CC", "234567890", "maria.garcia@email.com", "3002345678", "Luis García", "11B", new DateOnly(2004, 8, 22)
)
{ Calificaciones = new List<double> { 3.8, 4.0, 4.2 } });

AdminApp.Estudiantes.Add(new Estudiante("Carlos", "Rodríguez", "TI", "345678901", "carlos.rodriguez@email.com", "3003456789", "Laura Rodríguez", "9C",
    new DateOnly(2006, 3, 30)
)
{ Calificaciones = new List<double> { 4.2, 4.5, 4.7 } });

AdminApp.Estudiantes.Add(new Estudiante("Laura", "Martínez", "CC", "456789012", "laura.martinez@email.com", "3004567890", "Ricardo Martínez", "10B",
    new DateOnly(2005, 12, 5)
)
{ Calificaciones = new List<double> { 3.9, 4.1, 4.0 } });

AdminApp.Estudiantes.Add(new Estudiante("Andrés", "Sánchez", "CC", "567890123", "andres.sanchez@email.com", "3005678901", "Elena Sánchez", "11A", new DateOnly(2004, 11, 12)
)
{ Calificaciones = new List<double> { 4.6, 4.7, 4.8 } });


Console.Clear();

var bandera = true;

while (bandera)
{
    AdminApp.ImprimirMenu();
    var opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 0:
            // Salir del programa
            Console.WriteLine("Hasta luego, vuelva pronto!");
            bandera = false;
            break;
        case 1:
            // Agregar Estudiante
            var estudianteNuevo = AdminApp.PedirDatosEstudiante();
            AdminApp.PedirCalificaciones(estudianteNuevo);
            AdminApp.AgregarEstudiante(estudianteNuevo);
            AdminApp.PausarMenu();
            break;
        case 2:
            // Agregar Profesor
            var profesorNuevo = AdminApp.PedirDatosProfesor();
            AdminApp.AgregarProfesor(profesorNuevo);
            AdminApp.PausarMenu();
            break;
        case 3:
            // Mostrar Estudiantes
            AdminApp.MostrarEstudiantes();
            AdminApp.PausarMenu();
            break;
        case 4:
            // Mostrar Profesores
            AdminApp.MostrarProfesores();
            AdminApp.PausarMenu();
            break;
        case 5:
            // Editar estudiante
            AdminApp.EditarEstudiante();
            AdminApp.PausarMenu();
            break;
        case 6:
            // Editar profesor
            AdminApp.EditarProfesor();
            AdminApp.PausarMenu();
            break;
        case 7:
            // Eliminar estudiante
            AdminApp.EliminarEstudiante();
            AdminApp.PausarMenu();
            break;
        case 8:
            // Eliminar profesor
            AdminApp.EliminarProfesor();
            AdminApp.PausarMenu();
            break;
        case 9:
            // Consultas de LINQ
            AdminApp.ConsultasLinq();
            AdminApp.PausarMenu();
            break;
        default:
            break;
    }
}
