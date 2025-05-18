using oop.demo;
using oop.deom;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Lite Vino50 = new Lite();
        Vino50.BrandName = "YAMAHA";
        Vino50.ModelName = "VINO";
        Vino50.CC = 50;
        Vino50.Colors = enColors.Red;
        Vino50.OilType = enOilType.Type95;
        Console.WriteLine(Vino50.BaseInfor);
        Console.WriteLine();

        Console.WriteLine("顏色枚舉類型所有元素為:");
        foreach (int s in Enum.GetValues(typeof(enColors)))
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();

        Console.WriteLine("樣式枚舉類型所有元素為:");
        foreach (int s in Enum.GetValues(typeof(enStyles)))
        {
            Console.WriteLine(s);
        }

        Console.WriteLine();

        Console.WriteLine("寵物枚舉類型所有元素為:");
        foreach (int p in Enum.GetValues(typeof(enPetType)))
        {
            Console.WriteLine(p);
        }

        foreach (string pn in Enum.GetNames(typeof(enPetType)))
        {
            Console.WriteLine(pn);
        }

        Console.Write("按任意鍵結束 ...");
        Console.ReadKey();
    }
}
