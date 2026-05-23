namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave


public class CasoDictionary
{
    private Dictionary<int, string> alumnosDiccionario = new Dictionary<int, string>();

    public void AgregarAlumno(int legajo, string alumno)
    {
        alumnosDiccionario.TryAdd(legajo, alumno);
    }

    
    public string BuscarAlumnoPorLegajo(int legajo)
    {
        if (alumnosDiccionario.ContainsKey(legajo))
        {
           
            return alumnosDiccionario[legajo];
        }
        return null;
    }

    
    public Dictionary<int, string> ObtenerDiccionario()
    {
        return alumnosDiccionario;
    }

    
    public bool EliminarAlumnoPorLegajo(int legajo)
    {
        return alumnosDiccionario.Remove(legajo);
    }
}