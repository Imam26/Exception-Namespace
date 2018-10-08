using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*1.Создать два проекта в решении: библиотека классов и консольное приложение. 
 Подключить библиотеку в консольное приложение.
Добавить Класс Person в библиотеку и добавить 
класс со статическим методом который принимает 
в качестве параметра переменную типа Person и 
возвращает строку, состоящую из нескольких свойств класса Person. 
Вызвать в консольном  приложении метод используя полное пространство имен при обращении к нему.
*/
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassLibrary1.Person person = new ClassLibrary1.Person("Ахметов", "Ермек", "Ержанович");

            string result = ClassLibrary1.Person.GetPerson(person);
            Console.WriteLine(result);
        }
    }
}
