namespace Dsw2026Ej11.Collections;

/*
 * Para cada punto crear un método que permita:
 * 1. Obtener el primer libro (GetPrimero)
 * 2. Obtener el último libro (GetUltimo)
 * 3. Obtener la suma de precios (GetTotalPrecios)
 * 4. Obtener el promedio de precios (GetPromedioPrecios)
 * 5. Obtener la lista de libros con Id mayor a 15 (GetListById)
 * 6. Obtener una lista de cada libro con su título y precio en formato moneda (GetLibros) (debe retornar una lista de string)
 * 7. Obtener el libro con el precio más alto (GetMayorPrecio)
 * 8. Obtener el libro con el precio más bajo (GetMenorPrecio)
 * 9. Obtener los libros cuyo precio sea mayor al promedio (GetMayorPromedio)
 * 10. Obtener los libros ordenados por título de forma descendente
 * En todos los casos debe aplicarse LINQ
 */
public class CasoLinq
{
    public class Libro
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public decimal Precio { get; set; }
    }

    
    

        private List<Libro> libros = new List<Libro>();

        public CasoLinq()
        {
            libros.Add(new Libro { Id = 1, Titulo = "Hush Hush", Precio = 10000 });
            libros.Add(new Libro { Id = 2, Titulo = "Crescendo", Precio = 12000 });
            libros.Add(new Libro { Id = 20, Titulo = "Ficciones", Precio = 8000 });
            libros.Add(new Libro { Id = 2, Titulo = "Rayo", Precio = 9273 });
        }

        public Libro GetPrimero()
        {
            return libros.FirstOrDefault();
        }

        public Libro GetUltimo()
        {
            return libros.LastOrDefault();
        }

        public decimal GetTotalPrecio ()
        {
            return libros.Sum(l => l.Precio);
        }


        //average es para sacar el promedio
        public decimal GetPromedioPrecio ()
        {
            return libros.Count > 0 ? libros.Average(l => l.Precio) : 0;
        }

        public List<Libro> GetListById()
        {
            return libros.Where(l => l.Id > 15).ToList();
        }

        public List<string> GetLibros()
        {
            return libros.Select(l => $"{l.Titulo} - {l.Precio:C}").ToList();
        }

        
        public Libro GetMayorPrecio()
        {
        
            return libros.OrderByDescending(l => l.Precio).FirstOrDefault();
        }

        
        public Libro GetMenorPrecio()
        {
        
            return libros.OrderBy(l => l.Precio).FirstOrDefault();
        }

        
        public List<Libro> GetMayorPromedio()
        {
            decimal promedio = GetPromedioPrecio();
            return libros.Where(l => l.Precio > promedio).ToList();
        }

        
        public List<Libro> GetLibrosOrdenadosPorTituloDesc()
        {
            return libros.OrderByDescending(l => l.Titulo).ToList();
        }


    
}
