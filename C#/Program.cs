string[] CreateStringArray()
{
    Console.Write("Enter size of array ");
    int size = Convert.ToInt32(Console.ReadLine());

    string[] array = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Enter {i} element of array ");
        array[i] = Console.ReadLine();
    }

    return array;
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        Console.Write(array[i] + " ");
}

string[] array = CreateStringArray();
int amount = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
        amount++;

string[] result = new string[amount];
amount = 0;

for (int i = 0; i < array.Length; i++)
    if (array[i].Length <= 3)
    {
        result[amount] = array[i];
        amount++;
    }

PrintArray(array);
Console.Write("-> ");
PrintArray(result);