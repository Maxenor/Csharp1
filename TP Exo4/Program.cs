namespace TP2_Exo_4
{
    class Program
    {
        public static void Main(string[] args)
        {
            Calculatrice calc = new();
            Console.WriteLine(calc.Additionner(10, 20));
            Console.WriteLine(calc.Multiplier(99, 99));
        }
        public class Calculatrice
        {
            public int Additionner(int a, int b)
            {
                return a + b;
            }

            public int Multiplier(int a, int b)
            {
                return a * b;
            }
        }
    }
}