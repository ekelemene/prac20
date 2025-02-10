using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Build dom1 = new Build();
            dom1.name = "Жилой дом 1";
            dom1.area = 150.5;
            dom1.kvo = 5;
            dom1.ShowInfo();
            Console.WriteLine();

            Build dom2 = new Build("отель", 6000, 1250);
            dom2.ShowInfo();
            Console.WriteLine();

            Console.Write("Название строения: ");
            string name = Console.ReadLine();
            Console.Write("Площадь строения: ");
            double area = double.Parse(Console.ReadLine());
            Console.Write("Количество жильцов: ");
            int kvo = int.Parse(Console.ReadLine());
            Console.Write("Количество этажей: ");
            int floor = int.Parse(Console.ReadLine());
            Build dom3 = new Build(name, area, kvo, floor);
            Console.WriteLine("dom3:");
            dom3.ShowInfo();




        }
    }
}
