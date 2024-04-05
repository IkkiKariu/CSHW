using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HomeWork
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        private static int EuclideanAlg(int a, int b)
        {
            if (a == 0)
            {
                return b;
            }
            else if (b == 0)
            {
                return a;
            }

            var c = higher(a, b) - lower(a, b);

            return EuclideanAlg(higher(b, c), lower(b, c));
        }

        private static int lower(int a, int b)
        {
            if (a > b)
            {
                return b;
            }

            return a;
        }

        private static int higher(int a, int b)
        {
            if (a > b)
            {
                return a;
            }

            return b;
        }

        private static int translateDecimal(int basee, int[] number, int dIndex)
        {
            if (dIndex == number.Length)
            {
                return 0;
            }

            return number[dIndex] * ((int) Math.Pow(basee, (number.Length - 1 - dIndex))) + translateDecimal(basee, number, dIndex + 1);
        }

        private static int fibonacci(int n)
        {
            if (n == 1 || n == 2)
            {
                return 1;
            }

            return fibonacci(n - 1) + fibonacci(n - 2);
        }
    }
}
