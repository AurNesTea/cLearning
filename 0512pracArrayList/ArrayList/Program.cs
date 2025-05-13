// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

class ArrayList
{
    static void Main(string[] args)
    {
        // pracArray01("一維陣列範例");
        // BasicTools.Waiting();

        // pracMultiArray01("多維陣列範例");
        // BasicTools.Waiting();

        // pracList01("List 陣列範例");
        // BasicTools.Waiting();

        pracList02("List 陣列加入(插入)、移除值範例");
        BasicTools.Waiting();
    }

    private static void pracArray01(string titleName)
    {
        //show Title
        BasicTools.ShowTitle(titleName);

        // declare variables
        int[] numberArray1;
        int[] numberArray2 = new int[5];
        int[] intArray1 = new int[]{1, 3, 5, 7, 9};
        int[] intArray2 = {2, 4, 6, 8, 0};
        string[] weekDays = new string[]{"Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
        string[] weekendDays = {"Saturday", "Sunday"};
        string[] userNames = {"Amber", "Belle", "Carol", "Dempsey", "Emma"};

        numberArray1 = new int[] { 1, 2, 3, 4, 5 };
        numberArray2[0] = 6;
        numberArray2[1] = 7;
        numberArray2[2] = 8;
        numberArray2[3] = 9;
        numberArray2[4] = 10;

        //show variables

        Console.Write("陣列 numberArray1：");
        foreach (var item in numberArray1)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine("\r\n");

        Console.Write("陣列 numberArray2：");
        foreach (var item in numberArray2)
        {
            Console.Write("{0}, ", item);
        }
        Console.WriteLine("\r\n");

        Console.Write("陣列 intArray1：");
        foreach (var item in intArray1)
        {
            Console.Write($"{item}, ");
        }
        Console.WriteLine("\r\n");

        Console.Write("陣列 intArray2：");
        foreach (var num in intArray2)
        {
            Console.Write($"{num}, ");
        }
        Console.WriteLine("\r\n");
        
        Console.Write("陣列 weekDays：");
        foreach (var weekDay in weekDays)
        {
            Console.Write($"{weekDay}, ");
        }
        Console.WriteLine("\r\n");

        Console.Write("陣列 weekendDays：");
        foreach (var weekendDay in weekendDays)
        {
            Console.Write($"{weekendDay}, ");
        }
        Console.WriteLine("\r\n");
        
        Console.Write("陣列 userName：");
        foreach (var userName in userNames)
        {
            Console.Write($"{userName}, ");
        }
        Console.WriteLine("\r\n");

        // 等待輸入任意鍵結束.
        BasicTools.ShowEnding();
    }

    private static void pracMultiArray01(string titleName)
    {
        // 顯示標題列
        BasicTools.ShowTitle(titleName);

        // 宣告變數
        string[,] arrayMember = new string[3,2]
        {
            {"Normal", "一般會員"},
            {"VIP", "VIP會員"},
            {"Noble", "尊爵會員"}
        };
        int[,] array2D1 = new int[,]
        {
            { 1, 38 },
            { 2, 62 },
            { 3, 36 },
            { 4, 58 }
        };
        int[,] array2D2 = new int[,]
        {
            { 30, 25 },
            { 42, 40 },
            { 52, 60 },
            { 27, 38 }
        };
        int[,,] array3D = new int[2, 3, 4]
        {
            {
                { 1, 2, 3 , 4},
                { 5, 6, 7 ,8} ,
                { 9, 10, 11 ,12}
            },
            {
                { 13, 14, 15 , 16},
                { 17, 18, 19 , 20} ,
                { 21, 22, 23 , 24}
            }
        };
        int total = 0;
        int index = 0;

        // 顯示會員資料
        Console.WriteLine("顯示陣列 arrayMember 所有元素值：");
        index = 0;
        foreach (var item in arrayMember)
        {
            Console.Write($"{item}");
            index++;
            if (index % 2 == 0)
                Console.Write("  ");
            else
                Console.Write("=");
        }
        Console.WriteLine("總只有：{0} 筆記錄!!", arrayMember.Length);
        Console.WriteLine();

        Console.WriteLine("顯示 array2D1 第二維元素值及第二維加總：");
        total = 0;
        index = 0;
        for (int i = 0; i < array2D1.Length; i += array2D1.Rank)
        {
            if (i > 0) Console.Write("+");
            Console.Write($"{array2D1[index, 1]}");
            total += array2D1[index, 1];
            index++;
        }
        Console.WriteLine("  合計為：{0} ", total);
        Console.WriteLine();

        Console.WriteLine("顯顯示 array2D2 所有元素值及所有元素值加總：");
        total = 0;
        index = 0;
        for (int i = 0; i < array2D2.Length; i += 1)
        {
            if (i > 0) Console.Write(" + ");
            if (i % 2 == 0)
            {
                total += array2D2[index, 1];
                Console.Write($"{array2D2[index, 1]}");
            }
            else
            {
                total += array2D2[index, 0];
                Console.Write($"{array2D2[index, 0]}");
            }
        }
        Console.WriteLine("  合計為：{0} ", total);
        Console.WriteLine();

        Console.WriteLine("顯示 array3D 資料資訊：");
        Console.WriteLine($"這是一個 {array3D.Rank} 維陣列 , 共有 {array3D.Length} 個元素");
        for (int i = 0; i < array3D.Rank; i++)
        {
            Console.WriteLine("第 {0}維陣列共有 {1}個元素", i+1, array3D.GetLength(i));
        }
        Console.WriteLine();

        BasicTools.ShowEnding();
    }

    static void pracList01(string titleName)
    {
        // 顯示標題列
        BasicTools.ShowTitle(titleName);

        // 宣告List變數
        List<int> numberList01 = new List<int>();
        List<int> numberList02 = new List<int>(5) { 1, 2, 3, 4, 5 };
        List<string> weekList = new List<string> { "Mon", "Tue", "Wed", "Thrus", "Fri", "Sat", "Sun" };

        numberList01.Add(1);
        numberList01.Add(2);
        numberList01.Add(3);
        numberList01.Add(4);
        numberList01.Add(5);

        // 顯示在畫面中
        Console.Write("陣列 numberList1： ");
        foreach (var item in numberList01)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\r\n");

        Console.Write("陣列 numberList2： ");
        foreach (var item in numberList02)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\r\n");

        Console.Write("陣列 weekList： ");
        foreach (var item in weekList)
        {
            Console.Write($"{item} ");
        }
        Console.WriteLine("\r\n");

        //印出結尾
        BasicTools.ShowEnding();
    }

    static void pracList02(string titleName)
    {
        // 顯示標題列
        BasicTools.ShowTitle(titleName);

        // 宣告List變數
        List<string> userList = new List<string> { "劉二", "陳六", "方七" };
        List<string> memberList = new List<string> {"楊四", "王五"};
        List<string> adminList = new List<string> { "許九", "劉十" };

        // 陣列(初始)
        BasicTools.ShowList(userList, "userList", "陣列(初始)", true);


        // 陣列(加入李大,孫三,柳八)
        userList.Insert(0, "李大");
        userList.Insert(2, "孫三");
        userList.Add("柳八");
        BasicTools.ShowList(userList, "userList", "陣列(加入李大,孫三,柳八)", true);

        // 陣列(插入範圍楊四,王五,許九,劉十)
        int int_pos = userList.IndexOf("陳六");
        userList.InsertRange(int_pos, memberList);
        userList.AddRange(adminList);
        BasicTools.ShowList(userList, "userList", "陣列(插入範圍楊四,王五,許九,劉十)", true);

        // 陣列(移除陳六,孫三)
        List<string> removerList01 = new List<string> {"陳六", "孫三"};
        // userList.Remove("陳六");
        // userList.Remove("孫三");
        foreach (var item in removerList01)
        {
            userList.Remove(item);
        }
        BasicTools.ShowList(userList, "userList", "陣列(移除陳六,孫三)", true);

        // 陣列(移除1)
        userList.RemoveAt(1);
        BasicTools.ShowList(userList, "userList", "陣列(移除1)", true);

        // 陣列(移除範圍2,2)
        userList.RemoveRange(2, 2);
        BasicTools.ShowList(userList, "userList", "陣列(移除範圍2,2)", true);

        // 陣列清空
        userList.Clear();
        BasicTools.ShowList(userList, "userList", "清除陣列中所有元素", true);

        // 結尾.
        BasicTools.ShowEnding();
    }

}
