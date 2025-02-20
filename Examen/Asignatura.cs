

namespace Examen
{
    public class Asignatura : Alumno, IAsignatura
    {
        public int N1 {  get; set; }
        public int N2 { get; set; }
        public int N3 { get; set; }
        public string? NombreAsignatura {  get; set; }
        public string? Horario {  get; set; }
        public string? NombreDocente {  get; set; }


        public double CalcularNotaFinal()
        {
            return N1 + N2 + N3;
        }
        public double CalcularNotaFinal(double Nota1, double Nota2, double Nota3)
        {
            return Nota1 + Nota2 + Nota3;
        }

        public string MensajeNotaFinal(double notaFinal)
        {
            if(notaFinal >= 0 && notaFinal <= 59)
                return "Reprobado";
            else if (notaFinal >= 60 && notaFinal <= 79)
                return "Bueno";
            else if (notaFinal >= 80 && notaFinal <= 89)
                return "Muy Bueno";
            else if (notaFinal >= 90 && notaFinal <= 100)
                return "Sobresaliente";
            else
                return "Nota Invalida";
        }

        public void Imprimir() 
        {
            Console.WriteLine($"Ingrese nombre del alumno: {NombreAlumno}");
            Console.WriteLine($"Ingrese numero de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Ingrese Correo Electronico: {Email}");
            Console.WriteLine($"Ingrese nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Ingrese Horario de la clase: {Horario}");
        }


    }
}
