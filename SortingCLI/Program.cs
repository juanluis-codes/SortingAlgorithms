// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

static List<int> RandomList()
{
    List<int> list = new List<int>();
    Random random = new Random();

    for (int i = 0; i < 100; i++)
    {
        list.Add(random.Next(0, 100));
    }

    return list;
}