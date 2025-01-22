using yes;

List<Sebessegkategoria> items = new List<Sebessegkategoria>();

List<int> utas_1 = new List<int>();
List<int> utas_2 = new List<int>();


using (StreamReader reader = new StreamReader("C:\\Users\\Ny20VisegrádiT\\source\\repos\\yes\\yes\\src\\utasszallitok.txt"))
{
    while (!reader.EndOfStream)
    {
        string[] array = reader.ReadLine().Split(';');

        if (array.Length >= 7)
        {
            items.Add(new Sebessegkategoria(array[0], double.Parse(array[1]),array[2], array[3], double.Parse(array[4]), double.Parse(array[5]), double.Parse(array[6])));
        }
    }
}
Console.WriteLine("3.feladat: \n");
foreach (var item in items)
{
    Console.WriteLine($"{item.tipus}");
}


Console.WriteLine("4.feladat: \n");

Console.WriteLine($"Adatsorok száma: {items.Count()}");

Console.WriteLine("5.feladat: \n");

Console.WriteLine($"A Boeing típusok száma: {items.Where(n => n.tipus.Contains("Boeing")).Count()}");

Console.WriteLine("7.feladat: \n");

foreach (var item in items)
{
    if (item.utas.Contains('-'))
    {
        utas_1.Add(int.Parse(item.utas.Split('-')[0]));
        utas_1.Add(int.Parse(item.utas.Split('-')[0]));
    }
    else
    {
        utas_1.Add(int.Parse(item.utas));
    }
}








