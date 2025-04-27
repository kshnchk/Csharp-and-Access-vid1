using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Работа 1. Проект 2";
            Console.WindowHeight = 60;//высота окна
            Console.WindowHeight = 13;//ширина окна
            Console.BackgroundColor = ConsoleColor.Blue;//цвет фона
            Console.Clear();//очистить зону проекта
            Console.SetCursorPosition(15, 6);//положение курсора

            //Console.WriteLine($"Введите свое имя: ");
            //String Name = Console.ReadLine();
            //Console.WriteLine($"Привет, {Name}"); 
            //Console.Write("Нажми любую клавишу для завершения...");
            //Console.ReadKey();

            Console.WriteLine($"Введите свое имя: ");
            String Name = Console.ReadLine();
            Console.WriteLine($"Введите свою фамилию: ");
            String lastName = Console.ReadLine();       
            Console.WriteLine("Привет, {1} {0}!", Name, lastName);
            Console.Write("Нажми любую клавишу для завершения...");
            Console.ReadKey();


        }
    }
}
