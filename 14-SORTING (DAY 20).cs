﻿using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;



class Results
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> a = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList();
        int x = 0;
        int y = a.Count;
            
        for (int i = 0; i < n; i++)
        {
            // Track number of elements swapped during a single array traversal
            int numberOfSwaps = 0;

            for (int j = 0; j < n - 1; j++)
            {
                // Swap adjacent elements if they are in decreasing order
                if (a[j] > a[j + 1])
                {
                    (a[j], a[j + 1]) = (a[j+1], a[j]);
                    numberOfSwaps++;
                }

               
                
            }

            // If no elements were swapped during a traversal, array is sorted
            if (numberOfSwaps == 0)
            {
                break;
            }

            x += numberOfSwaps;


        }

        Console.WriteLine("Array is sorted in {0} swaps.", x);
        Console.WriteLine("First Element: {0}", a[0]);
        Console.WriteLine("Last Element: {0}", a[y - 1]);
    }
}
