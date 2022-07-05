using System;
using System.Collections.Generic;



namespace Test_Writing
{
    class Program
    {
        static void Main(string[] args)
        {
           //List<string> names = new List<string>();
           //List<Person> peoples = new List<Person>();

            List<Hightscore> hightscores = new List<Hightscore>();
            hightscores.Add(new Hightscore("Olga", 34));
            hightscores.Add(new Hightscore("Ksenya", 44));
            hightscores.Add(new Hightscore("Irina", 54));
            hightscores.Add(new Hightscore("Yummy", 19));
            hightscores.Add(new Hightscore("Dmitry", 42));


            



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
                    Console.WriteLine("Press any key");
                    Console.ReadLine();
                    Console.Clear();
            }
            if (input == 2)
            {
                    Console.WriteLine("Введите номер позиции");
                    int pos = int.Parse(Console.ReadLine());
                    hightscores.RemoveAt(pos);
            }
            if (input == 3)
            {
                Console.WriteLine("Список победителей");
                Console.WriteLine();
                    hightscores.Sort();
                foreach (Hightscore score in hightscores)
                {
                    Console.WriteLine(score);
                }
                    Console.WriteLine("Press any key");
                    Console.ReadLine();
                    Console.Clear();
                }


            }

            

            //names.Add("Jenny");
            //names.Add("John");
            //names.Add("Bane");
            //names.Add("Hane");
            //names.Add("Tony");

            //peoples.Add(new Person("Harry", 23));
            //peoples.Add(new Person("Tonny", 24));
            //peoples.Add(new Person("Kurt", 33));
            //peoples.Add(new Person("Dora", 43));

            //foreach (Person person in peoples)
            //{
            //    Console.WriteLine(person);
            //}

            //Console.WriteLine("Remove Kurt");
            //List<Person> tmp = peoples.ToList();

            //foreach (Person person in tmp)
            //{
            //    if (person.Name == "Kurt")
            //    {
            //        peoples.Remove(person);
            //    }    
            //}
            //peoples.Sort();

            //foreach (Person person in peoples)
            //{
            //    Console.WriteLine(person);
            //}

            //string firstName = names[0];
            //Console.WriteLine(firstName);
            //names.Sort();
            //for (int i = 0; i < names.Count; i++)
            //{
            //    Person p = new Person(names[i],29);
            //    Console.WriteLine($"Name: {p.Name} Age: {p.Age}");  
            //}

        }

    }

}