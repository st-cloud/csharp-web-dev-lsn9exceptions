﻿using System;
using System.Collections.Generic;

namespace csharp_web_dev_lsn9exceptions
{
    class Program
    {
        static double Divide(double x, double y)
        {
            if (y == 0)
            {
                throw new ArgumentOutOfRangeException("Cannot divide by 0.");
            }
            return x / y;
        }

        static int CheckFileExtension(string fileName)
        {
            if (fileName == "" || fileName == null)
            {
                throw new ArgumentNullException("Must submit a named file.");
            }
            else if (fileName.Substring(fileName.Length - 3) == ".cs")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(Divide(4, 0));
            }
            catch(ArgumentOutOfRangeException itsAZero)
            {
                Console.WriteLine(itsAZero);
            }


            Dictionary<string, string> students = new Dictionary<string, string>();
            students.Add("Carl", "Program.cs");
            students.Add("Brad", "");
            students.Add("Elizabeth", "MyCode");
            students.Add("Stefanie", "CoolProgram.cs");

            foreach (string file in students.Values)
            {
                try
                {
                    Console.WriteLine(CheckFileExtension(file));
                }
                catch(ArgumentNullException ghostFile)
                {
                    Console.WriteLine(ghostFile);
                }

            }
        }
    }
}
