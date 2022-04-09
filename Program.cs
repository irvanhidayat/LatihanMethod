using System;

namespace LtihanMethodIrvan;

public class Numbers
{
    public int FindMinimum(int number1, int number2)
    {
        int minim;
        if (number1 < number2)
        {
            minim = number1;
        }
        else
        {
            minim = number2;
        }
        return minim;
    }

    public int FindMinimum(int number1, int number2, int number3)
    {
        int minim;
        if (number1 < number2)
        {
            minim = number1;
        }
        else
        {
            minim = number2;
        }
        if (minim < number3)
        {
            minim = minim;
        }
        else
        {
            minim = number3;
        }

        return minim;
    }
    public int FindMaximum(int number1, int number2)
    {
        int max;
        if (number1 > number2)
        {
            max = number1;
        }
        else
        {
            max = number2;
        }
        return max;
    }
    public int FindMaximum(int number1, int number2, int number3)
    {
        int max;
        if (number1 > number2)
        {
            max = number1;
        }
        else
        {
            max = number2;
        }
        if (max > number3)
        {
            max = max;
        }
        else
        {
            max = number3;
        }
        return max;
    }
}
class Program
{
    static void Main(string[] args)
    {
        Numbers number = new Numbers();

        Console.WriteLine("Minimum #1: {0}", number.FindMinimum(3, 1));
        Console.WriteLine("Minimum #2: {0}", number.FindMinimum(3, 2, 4));
        Console.WriteLine();
        Console.WriteLine("Miaximum #1: {0}", number.FindMaximum(3, 1));
        Console.WriteLine("Miaximum #2: {0}", number.FindMaximum(3, 2, 4));

        Console.ReadKey();
    }
}