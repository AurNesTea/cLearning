namespace oop.demo;

/// <summary>
/// 泛型範例類別
/// </summary>
/// <typeparam name="T"></typeparam>
public class GenericDemo<T>
{
    public List<T> DataList { get; set; } = new List<T>();

    public void AddItem(T item)
    {
        DataList.Add(item);
    }

    public T GetItem(int index)
    {
        return DataList[index];
    }

    public List<T> GetAllItems()
    {
        return DataList;
    }
}