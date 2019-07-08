using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringMethods
{
    public static class Extension
    {
        public static int MyIndexOf(this string str, char IndexOfParametr)
        {
             int IndexOfResult = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == IndexOfParametr)
                {
                    IndexOfResult = i;
                    break;   
                }
            }
            if (IndexOfResult != 0)
            {
                return IndexOfResult;
            }
            else
            {
                return -1;
            }
        }


        public static int MyLastIndexOf(this string strL, char LastIndexOfParametr)
        {

            int lastResult = 0;
            for (int j = strL.Length - 1; j >= 0; j--)
            {
                if (strL[j] == LastIndexOfParametr)
                {
                    lastResult = j;
                }
            }

            if (lastResult != 0)
            {
                return lastResult;
            }
            else
            {
                return -1;
            }
        }

        public static int CheckNumber(this int number)
        {

             int identify = 0;
            for (int i = 1; i <= number; i++)
            {

                if (number % i == 0)
                {
                    identify++;
                    
                }
            }

            if (identify != 2)
            {
                return identify;
           
            }
            else {
                return identify;
            }

            // Methodun type-ni string de yazmaq olardi.
            //Consola birbasa yazi cixarmaq ucun.
        }
    }
}
