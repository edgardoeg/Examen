using Examen;

Asignatura asignatura = new Asignatura();
try
{
    

    Console.Write("Ingrese el nombre de alumno: ");
    asignatura.NombreAlumno = Console.ReadLine();

    Console.Write("Ingrese el numero de cuenta: ");
    asignatura.NumeroCuenta = Convert.ToDouble(Console.ReadLine());

    Console.Write("Ingrese el correo Electronico: ");
    asignatura.Email = Console.ReadLine();

    Console.Write("Ingrese el nombre de la clase: ");
    asignatura.NombreAsignatura = Console.ReadLine();

    Console.Write("Ingrese el Horadio de la clase: ");
    asignatura.Horario = Console.ReadLine();

    Console.Write("Ingrese el nombre del Docente: ");
    asignatura.NombreDocente = Console.ReadLine();

    Console.Write("Ingrese la nota del 1er parcial: ");
    asignatura.N1 = Convert.ToInt32(Console.ReadLine());
    if(asignatura.N1 > 30)
    {
        throw new Exception("La nota del primer parcial sobrepasa del 30%");
    }

    Console.Write("Ingrese la nota del 2do parcial: ");
    asignatura.N2 = Convert.ToInt32(Console.ReadLine());
    if (asignatura.N2 > 30)
    {
        throw new Exception("La nota del segundo parcial sobrepasa del 30%");
    }

    Console.Write("Ingrese la nota del 3er parcial: ");
    asignatura.N3 = Convert.ToInt32(Console.ReadLine());
    if (asignatura.N3 > 40)
    {
        throw new Exception("La nota del primer parcial sobrepasa del 40%");
    }
    asignatura.Imprimir();

}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}

