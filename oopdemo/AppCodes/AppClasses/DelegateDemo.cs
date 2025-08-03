namespace oop.demo;

public class DelegateDemo : BaseClass
{
    public delegate void Arithmetic(int a, int b);
    public int int_value = 0;
    public string str_value = "";

    public void Run()
    {
        int_value = 0;
        Arithmetic myevent = new Arithmetic(Add);
        myevent(10, 7);
        myevent = Sub;
        myevent(10, 7);

        myevent = Add;
        myevent += Sub;
        myevent(10, 7);
    }

    /// <summary>
    /// 加法 (A + B)
    /// </summary>
    /// <param name="a">A</param>
    /// <param name="b">B</param>
    public void Add(int a, int b)
    {
        int_value += (a + b);
        str_value = "事件：Add ";
        str_value = $"{a} + {b} = {a + b}";
        str_value = $"累計：{int_value}";
        Console.WriteLine(str_value);
    }
    /// <summary>
    /// 
    /// </summary>
    /// <param name="a"></param>
    /// <param name="b"></param>
    public void Sub(int a, int b)
    {
        int_value += (a + b);
        str_value = "事件：Sub";
        str_value = $"{a} - {b} = {a - b}";
        str_value = $"累計：{int_value}";
        Console.WriteLine(str_value);
    }

    public void Multip(int a, int b)
    {
        int_value += (a * b);
        str_value = "事件：Multip";
        str_value = $"{a} x {b} = {a * b}";
        str_value = $"累計：{int_value}";
        Console.WriteLine(int_value);
    }
}