using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace prac20
{
    internal class Build : Program
    {
        public string name;
        public double area;
        public int kvo;
        public int floor;

        public Build()
        {
            name = "Неизвестно";
            area = 0;
            kvo = 0;
            floor = 0;
        }
        public Build(string name)
        {
            this.name = name;

        }
        public Build(string name, double area)
        {
            this.name = name;
            this.area = area;

        }
        public Build(string name, double area, int kvo)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
        }
        public Build(string name, double area, int kvo, int floor)
        {
            this.name = name;
            this.area = area;
            this.kvo = kvo;
            this.floor = floor;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Название строения: {name}");
            Console.WriteLine($"Площадь строения: {area} м3 ");
            Console.WriteLine($"Количество жильцов: {kvo}");
            if (kvo > 0)
            {
                double areaPerP = area / kvo;
                Console.WriteLine($"Площадь на одного жильца: {areaPerP:F2} м2");
            }
            else
            {
                Console.WriteLine("Нет жильцов для расчета площади на одного.");
            }
        }



    }
}
