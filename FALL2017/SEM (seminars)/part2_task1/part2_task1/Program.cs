﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part2_task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("n=");
            int n = Convert.ToInt32(Console.ReadLine());
            int amount = 0;
            for ( int i = 1; i != n; i++)
            {
                amount = amount + i;
            }
            Console.WriteLine("Сумма всех натуральных чисел, меньших введённого числа равна " + amount);
            Console.Read();
        }
    }
}
