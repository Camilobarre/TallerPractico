using TallerPractico.Models;

Console.Clear();

var bandera = true;

while (bandera)
{
    AdminApp.ImprimirMenu();
    var opcion = Console.ReadLine();

    switch (opcion)
    {
        case "0":
            // Salir del programa
            Console.WriteLine("Hasta luego, vuelva pronto!");
            bandera = false;
            break;
        case "1":
            // Agregar Estudiante
            var estudianteNuevo = AdminApp.PedirDatosEstudiante();
            AdminApp.PedirCalificaciones(estudianteNuevo);
            AdminApp.AgregarEstudiante(estudianteNuevo);
            AdminApp.PausarMenu();
            break;
        case "2":
            // Agregar Profesor
            var profesorNuevo = AdminApp.PedirDatosProfesor();
            AdminApp.AgregarProfesor(profesorNuevo);
            AdminApp.PausarMenu();
            break;
        case "3":
            // Mostrar Estudiantes
            AdminApp.MostrarEstudiantes();
            AdminApp.PausarMenu();
            break;
        case "4":
            // Mostrar Profesores
            AdminApp.MostrarProfesores();
            AdminApp.PausarMenu();
            break;
        case "5":
            // Editar estudiante
            break;
        case "6":
            // Editar profesor
            break;
        case "7":
            // Eliminar estudiante
            AdminApp.EliminarEstudiante();
            AdminApp.PausarMenu();
            break;
        case "8":
            // Eliminar profesor
            AdminApp.EliminarProfesor();
            AdminApp.PausarMenu();
            break;
        default:
            break;
    }
}