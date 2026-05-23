namespace Dsw2026Ej11.Collections;

//Crear un campo que represente una lista de alumnos (List<>)
//Incluir un método para agregar alumnos a la lista
//Incluir un método para retornar la lista
//Incluir un método para buscar un alumno por nombre
//Incluir un método para eliminar un alumno (debe recibir un alumno)
//Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    private List<string> alumnos = new List<string>();

    public void AgregarAlumno(string alumno)
    {
        alumnos.Add(alumno);
    }
    public List<string> ObtenerAlumnos()
    {
        return alumnos;
    }
    public string BuscarAlumno(string nombre)
    {
        foreach (var alumno in alumnos)
        {
            if (alumno.ToLower() == nombre.ToLower())
            {
                return alumno;
            }
        }
        return null;
    }

    public bool EliminarAlumno(string alumno)
    {
        return alumnos.Remove(alumno);
    }

    public void EliminarAlumnoEnPosicion (int Posicion)
    {
        if (Posicion >= 0 && Posicion < alumnos.Count)
        {
            alumnos.RemoveAt(Posicion);
        }
    }
}
