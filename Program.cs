using System;

namespace ConsoleApplication
{
    public class Program
    {
       public static OOPw1CA app = new OOPw1CA();
      
        public static void Main(string[] args)
        {
           int Icecream = ReadInt("Please choose a flavour by pressing 1, 2 or 3: Chocolate = 1, Strawberry = 2, Vanilla = 3");
           

        }

        public static int ReadInt(string message)
        {
            Console.WriteLine(message);
            string input = Console.ReadLine();
            return Convert.ToInt32(input);

        }

    }
}
