﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JPanAdvDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {

            MyLinkedList<int> myLL = new MyLinkedList<int>();
            myLL.AddEnd(5);
            myLL.AddEnd(42);
            myLL.AddEnd(18);

            foreach(int item in myLL)
            {
                Console.WriteLine(item);
            }


            //Derp derp = null;

            //if (derp?.x == 3)
            //{
            //    Console.WriteLine("Hello World");
            //}
            //Console.WriteLine("Hello World");
            int input = int.Parse(Console.ReadLine());
            int divisor = 1073741824;
            string output = "";
            while (divisor != 1)
            {
                if (input % divisor != input)
                {
                    output += "1";
                    input -= divisor;
                }
                else
                {
                    output += "0";
                }
                divisor = divisor / 2;
            }
        }
    }
}
