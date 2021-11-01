using System.CodeDom.Compiler;
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

class Result
{
    /*
     * Complete the 'plusMinus' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */
    static int positiveNumber;
    static int negativeNumber;
    static int zeroNumber;

    public static void plusMinus(List<int> arr)
    {
        foreach (var item in arr)
        {
            if (item != 0)
            {
                if (item > 0)
                    positiveNumber++;
                else
                    negativeNumber++;
            }
            else
                zeroNumber++;
        }

        double positiveProportion = (double)positiveNumber / arr.Count;
        double negativeProportion = (double)negativeNumber / arr.Count;
        double zeroesProportion   = (double)zeroNumber / arr.Count;

        Console.WriteLine(System.Math.Round(positiveProportion, 6));
        Console.WriteLine(System.Math.Round(negativeProportion, 6));
        Console.WriteLine(System.Math.Round(zeroesProportion, 6));
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.plusMinus(arr);
    }
}