// See https://aka.ms/new-console-template for more information

using System;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Xml;
class Calculate
{
    private static void Main(string[] args)
    {
        calculator01("寫九九乘法表 , 每三個一組");
        calculator02("寫九九乘法表");
        drawstar01("設計一個由 * 號組成的三角形 5 x 5 靠左,由小至大");
        drawstar02("設計一個由 * 號組成的三角形 5 x 5 置中,由小至大");
        drawstar03("設計一個由 * 號組成的三角形 5 x 5 置中,由大至小");
        drawstar04("設計一個由 * 號組成的三角形 5 x 5 靠右,由大至小");
        Waiting();

    }

    private static void drawstar04(string titleName)
    {
        ShowTitle(titleName);

        for (int i = 5; i >= 1; i--)
        {
            String space = "".PadLeft((5-i), ' ');
            Console.Write(space);
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

    }

    private static void drawstar03(string titleName)
    {
        ShowTitle(titleName);

        String space = "";

        for (int i = 5; i >= 1; i--)
        {
            space = "".PadLeft((6-i), ' ');
            Console.Write(space);
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }
    }

    private static void drawstar02(string titleName)
    {
        ShowTitle(titleName);

        String space = "";
        String star = "* ";

        for (int i = 1; i <= 5; i++)
        {
            space = "".PadLeft((5-i), ' ');
            Console.Write(space);
            for (int j = 1; j <= i; j++)
            {
                Console.Write(star);
            }
            Console.WriteLine();
        }

    }

    private static void drawstar01(string titleName)
    {
        ShowTitle(titleName);

        for (int i = 1; i <= 5; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("* ");
            }
            Console.WriteLine();
        }

    }

    private static void calculator02(string titleName)
    {
        ShowTitle(titleName);

        //宣告變數
        string x = "";
        string y = "";
        string z = "";
        char space = ' ';

        //九九乘法表
        for (int i = 1; i <= 9; i += 1)
        {
            x = i.ToString().PadLeft(2, space);
            for (int j = 1; j <= 9; j += 1)
            {
                y = j.ToString().PadLeft(2, space);
                z = (i * j).ToString().PadLeft(2, space);
                Console.Write("{0}x{1}={2}", y, x, z);
            }
            Console.WriteLine();
        }

    }

    static void calculator01(string titleName)
    {
        ShowTitle(titleName);

        //宣告變數
        string x = "";
        string y = "";
        string z = "";
        char space = ' ';

        //九九乘法表
        for (int i=1; i<=9; i+=3)
        {
            for (int j=1; j<=9; j++)
            {
                x = j.ToString().PadLeft(2, space);
                for (int k=i; k<=i+2; k++)
                {
                    y = k.ToString().PadLeft(2, space);
                    z = (j * k).ToString().PadLeft(2, space);
                    Console.Write("{0}x{1}={2}", y, x, z);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        ShowEnding();
    }

    private static void ShowTitle(string titleName)
    {
        //顯示標題列
        Console.WriteLine(new String('-', 50));
        Console.WriteLine("題目：{0}", titleName);
        Console.WriteLine(new String('-', 50));
        Console.WriteLine();
    }


    private static void ShowEnding()
    {
        // 顯示結束列
        Console.WriteLine();
        Console.WriteLine(new String('-', 50));
    }

    private static void Waiting()
    {
        // 等待輸入任意鍵結束.
        Console.Write("按任意鍵結束 ...");
        Console.ReadKey();
    }
}

