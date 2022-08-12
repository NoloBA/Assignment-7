using System;

namespace Notebook
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Notebook Dell = new Notebook(2020, "Windows", "i5");
            Notebook Lenovo = new Notebook(2021, "Chrome", "i3");

            Console.WriteLine("New Laptop: "+ Dell.Processor);
            Console.WriteLine("New Lenovo: "+Lenovo.OS);
        }
    }
}
