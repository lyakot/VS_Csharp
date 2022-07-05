using System;
using System.Collections.Generic;



namespace Test_Writing
{
    class Program
    {
        private static List<Hightscore> hightscores = new List<Hightscore>();
        static void Main(string[] args)
        {
            //List<string> names = new List<string>();
            //List<Person> peoples = new List<Person>();

            Random rnd = new Random();

           
            hightscores.Add(new Hightscore("Olga", rnd.Next(1, 100)));
            hightscores.Add(new Hightscore("Ksenya", rnd.Next(1, 100)));
            hightscores.Add(new Hightscore("Irina", rnd.Next(1, 100)));
            hightscores.Add(new Hightscore("Yummy", rnd.Next(1, 100)));
            hightscores.Add(new Hightscore("Dmitry", rnd.Next(1, 100)));

            while (true)
            {

                Console.WriteLine("1. Add score");
                Console.WriteLine("2. Remove score");
                Console.WriteLine("3. View highscores");


                int input = int.Parse(Console.ReadLine());
                if (input == 1)
                {
                    Console.WriteLine("Введите имя");
                    string h1 = Console.ReadLine();
                    int s1 = 10;
                    Hightscore h2 = new Hightscore(h1, s1);
                    hightscores.Add(h2);
                    
                }
               else if (input == 2)
                {
                    Console.WriteLine("Введите номер позиции");
                    int pos = int.Parse(Console.ReadLine());
                    hightscores.RemoveAt(pos);
                }
                else if (input == 3)
                {
                    ViewScore();
                                 
                }
                Console.WriteLine("Press any key");
                Console.ReadLine();
                Console.Clear();

            }


        }

        private static void ViewScore()
        {
            Console.WriteLine("Список победителей");
            Console.WriteLine();
            hightscores.Sort();
            int rank = 1;
            foreach (Hightscore score in hightscores)
            {
               
                Console.WriteLine($"{rank}: {score}");
                rank++;
            }

        }

    }

}