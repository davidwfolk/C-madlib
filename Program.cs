using System;

namespace madlib
{
    class Program
    {
        static void Main(string[] args)
        {
            string color, pluralNoun, petName, familyMember;

            Console.Write("Enter a color: ");
            color = Console.ReadLine();

            Console.Write("Enter a plural noun: ");
            pluralNoun = Console.ReadLine();

            Console.Write("Enter a pet name: ");
            petName = Console.ReadLine();

            Console.Write("Enter a family member's name: ");
            familyMember = Console.ReadLine();

            Console.Write("\r\n");
            Console.Write("--------------------------------");
            Console.Write("\r\n");
            Console.Write("\r\n");
            
            Console.WriteLine("Roses are " + color + " ,");
            Console.WriteLine(pluralNoun + " are blue,");
            Console.WriteLine(petName + " is sweet,");
            Console.WriteLine("But for "+ familyMember + " that's not true.");

            Console.ReadLine();
        }
    }
}
