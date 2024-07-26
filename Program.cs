using TallerPractico.Models;

Console.Clear();

AdminApp.Estudiantes.Add(new Estudiante("Juan", "Pérez", "CC", "123456789", "juan.perez@email.com", "3001234567", "Ana Pérez", "10A", new DateOnly(2017, 5, 15))
{ Calificaciones = new List<double> { 90, 72.5, 80.5 } });

AdminApp.Estudiantes.Add(new Estudiante("María", "García", "CC", "234567890", "maria.garcia@email.com", "3002345678", "Luis García", "11B", new DateOnly(2018, 8, 22))
{ Calificaciones = new List<double> { 80.9, 40, 42 } });

AdminApp.Estudiantes.Add(new Estudiante("Carlos", "Rodríguez", "TI", "345678901", "carlos.rodriguez@email.com", "3003456789", "Laura Rodríguez", "9C", new DateOnly(2019, 3, 30))
{ Calificaciones = new List<double> { 70.5, 40.5, 32.1, 99 } });

AdminApp.Estudiantes.Add(new Estudiante("Laura", "Martínez", "CC", "456789012", "laura.martinez@email.com", "3004567890", "María Martínez", "10B", new DateOnly(2017, 12, 5))
{ Calificaciones = new List<double> { 39, 48.5, 20.5 } });

AdminApp.Estudiantes.Add(new Estudiante("Andrés", "Sánchez", "CC", "567890123", "andres.sanchez@email.com", "3005678901", "Elena Sánchez", "11A", new DateOnly(2018, 11, 12)
)
{ Calificaciones = new List<double> { 46, 47, 90 } });
AdminApp.Estudiantes.Add(new Estudiante("Gabriela", "Hernández", "CC", "678901234", "gabriela.hernandez@email.com", "3006789012", "Marta Hernández", "12A", new DateOnly(2003, 6, 18)) { Calificaciones = new List<double> { 4.0, 3.9, 4.1 } });

AdminApp.Estudiantes.Add(new Estudiante("Javier", "Córdoba", "CC", "789012345", "javier.cordoba@email.com", "3007890123", "Sandra Córdoba", "8B", new DateOnly(2011, 2, 20))
{ Calificaciones = new List<double> { 90, 80, 87,82 } });

AdminApp.Estudiantes.Add(new Estudiante("Isabel", "Castro", "CC", "890123456", "isabel.castro@email.com", "3008901234", "María Castro", "9A", new DateOnly(2015, 4, 10))
{ Calificaciones = new List<double> { 88, 90, 93 } });

AdminApp.Estudiantes.Add(new Estudiante("Daniel", "Mendoza", "CC", "901234567", "daniel.mendoza@email.com", "3009012345", "Claudia Mendoza", "11B", new DateOnly(2014, 9, 25))
{ Calificaciones = new List<double> { 55, 76, 64 } });

AdminApp.Estudiantes.Add(new Estudiante("Valeria", "Torres", "CC", "012345678", "valeria.torres@email.com", "3000123456", "Roberto Torres", "10C", new DateOnly(2012, 7, 14))
{ Calificaciones = new List<double> { 91, 90, 92 } });

AdminApp.Profesores.Add(new Profesor("Carlos", "Martínez", "CC", "8901234", "carlos.martinez@email.com", "3101234567", "Matemáticas", 3000000, new DateTime(2018, 3, 15))
{ Cursos = new List<string> { "10A", "9B" } });

AdminApp.Profesores.Add(new Profesor("Ana", "Rodríguez", "CC", "9012345", "ana.rodriguez@email.com", "3102345678", "Historia", 3200000, new DateTime(2017, 6, 22)) 
{ Cursos = new List<string> { "11D", "7D" } });

AdminApp.Profesores.Add(new Profesor("Luis","García","CC","82848415","luis.garcia@email.com","3103456789","Química",3400000,new DateTime(2016, 1, 10))
{ Cursos = new List<string> { "9C", "10A" } });

AdminApp.Profesores.Add(new Profesor("Sofía","Pérez","CC","12453454","sofia.perez@email.com","3104567890","Lengua",3100000,new DateTime(2018, 8, 5))
{ Cursos = new List<string> { "8B", "10C" } });

AdminApp.Profesores.Add(new Profesor("Miguel","Hernández","CC","875242453","miguel.hernandez@email.com","3105678901","Educación Física",3000000,new DateTime(2014, 11, 12))
{ Cursos = new List<string> { "4A", "5C", "3C" } });

AdminApp.Profesores.Add(new Profesor("Claudia","Gómez","CC","5841814741","claudia.gomez@email.com","3106789012","Informática",3300000,new DateTime(2019, 2, 20))
{ Cursos = new List<string> { "9D", "5A" } });

AdminApp.Profesores.Add(new Profesor("Jorge","Salazar","CC","5425734527","jorge.salazar@email.com","3107890123","Física",3500000,new DateTime(2013, 5, 30))
{ Cursos = new List<string> { "6C", "5C" } });

AdminApp.Profesores.Add(new Profesor("Valentina","Morales","CC","2424325788","valentina.morales@email.com","3108901234","Física",3400000,new DateTime(2016, 7, 19))
{ Cursos = new List<string> { "5B", "3A" } });

AdminApp.Profesores.Add(new Profesor("Pedro","Jiménez","CC","901234567","pedro.jimenez@email.com","3109012345","Matemáticas",3200000,new DateTime(2015, 9, 15))
{ Cursos = new List<string> { "2C", "1A" } });

AdminApp.Profesores.Add(new Profesor("Laura","Vásquez","CC","18084841516","laura.vasquez@email.com","3100123456","Biología",3300000,new DateTime(2018, 4, 10))
{ Cursos = new List<string> { "1C", "1D" } });

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
