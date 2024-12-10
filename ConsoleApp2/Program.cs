using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        /// <summary>
        /// 7. Поиск элемента по условию (найти первый и последний элементы, в которых длина строки больше 3 символов).
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string[] people = { "Tom", "Sam", "Bob", "Kate", "Tom", "Alice" };
            Array.Sort(people,1,3);
            //string first = Array.Find(people, person => person.Length>3);
            //string last = Array.FindLast(people, person => person.Length > 3);
            //string[] ravno = Array.FindAll(people, person => person.Length == 3);

            //Console.WriteLine(first);
            foreach (string x in people) { Console.WriteLine(x); }
            //Console.WriteLine(last);
            //Console.WriteLine(ravno);
            //Console.WriteLine(people);
            Console.Read();
        }
    }
}
