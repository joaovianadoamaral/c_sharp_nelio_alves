using System;

class Program
{
    static void Main()
    {
        int[] operations = Sum2Num(2, 3);

        Console.WriteLine(operations[0]);
        Console.WriteLine(operations[1]);
    }

    static int[] Sum2Num(int num1, int num2)
    {
        int sum = num1 + num2;
        int times = num1 * num2;

        int[] operations = new int[num1];
        operations[0] = sum;
        operations[1] = times;


        return operations;
    }

}
