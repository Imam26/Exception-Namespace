using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.	реализовать метод деления двух чисел. Внутри метода проверять входящие параметры. 
 * Если они не заданы, то генерировать исключение ArgumentNullException. 
 * Если делитель равен нулю, то генерировать исключение ArgumentException.*/

namespace FirstTask
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(DivTwoNumbers(3,8));
                Console.WriteLine(DivTwoNumbers(null, null));
            }
            catch(ArgumentNullException nullException)
            {
                Console.WriteLine(nullException.Message);
            }
            catch(ArgumentException argumentException)
            {
                Console.WriteLine(argumentException.Message);
            }
        }

        static double DivTwoNumbers(int? firstNum, int? secondNum)
        {
            if (firstNum == null || secondNum == null)
                throw new ArgumentNullException();
            else if (secondNum == 0)
                throw new ArgumentException();
            return (double)firstNum / (double)secondNum;
        }
    }
}
