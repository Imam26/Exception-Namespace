using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*2.	Написать программу, которая обращается к элементам массива по индексу и выходит за его пределы. 
 * После обработки исключения вывести в финальном блоке сообщение о завершении обработки массива.*/

namespace SecondTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] mas = new int[10] {0,1,2,3,4,5,6,7,8,9};
     
            try
            {
                for (int i = 0; i <= 10; i++)
                {
                    Console.WriteLine("{0}", mas[i]);
                }
            }
            catch(IndexOutOfRangeException outException)
            {
                Console.WriteLine(outException.Message);
            }
            finally
            {
                Console.WriteLine("Обработка массива завершена!!!");
            }
        
        }

    }
}
