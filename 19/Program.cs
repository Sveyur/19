using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19
{
    class Computer
    {
        public uint Code { get; set; }
        public string ComputerBrand { get; set; }
        public string Processor { get; set; }
        public double FrequencyProcessor { get; set; }
        public int RAMsize { get; set; }
        public int HardDisk { get; set; }
        public string VideoCarta { get; set; }
        public string OperatingSystem { get; set; }
        public double Price { get; set; }
        public uint Number { get; set; }


    }
    class Program
    {

        static void Main(string[] args)
        {
            List<Computer> Сomputers = new List<Computer>()
            {
              new Computer(){Code=1001, ComputerBrand="acer", Processor="Intel Core", FrequencyProcessor=2.6, RAMsize=8, HardDisk=1000, VideoCarta="Intel UHD", OperatingSystem="Windows", Price=36.990, Number=20},
              new Computer(){Code=1002, ComputerBrand="apple", Processor="Apple", FrequencyProcessor=2.6, RAMsize=16, HardDisk=512, VideoCarta="8 core GPU", OperatingSystem="macOS", Price=109.990, Number=1},
              new Computer(){Code=1003, ComputerBrand="asus", Processor="Intel Core", FrequencyProcessor=3.6, RAMsize=4, HardDisk=256, VideoCarta="NVIDIA", OperatingSystem="noOS", Price=36.290, Number=3},
              new Computer(){Code=1004, ComputerBrand="dell", Processor="Intel Core", FrequencyProcessor=2.3, RAMsize=8, HardDisk=256, VideoCarta="Intel UHD", OperatingSystem="Linux", Price=44.790, Number=8},
              new Computer(){Code=1005, ComputerBrand="hp", Processor="AMD Ryzen", FrequencyProcessor=3.8, RAMsize=4, HardDisk=256, VideoCarta="AMD Ryzen", OperatingSystem="Free DOS 3.0", Price=28.090, Number=31},
              new Computer(){Code=1006, ComputerBrand="lenovo", Processor="Intel Core", FrequencyProcessor=2.6, RAMsize=16, HardDisk=256, VideoCarta="NVIDIA GeForce", OperatingSystem="Windows 10", Price=173.090, Number=1},
              new Computer(){Code=1007, ComputerBrand="huawei", Processor="AMD Ryzen", FrequencyProcessor=3.7, RAMsize=8, HardDisk=256, VideoCarta="AMD Radeon", OperatingSystem="Windows 10 Home", Price=49.990, Number=1},
              new Computer(){Code=1008, ComputerBrand="iru", Processor="Intel Core", FrequencyProcessor=2.9, RAMsize=8, HardDisk=240, VideoCarta="Free DOS", OperatingSystem="Free DOS", Price=35.390, Number=12},
              new Computer(){Code=1009, ComputerBrand="acer", Processor="Intel Pentium", FrequencyProcessor=2, RAMsize=4, HardDisk=128, VideoCarta="Intel UHD", OperatingSystem="Endless", Price=16.990, Number=35},
              new Computer(){Code=1010, ComputerBrand="dell", Processor="Intel Core", FrequencyProcessor=3.2, RAMsize=16, HardDisk=256, VideoCarta="Intel UHD", OperatingSystem="Windows 10 Professional", Price=66.890, Number=5}
            };
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Введите бренд компьютера: ");
                Console.ResetColor();
                string brend = Console.ReadLine().ToLower();
                Console.WriteLine();
                List<Computer> computers1 = Сomputers
                    .Where(c => c.ComputerBrand == brend)
                    .ToList();

                if (computers1.Count() == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Нет в наличии!");
                    Console.ResetColor();
                    Console.WriteLine();

                }
                else
                {
                    foreach (Computer c in computers1)
                        Console.WriteLine("Код - " + c.Code + "; Бренд - " + c.ComputerBrand +
                            "; Процессор - " + c.Processor + "; Частота процессора - " +
                            c.FrequencyProcessor + "; Объем оперативной памяти - " +
                            c.RAMsize + "; Объем жесткого диска - " + c.HardDisk +
                            "; Видеокарта - " + c.VideoCarta + "; Операционная система - " +
                            c.OperatingSystem + "; Цена - " + c.Price + "; Имеется в наличии - " + c.Number + "\n");
                    break;
                }
            }



            uint ramsize = 0;
            string ramsize_str;
            bool tryQQ = false;
            while (tryQQ == false)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Введите  требуемый объем оперативной памяти: ");
                Console.ResetColor();

                ramsize_str = Console.ReadLine();
                tryQQ = uint.TryParse(ramsize_str, out ramsize);
                Console.WriteLine();

            }


            List<Computer> computers2 = Сomputers
                .Where(c => c.RAMsize >= ramsize)
                .ToList();

            if (computers2.Count() == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Нет в наличии!");
                Console.ResetColor();
                Console.WriteLine();
            }
            else
            {
                foreach (Computer c in computers2)
                    Console.WriteLine("Код - " + c.Code + "; Бренд - " +
                        c.ComputerBrand + "; Процессор - " + c.Processor +
                        "; Частота процессора - " + c.FrequencyProcessor +
                        "; Объем оперативной памяти - " + c.RAMsize +
                        "; Объем жесткого диска - " + c.HardDisk +
                        "; Видеокарта - " + c.VideoCarta + "; Операционная система - " +
                        c.OperatingSystem + "; Цена - " + c.Price + "; Имеется в наличии - " + c.Number + "\n");
            }





            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Список по возрастанию цены:\n");
            Console.ResetColor();

            Console.WriteLine();
            var computers3 = Сomputers
               .OrderBy(c => c.Price)
                .ToList();
            foreach (var c in computers3)
                Console.WriteLine("Код - " + c.Code + "; Бренд - " + c.ComputerBrand + "; Операционная система - " + c.OperatingSystem + "; Цена - " + c.Price + "; Имеется в наличии - " + c.Number + "\n");



            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Типы процессоров, имеющиеся в наличии:\n");
            Console.ResetColor();

            Console.WriteLine();
            var computers4 = Сomputers
                .OrderBy(c => c.FrequencyProcessor)
                .ToList();
            foreach (var c in computers4)
            {
                Console.WriteLine("Бренд - " + c.ComputerBrand + ";   Процессор - " + c.Processor + ";   Частота процессора - " + c.FrequencyProcessor + "\n");


            }
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Самый дорогой и самый бюджетный компьютеры:\n");
            Console.ResetColor();

            Console.WriteLine();
            List<Computer> computers5 = Сomputers;
            double min = computers5.Min(m => m.Price);
            double max = computers5.Max(m => m.Price);
            Console.WriteLine("Самый дорогой компьютер за - " + max + "\n" + "самый бюджетный компьютер за - " + min);




            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\nКомпьютеры, имеющиеся в наличии больше 30 штук");
            Console.ResetColor();

            uint namber = 30;
            Console.WriteLine();
            List<Computer> computers6 = Сomputers
                .Where(c => c.Number >= namber)
                .ToList();
            foreach (Computer c in computers6)
                Console.WriteLine("Код - " + c.Code + "; Бренд - " + c.ComputerBrand + "; Процессор - " + c.Processor + "; Частота процессора - " + c.FrequencyProcessor + "; Объем оперативной памяти - " + c.RAMsize + "; Объем жесткого диска - "
                    + c.HardDisk + "; Видеокарта - " + c.VideoCarta + "; Операционная система - " + c.OperatingSystem + "; Цена - " + c.Price + "; Имеется в наличии - " + c.Number + "\n");



            Console.ReadKey();

        }



    }

}
