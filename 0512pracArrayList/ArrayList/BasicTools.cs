using System;
using System.Collections.Generic;

public class BasicTools
{
    public static void ShowTitle(string titleName)
    {
        //顯示標題列
        Console.WriteLine(new String('-', 50));
        Console.WriteLine("題目：{0}", titleName);
        Console.WriteLine(new String('-', 50));
        Console.WriteLine();
    }

    public static void ShowEnding()
    {
        // 顯示結束列
        Console.WriteLine();
        Console.WriteLine(new String('-', 50));
        Console.WriteLine("執行結束");
        Console.WriteLine(new String('-', 50));
    }

    public static void Waiting()
    {
        // 等待輸入任意鍵結束.
        Console.Write("按任意鍵結束 ...");
        Console.ReadKey();
    }

    /// <summary>
    /// 顯示集合內容
    /// </summary>
    /// <typeparam name="T">集合泛型型別</typeparam>
    /// <param name="list">集合泛型變數</param>
    /// <param name="listName">名稱集合</param>
    /// <param name="titleName">標題集合</param>
    /// <param name="writeLine">是否顯示線條</param>
    public static void ShowList<T>(IList<T> list, string listName, string titleName, bool writeLine)
    {
        string str_type_name = list.GetType().Name;
        Console.WriteLine("{0} {1} :", titleName, listName);
        Console.Write(" ");
        if (list.GetType().IsGenericType && list != null)
        {
            Type itemType = typeof(T);
            if (itemType == typeof(string))
            {
                foreach (string item in (List<string>)list)
                {
                    Console.Write($"{item} ");
                }
            }
            if (itemType == typeof(int))
            {
                foreach (int item in (List<int>)list)
                {
                    Console.Write($"{item} ");
                }
            }
        }
        Console.WriteLine();
        if (writeLine) Console.WriteLine();
    }

}