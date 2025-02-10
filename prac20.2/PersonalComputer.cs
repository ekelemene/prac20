using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prac20._2
{
    internal class PersonalComputer : Program
    {
        public string Model;
        public double CpuFrequency;
        public int RamSize;
        public int HddSize;
        public PersonalComputer()
        {
            Model = "Неизвестно";
            CpuFrequency = 0;
            RamSize = 0;
            HddSize = 0;
        }
        public PersonalComputer(string model)
        {
            Model = model;
            CpuFrequency = 0;
            RamSize = 0;
            HddSize = 0;
        }
        public PersonalComputer(string model, double cpuFrequency)
        {
            Model = model;
            CpuFrequency = cpuFrequency;
            RamSize = 0;
            HddSize = 0;
        }
        public PersonalComputer(string model, double cpuFrequency, int ramSize)
        {
            Model = model;
            CpuFrequency = cpuFrequency;
            RamSize = ramSize;
            HddSize = 0;
        }
        public PersonalComputer(string model, double cpuFrequency, int ramSize, int hddSize)
        {
            Model = model;
            CpuFrequency = cpuFrequency;
            RamSize = ramSize;
            HddSize = hddSize;
        }
        public void Info()
        {
            Console.WriteLine($"Модель: {Model}");
            Console.WriteLine($"Частота процессора: {CpuFrequency} ГГц");
            Console.WriteLine($"Оперативная память: {RamSize} ГБ");
            Console.WriteLine($"Жесткий диск: {HddSize} ГБ");
        }
        public override string ToString()
        {
            return $"Модель: {Model}, Процессор: {CpuFrequency} ГГц, ОЗУ: {RamSize} ГБ, HDD: {HddSize} ГБ";
        }




    }
}
