using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_Length
{
    class Program
    {
        static void Main(string[] args)
        {
            string one = "apple ban";

            string[] newArray = one.Split(' ');

            for (int i = 0; i < newArray.Length; i++)
            {
                Console.Write(newArray[i] = newArray[i] + ' ' + newArray[i].Length + (newArray.Length - 1 == i ? "" : ","));

            }
            

            Console.ReadLine();

        }
    }
}
