namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1";

            Console.WriteLine("Задание 2");
            Console.WriteLine("C# - это современный, с открытым исходным кодом, объектно-ориентированный,язык программирования");

            Console.WriteLine("Задание 3");
            Console.Write("Нажми любую клавишу...");
            Console.ReadKey();

            Console.WriteLine("Задание 4");
            Console.WriteLine("C# - это современный,\n\t с открытым исходным кодом, \n\t объектно-ориентированный, \n\t язык программирования");

            Console.WriteLine("Задание 5");
           
            Console.ForegroundColor= ConsoleColor.Cyan;
            Console.WriteLine("C# - это современный,");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n\t с открытым исходным кодом");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\t объектно-ориентированный");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n\t язык программирования");
            Console.ResetColor();
   
        }
    }
}


