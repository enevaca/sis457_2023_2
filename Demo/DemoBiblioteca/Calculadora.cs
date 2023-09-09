namespace DemoBiblioteca
{
    public class Calculadora
    {
        public static int sumar(int n1, int n2)
        {
            return n1 + n2;
        }

        public static int restar(int n1, int n2) => n1 - n2;
        
        public static Func<int, int, int> multiplicar = (n1, n2) => n1 * n2;

        public static decimal divir(int n1, int n2) => n1 / n2;
    }
}