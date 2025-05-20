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

        Car car = new Car();
        car.SetCarData(50, 30, 20);
        int int_volume = car.GetCarVolume();
        Console.WriteLine("車子的體積 = 長度 x 寛度 x 高度");
        Console.WriteLine($"= {car.Length} x {car.Width} x {car.Height}");
        Console.WriteLine($"= {int_volume}");

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
