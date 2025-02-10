using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonalComputer pc1 = new PersonalComputer();
            pc1.Model = "PC1";
            pc1.CpuFrequency = 3.0;
            pc1.RamSize = 16;
            pc1.HddSize = 512;
            pc1.Info();
            Console.WriteLine(pc1.ToString());
            Console.WriteLine();

            PersonalComputer pc2 = new PersonalComputer("PC2");
            pc2.CpuFrequency = 2.8;
            pc2.RamSize = 8;
            pc2.HddSize = 256;
            pc2.Info();
            Console.WriteLine(pc2.ToString());
            Console.WriteLine();

            PersonalComputer pc3 = new PersonalComputer("PC3", 4.0);
            pc3.RamSize = 32;
            pc3.HddSize = 1024;
            pc3.Info();
            Console.WriteLine(pc3.ToString());
            Console.WriteLine();

            PersonalComputer pc4 = new PersonalComputer("PC4", 3.2, 16);
            pc4.HddSize = 512;
            pc4.Info();
            Console.WriteLine(pc4.ToString());
            Console.WriteLine();

            PersonalComputer pc5 = new PersonalComputer("PC5", 4.5, 64, 2048);
            pc5.Info();
            Console.WriteLine(pc5.ToString());
            Console.WriteLine();

            Console.Write("Введите модель ПК: ");
            string model = Console.ReadLine();
            Console.Write("Введите тактовую частоту процессора (в ГГц): ");
            double cpuFrequency = double.Parse(Console.ReadLine());
            Console.Write("Введите объем оперативной памяти (в ГБ): ");
            int ramSize = int.Parse(Console.ReadLine());
            Console.Write("Введите объем жесткого диска (в ГБ): ");
            int hddSize = int.Parse(Console.ReadLine());
            PersonalComputer pc6 = new PersonalComputer(model, cpuFrequency, ramSize, hddSize);
            pc6.Info();
            Console.WriteLine(pc6.ToString());







        }
    }
}
