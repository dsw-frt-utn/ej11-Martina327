using System.Security.Cryptography.X509Certificates;
using Dsw2026Ej11.Collections;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList()
    {
        CasoList casoList = new CasoList();

        casoList.AgregarAlumno("Martina Albornoz");
        casoList.AgregarAlumno("Dorado Rocio");
        casoList.AgregarAlumno("Figueroa Ian");
        Console.WriteLine("--- Alumnos agregados ---");

        foreach (var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine($"- {alumno}");
        }
        
        string encontrado = casoList.BuscarAlumno("Rocio Dorado");
        if (encontrado != null)
        {
            Console.WriteLine($"Resultado: Se encontró a {encontrado}");
        }

        string noEncontrado = casoList.BuscarAlumno("Martinez Pia");
        if (noEncontrado == null)
        {
            Console.WriteLine("Resultado: No existe");
        }
        
        casoList.EliminarAlumno("Figueroa Ian");
        Console.WriteLine("Lista después de eliminar:");
        foreach (var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine($"- {alumno}");
        }

        casoList.EliminarAlumnoEnPosicion(0);
        Console.WriteLine("Lista final:");
        foreach (var alumno in casoList.ObtenerAlumnos())
        {
            Console.WriteLine($"- {alumno}");
        }


    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary casoDict = new CasoDictionary();

        casoDict.AgregarAlumno(45001, "Pia Albornoz");
        casoDict.AgregarAlumno(45002, "Mariano Albornoz");
        casoDict.AgregarAlumno(45003, "Viviana Monteros");
        Console.WriteLine("--- Alumnos agregados al diccionario ---");


        Console.WriteLine("\nAlumnos dentro del diccionario:");
        foreach (var par in casoDict.ObtenerDiccionario())
        {

            Console.WriteLine($"Legajo: {par.Key} - Nombre: {par.Value}");
        }


        string alumnoBuscado = casoDict.BuscarAlumnoPorLegajo(45002);
        if (alumnoBuscado != null)
        {
            Console.WriteLine($"Resultado: El alumno es {alumnoBuscado}");
        }

        string alumnoFalso = casoDict.BuscarAlumnoPorLegajo(99999);
        if (alumnoFalso == null)
        {
            Console.WriteLine("Resultado: No existe");
        }

        //lo eimino
        casoDict.EliminarAlumnoPorLegajo(45001);

        Console.WriteLine("Diccionario actualizado:");
        foreach (var par in casoDict.ObtenerDiccionario())
        {
            Console.WriteLine($"Legajo: {par.Key} - Nombre: {par.Value}");
        }




    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {

        CasoLinq casoLinq = new CasoLinq();


        var primero = casoLinq.GetPrimero();
        Console.WriteLine($"Primer libro: {primero?.Titulo} (ID: {primero?.Id})");


        var ultimo = casoLinq.GetUltimo();
        Console.WriteLine($"Último libro: {ultimo?.Titulo} (ID: {ultimo?.Id})");

        Console.WriteLine($"\nSuma total de precios: {casoLinq.GetTotalPrecio():C}");

      //promedio
        Console.WriteLine($"\nPromedio de precios: {casoLinq.GetPromedioPrecio():C}");

        //id mayor a 15
        Console.WriteLine("\nLibros con ID mayor a 15:");
        foreach (var lib in casoLinq.GetListById())
        {
            Console.WriteLine($"- ID: {lib.Id} | {lib.Titulo}");
        }

        
        Console.WriteLine("\nLista de libros formateada:");
        foreach (var textoLibro in casoLinq.GetLibros())
        {
            Console.WriteLine(textoLibro);
        }

        
        var masCaro = casoLinq.GetMayorPrecio();
        Console.WriteLine($"\nLibro más caro: {masCaro?.Titulo} ({masCaro?.Precio:C})");

        
        var masBarato = casoLinq.GetMenorPrecio();
        Console.WriteLine($"Libro más barato: {masBarato?.Titulo} ({masBarato?.Precio:C})");

        
        Console.WriteLine("\nLibros con precio mayor al promedio:");
        foreach (var lib in casoLinq.GetMayorPromedio())
        {
            Console.WriteLine($"- {lib.Titulo} ({lib.Precio:C})");
        }

        
        Console.WriteLine("\nLibros ordenados por título (Z-A):");
        foreach (var lib in casoLinq.GetLibrosOrdenadosPorTituloDesc())
        {
            Console.WriteLine($"- {lib.Titulo}");
        }


    }
}
