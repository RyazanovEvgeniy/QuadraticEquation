using System;
using System.Collections.Generic;
using Test;

Console.WriteLine("QuadraticEquation project");
Console.WriteLine("_________________________");
Console.WriteLine("Enter file path: (For example - 'D:\\input.txt')");

string inputFile = Console.ReadLine();

if (InputFile.TryReadEquationsFromFile(inputFile, out List<QuadraticEquation> equations))
{
    Console.WriteLine("_________________________________________________________________\n");

    foreach (QuadraticEquation equation in equations)
    {
        Console.WriteLine($"Equation: {equation.A}*x^2 + {equation.B}*x + {equation.C} == 0");

        if (equation.TrySolve(out List<double> result))
        {
            Console.WriteLine("Result:");
            for (int i = 0; i < result.Count; i++)
                Console.WriteLine($"{i + 1}) {result[i]}");
        }
        else
        {
            Console.WriteLine("Equation has no solution ");
        }
    }
}
else
{
    Console.WriteLine($"Error: File {inputFile} not found");
}

Console.Read();