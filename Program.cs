using System;

namespace OstrVR
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int marks = 0;

            for(int i =0; i < 3; i++)
            {
                int a1 = random.Next(1, 24);
                int a2 = random.Next(1, 24);
                int a3 = random.Next(1, 24);

                Console.WriteLine($"Введите число номер {i+1}");
                int answ = Convert.ToInt32(Console.ReadLine());

                if(answ == a1 || answ == a2 || answ == a3)
                {
                    marks += 1;
                }
                Console.WriteLine($"{a1} {a2} {a3}");

            }

            if (marks >= 2)
            {
                Console.WriteLine("Вы выигралли");

            }
            else
            {
                Console.WriteLine("Вы проигралли");
            }


        }
    }
}
