﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FPT
{
    internal class B4UCLN
    {
        static void Main()
        {
            int a, b, c;
            Console.WriteLine("Nhap a:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap b:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap c:");
            c = Convert.ToInt32(Console.ReadLine());
            int UCLN = 1;
            // Console.Write($"Uoc chung {a} & {b} : ");
            if (a < b && c < b)
            {
                for (int i = 1; i <= b; i++)
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        UCLN = i;
                        Console.Write(UCLN + " " );
                    }
                Console.WriteLine();
            }
            else if (a < c && b < c)
            {
                for (int i = 1; i <= c; i++)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        UCLN = i;
                        Console.Write(UCLN + " ");

                    }
                }
                    Console.WriteLine();
            }
            else
            {
                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0 && b % i == 0 && c % i == 0)
                    {
                        UCLN = i;
                        Console.Write(UCLN + " ");

                    }

                }
                    Console.WriteLine();
            }
            Console.WriteLine("=================================================");
                Console.WriteLine($"Uoc chung lon nhat cua {a} & {b} & {c} la {UCLN} ");
        }
    }
}
