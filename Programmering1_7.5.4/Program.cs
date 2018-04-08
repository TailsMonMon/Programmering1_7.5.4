using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmering1_7._5._4 {
    class Program {
        static void Main(string[] args) {
            //string str;
            //do {
            //    Console.WriteLine("Vill du fortsätta loopen?");
            //    str=Console.ReadLine();
            //} while(str = "j");
            //Felmeddelande: CS0029 
            //Cannot implicitly convert type 'string' to 'bool'
            //
            //Add anoter = so it becomes an relation operator. As it is now, the program is trying to convert the string to an bool.

            string str;
            do {
                Console.WriteLine("Vill du fortsätta loopen?");
                str=Console.ReadLine();
            } while(str=="j");
        }
    }
}
