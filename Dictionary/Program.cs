using System;
using System.Collections.Generic;

namespace Dictionary
{
    class Program
    {

        static void Main(string[] args)
        {

        
            List<User> listUsers = new List<User>();


            Dictionary<string, User> dictionaryUsers = new Dictionary<string, User>();

            User Keand = new User("Keand", "Kenneth", "Andersen");
            User Jimto = new User("Jimto", "Jim", "Johnsen");
            User Larto = new User("Larto", "Lars", "Larsen");
            User Gityv = new User("Gityv", "Gitte", "Tysen");
            User Vitra = new User("Vira", "Vita", "Andersen");

            listUsers.Add(Keand);
            listUsers.Add(Jimto);
            listUsers.Add(Larto);
            listUsers.Add(Gityv);
            listUsers.Add(Vitra);


            dictionaryUsers.Add(Keand.UserName, Keand);
            dictionaryUsers.Add(Jimto.UserName, Jimto);
            dictionaryUsers.Add(Larto.UserName, Larto);
            dictionaryUsers.Add(Gityv.UserName, Gityv); 
            dictionaryUsers.Add(Vitra.UserName, Vitra);


            string userName = "Larto";

            //foreach (User user in listUsers)
            //{
            //    if (user.UserName == userName)
            //    {
            //        Console.WriteLine(user);
            //        Console.WriteLine("This is she");
            //    }
            //}

            Console.WriteLine(dictionaryUsers[userName]);


        }


    }


}
    