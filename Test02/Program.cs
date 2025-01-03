using System.Globalization;

namespace Test02
{
    internal class Program
    {
        static int Factorial(int n)
        {
            /*int sum = 1;
            for (int i = n; i > 0; i--)
            {
                sum = sum * i;
            }
            return sum;
            */
            //recursive function 
            if (n <= 1)
            {
                return 1;
            }
            return n * Factorial(n - 1);

        }
        static void Main(string[] args)
        {
            //Q.01
            for(int i = 1; i<= 9; i++)
            {
                for(int j= 1; j<=9; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i*j}");
                }
            }
            //Q.02
            for (int i = 1;i<= 5; i++)
            {
                for (int j = 1; j<= i; j++)
                {
                    Console.Write("*"); //without Line : not enter
                }
                Console.WriteLine();
            }
            //Q.03
            int ret = Factorial(5);
            Console.WriteLine(ret);
        }
    }
}
