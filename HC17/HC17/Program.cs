﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            string line;

            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader("c:\\kittens.in");
            while ((line = file.ReadLine()) != null)
            {
                //Console.WriteLine(line);
                counter++;
            }

            file.Close();
            Console.WriteLine(counter);

            // Suspend the screen.
            Console.ReadLine();
        }
    }


}
