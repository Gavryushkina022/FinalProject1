
string[] array = new string[] { "hello", "2", "world", ":-)", "123", "78" };

string[] FilterArray(string[] array)
{
    string str = "";
    int i = 0;
    while (i < array.Length)
    {
        if (array[i].Length <= 3)
        {
            str += i != (array.Length - 1) ? array[i] + "," : array[i];
        }
        i++;
    }
    return str.Split(",");
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(i != (array.Length - 1) ? array[i] + "," : array[i]);
    }
    Console.Write("]");
}

PrintArray(FilterArray(array));