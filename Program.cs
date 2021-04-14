using System;

namespace NestedRepetition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Many X,es You Want?");
            String Xno = Console.ReadLine();

            int Xnoi;
            Xnoi = Convert.ToInt32(Xno);

            int counter1 = Xnoi;
            int counter2 = 0;
            int counter3 = 0;

            while (counter1 > 0)
            {

                while (counter1 > 0)
                {

                    Console.Write("X");
                    counter1--;
                }
                Console.WriteLine();
                counter2++;
                counter3++;
                counter1 = Xnoi - counter3;
            }
            Console.WriteLine("How He Stand?");



        }
    }
}
