
void PrintArray(string[] coll)
{
    // Принимает в аргументе массив и печатает его в консоль.

    Console.Write("массив: ");
    for (int i = 0; i < coll.Length; i++)
    {
        Console.Write(coll[i]+ ", ");
    }
    Console.WriteLine("");
}