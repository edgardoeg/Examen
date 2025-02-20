

namespace Examen
{
    public interface IAsignatura
    {
        public double CalcularNotaFinal();
        public double CalcularNotaFinal( double Nota1, double Nota2, Double Nota3);
        public string MensajeNotaFinal(double notaFinal);
        public void Imprimir();

    }
}
