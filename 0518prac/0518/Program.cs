using oop.demo;

internal class Program
{
    private static void Main(string[] args)
    {
        // var person = new Person();
        // var daming = new Daming();
        // var xiaohua = new Xiaohua();
        // Console.WriteLine(person.PersonInfor());
        // Console.WriteLine(daming.PersonInfor());
        // Console.WriteLine(xiaohua.PersonInfor());

        // Console.WriteLine("按任意鍵結束 ...");
        // Console.ReadKey();


        var child1 = new Child1(20000);
        child1.GetPaid(3);
        Console.WriteLine("第一種多形案例，選擇繼承父親財產");
        Console.WriteLine(child1.Information());
        Console.WriteLine();

        var child2 = new Child2(20000);
        child2.GetPaid(3);
        Console.WriteLine("第二種多形案例，選擇不繼承父親財產");
        Console.WriteLine(child2.Information());
        Console.WriteLine();

        Console.Write("按任意鍵結束 ...");
        Console.ReadKey();
    }
}