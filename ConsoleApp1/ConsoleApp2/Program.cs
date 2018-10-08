using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.	Создать класс со строковыми и числовыми константами в отдельном файле.
  В консольном приложении вывести эти константы на экран.*/

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Constant constant = new Constant();
            Console.WriteLine(constant.Pi);
            Console.WriteLine(constant.CountOfMonth);
            Console.WriteLine(constant.PlanetName);
            Console.WriteLine(constant.StarName);
        }
    }
}
