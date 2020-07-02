using System;

namespace SomeWork
{
    class Program
    {
        class SomeWork
        {
            public int a, b;
            public void ShowNumbers()
            {
                Console.WriteLine("a: " + a);
                Console.WriteLine("b: " + b);
            }

            public void ChangeNumbers(int changeA, int changeB)
            {
                a = changeA;
                b = changeB;
            }

            public void Sum()
            {
                Console.WriteLine("Сумма = " + (a + b));
            }
            public void MaxNumber()
            {
                if (a > b) Console.WriteLine(a + " - больше");
                else Console.WriteLine(b + " - больше");
            }
        }

        static void Main(string[] args)
        {
            SomeWork rai = new SomeWork();

            rai.a = 1;
            rai.b = -53;
            rai.ChangeNumbers(33, 66);
            rai.MaxNumber();
            rai.Sum();
            rai.ShowNumbers();
        }
    }
}