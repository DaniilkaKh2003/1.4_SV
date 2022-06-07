using System;
namespace Sample5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите цифру: ");
            int X = int.Parse(Console.ReadLine());
            Console.Write("Введите число: ");
            char[] N = Console.ReadLine().ToCharArray();
            int count = 0;
            int z = 0;
            for (int i = 0; i < N.Length; i++)
            {
                int n = Convert.ToInt32(N[i].ToString());
                if (n != X) count++;
            }
            char[] c = new char[count];
            for (int i = 0; i < N.Length; i++)
            {
                int n = Convert.ToInt32(N[i].ToString());
                if (n != X)
                {
                    c[z] = N[i];
                    z++;
                    if (z == count) break;
                }
            }
            Console.WriteLine(c);
        }
    }
}
