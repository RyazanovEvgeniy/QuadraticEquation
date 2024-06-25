using System;
using System.Collections.Generic;

namespace Test;

public struct QuadraticEquation(double a, double b, double c)
{
    public double A { get; set; } = a;
    public double B { get; set; } = b;
    public double C { get; set; } = c;

    public readonly bool TrySolve(out List<double> result)
    {
        result = [];

        double D = Math.Pow(B, 2) - (4 * A * C);

        if (D >= 0.0)
        {
            if (D > 0.0)
            {
                result.Add((-B + Math.Sqrt(D)) / (2 * A));
                result.Add((-B - Math.Sqrt(D)) / (2 * A));
            }
            else
            {
                result.Add(-B / (2 * A));
            }
            return true;
        }
        else
        {
            return false;
        }
    }
}