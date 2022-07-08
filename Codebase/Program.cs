using System;

class MainClass
{

    public static string FirstReverse(string str)
    {

      char[] chars = str.ToCharArray();
      Array.Reverse(chars);
      return new string(chars);
        

    }

    static void Main()
    {
        // keep this function call here
        Console.WriteLine(FirstReverse(Console.ReadLine()));
    }



}
