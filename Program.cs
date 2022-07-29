
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


string[] LengthFilterV1(string[] inputArray, int maxlen)
{

    int lenoutput = 0;
    for (int i = 0; i < inputArray.Length; i++) {if (inputArray[i].Length <= maxlen)lenoutput++;}
    
    int index = 0;
    string[] outputArray = new string[lenoutput];
    
    for (int j = 0; j < inputArray.Length; j++)
    {
        if(inputArray[j].Length <= maxlen) {outputArray[index] = inputArray[j]; index++;}
    }
    return outputArray;
}