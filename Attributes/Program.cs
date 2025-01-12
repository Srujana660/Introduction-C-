using System;
using System.Collections.Generic;
public class MainClass
{
    private static void Main()
    {
        Calculator.Add(new List<int>(){1, 2, 3 });
    }
}
public class Calculator
{
    [ObsoleteAttribute("Use Add(List<int> Numbers) Method")]
    public static int Add(int Firstnumber, int Secondnumber)
    {
        return Firstnumber + Secondnumber;
    }
    public static int Add(List<int> Numbers)
    {

        int sum = 0;
        foreach (int Number in Numbers)
        {
            sum += Number;
        }
        return sum;
    }
}

