using System;
using System.IO;
using System.Collections.Generic;

namespace Test;

public static class InputFile
{
    public static bool TryReadEquationsFromFile(string filePath, out List<QuadraticEquation> equations)
    {
        equations = [];
        StreamReader reader;

        if (File.Exists(filePath))
            reader = File.OpenText(filePath);
        else
            return false;

        string line;

        while ((line = reader.ReadLine()) != null)
        {
            Console.WriteLine("Line | " + line);

            if (TryConvertLineToEquation(line, out QuadraticEquation equation))
                equations.Add(equation);
        }

        return true;
    }

    public static bool TryConvertLineToEquation(string line, out QuadraticEquation equation)
    {
        equation = new QuadraticEquation();

        string[] numbers = line.Split(' ');

        if (numbers.Length == 3
                && double.TryParse(numbers[0], out double a)
                && double.TryParse(numbers[1], out double b)
                && double.TryParse(numbers[2], out double c))
        {
            equation.A = a;
            equation.B = b;
            equation.C = c;
            return true;
        }
        else
        {
            return false;
        }
    }
}