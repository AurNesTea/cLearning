// See https://aka.ms/new-console-template for more information
using System.ComponentModel.DataAnnotations;
using System.Dynamic;

internal class PersonalInfor{
    static DateTime birthday;
    static double height;
    static double weight;
    private static void Main(string[] args)
    {
        GetInfor();
        Display();
        Console.Write("Press any key to end the program");
        Console.ReadKey();
    }

    static void GetInfor()
    {
        birthday = new DateTime(1985, 10, 18);
        while (true)
        {
            Console.Write("請輸入身高(cm)：");
            string heightInput = Console.ReadLine();
            
            double tempHeight;
            bool isNum = double.TryParse(heightInput, out tempHeight);
            if (!isNum)
            {
                Console.WriteLine("輸入內容不是數字，請重新輸入");
                continue;
            }

            if (!HeightCheck(tempHeight))
            {
                Console.WriteLine("身高數值應介於100 ~ 250之間，請重新輸入");
                continue;
            }
            
            height = tempHeight;
            break;   
        }

        while (true)
        {
            Console.Write("請輸入體重(kg)：");
            string weightInput = Console.ReadLine();

            double tempWeight;
            bool isNum = double.TryParse(weightInput, out tempWeight);
            if (!isNum)
            {
                Console.WriteLine("輸入內容不是數字，請重新輸入");
                continue;
            }

            if (!WeightCheck(tempWeight))
            {
                Console.WriteLine("體重數值應介於40 ~ 120之間，請重新輸入");
                continue;
            }

            weight = tempWeight;
            break;
        }
        
    }
    static void Display()
    {
        Console.WriteLine("Kevin's Infor is below");
        Console.WriteLine("Birth: {0}", birthday);
        Console.WriteLine("Height: {0}", height);
        Console.WriteLine("Weight: {0}", weight);
        
        double bmi = CalBMI();
        Console.WriteLine("BMI: {0:F2}", bmi);
        Console.WriteLine("BMI Level: {0}", GetBmiLevel(bmi));
    }

    static bool HeightCheck(double h)
    {
       return h >= 100 && h <= 250;
    }

    static bool WeightCheck(double w)
    {
        return w >= 40 && w <= 120;
    }

    static double CalBMI()
    {
        return weight / Math.Pow(height/100.0, 2);
    }

    static string GetBmiLevel(double bmi)
    {
        if (bmi < 18.5)
            return "過輕";
        else if (bmi < 24)
            return "正常";
        else if (bmi < 30 )
            return "輕度肥胖";
        else if (bmi < 35)
            return "中度肥胖";
        else
            return "過度肥胖";
    }
}
