﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomList
{
    class Program
    {



        static void Main(string[] args)
        {
            CustomList<int> testList = new CustomList<int>();
            testList.Add(3);
           //testList.Add(4);
            Console.WriteLine(testList.ToString());
            Console.ReadLine();
            //actual = testList[0];
        }
    }
}
