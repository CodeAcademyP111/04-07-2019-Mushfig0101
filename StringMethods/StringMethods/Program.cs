using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Kamran ";


            Console.WriteLine(str.MyIndexOf('r'));
            
            Console.WriteLine(str.MyLastIndexOf('a'));

            int number = 13;
            
            Console.WriteLine(number.CheckNumber());
            Console.ReadLine();
        }
    }

   
   
       
    

}
