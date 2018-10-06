using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Pets
{
    class Program
    {


        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

            Pet pet1 = new Pet("dog", "Shadow", "Jose", 42.6);

            Console.WriteLine("Name: " + pet1.name);
            Console.WriteLine("Weight: " + pet1.weight);
            Console.WriteLine(pet1.getTag());

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
    public class Pet
    {

        public string type;
        public string name { get; set; }
        public string owner { get; set; }
        public double weight { get; set; }
        string Type1()
        {

            return "Dog";
        }
        string Type2()
        {
            return "Cat";
        }
        getTag()
        {
            return ("If lost call ",ref owner);
        }
    }
   
}
