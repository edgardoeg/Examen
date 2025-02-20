

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
        public double CalcularNotaFinal(int N1, int N2, int N3)
        {
            return N1 + N2 + N3;
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
                return "Nota ingresada Invalida";
        }

        public void Imprimir() 
        {
            double notaFinal = CalcularNotaFinal();
            double notaFinalParametros = CalcularNotaFinal(N1, N2, N3);

            Console.WriteLine($"Nombre del alumno: {NombreAlumno}");
            Console.WriteLine($"Numero de cuenta: {NumeroCuenta}");
            Console.WriteLine($"Correo Electronico: {Email}");
            Console.WriteLine($"Nombre de la clase: {NombreAsignatura}");
            Console.WriteLine($"Horario de la clase: {Horario}");
            Console.WriteLine($"Nombre del Docente: {NombreDocente}");
            Console.WriteLine($"Nota 1er parcial: {N1}");
            Console.WriteLine($"Nota 2do parcial: {N2}");
            Console.WriteLine($"Nota 3er parcial: {N3}");
            Console.WriteLine($"Nota Final con el Metodo sin parametros es: {notaFinal}  - {MensajeNotaFinal}");
            Console.WriteLine($"Nota Final con el Metodo Con parametros es: {notaFinalParametros}  - {MensajeNotaFinal}");
        }


    }
}
