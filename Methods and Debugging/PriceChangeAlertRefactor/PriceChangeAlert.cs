using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        double border = double.Parse(Console.ReadLine());
        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++)
        {
            double c = double.Parse(Console.ReadLine());
            double div = Proc(last, c);
            bool isSignificantDifference = isDifference(div, border);

            string message = Get(c, last, div, isSignificantDifference);
            Console.WriteLine(message);
            last = c;
        }
    }
    private static string Get(double c, double last, double difference, bool etherTrueOrFalse)

    {
        string to = "";
        if (difference == 0)
        {
            to = string.Format($"NO CHANGE: {c}");
        }
        else if (!etherTrueOrFalse)
        {
            to = string.Format($"MINOR CHANGE: {last} to {c} ({difference*100:F2}%)");
        }
        else if (etherTrueOrFalse && (difference > 0))
        {
            to = string.Format($"PRICE UP: {last} to {c} ({difference*100:F2}%)");
        }
        else if (etherTrueOrFalse && (difference < 0))
            to = string.Format($"PRICE DOWN: {last} to {c} ({difference*100:F2}%)");
        return to;
    }
    private static bool isDifference(double difference, double isDiff)
    {
        if (Math.Abs(difference) >= isDiff)
        {
            return true;
        }
        return false;
    }
    private static double Proc(double l, double c)
    {
        double r = (c - l) / l;
        return r;
    }
}
