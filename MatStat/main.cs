using System.IO;
using System;

class Program
{   
    public static void MatStat(double n)
    {   
        double[] array = new double[100];
        double m = 0, d = 0;
        StreamWriter write_text;
        FileInfo file = new FileInfo("res.txt");
        write_text = file.CreateText();
        write_text.WriteLine("--------- Array ---------");
        for (int i = 1; i <= n; i++) {
            if (i <= 17) {
                array[i] = 1 / Math.Tan(Math.Pow(i, 2));
                write_text.WriteLine("A[" + i + "] = Ctg(" + i + "^2) = " + array[i]);
            } else {
                array[i] = 1 / Math.Sin(i);
                write_text.WriteLine("A[" + i + "] = Sin(" + i + ") = " + array[i]);
            }
            m += (1 / n) * array[i];
            d += (1 / n) * Math.Pow((array[i] - m), 2);
        }
        write_text.WriteLine("--------- End array ---------");
        write_text.WriteLine("m = " + m);
        write_text.WriteLine("D = " + d);
        write_text.Close(); // Закрываем файл
    }

    static void Main()
    {
        Console.WriteLine("Enter n < 100:");
        double n = double.Parse(Console.ReadLine());
        MatStat(n);
    }
}
