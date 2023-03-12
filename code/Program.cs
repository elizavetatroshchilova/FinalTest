string[] CheckElements(string[] firstArray) 
{
    int count = 0;

    for(int i = 0; i < firstArray.Length; i++) 
    {
        if(firstArray[i].Length <= 3) 
        {
            count++;
        }
    }

    string[] secondArray = new string[count];
    int j = 0;

    for(int i = 0; i < firstArray.Length; i++) 
    {
        if(firstArray[i].Length <= 3) 
        {
            secondArray[j] = firstArray[i];
            j++;
        }
    }
    return secondArray;
}

void PrintArray(string[] finalArray) 
{
    Console.WriteLine();
    Console.Write(" ");

    for(int i = 0; i < finalArray.Length; i++) 
    {
        if(i < finalArray.Length - 1) 
        {
            Console.Write($"{finalArray[i]}, ");
        }
        else {
            Console.Write($"{finalArray[i]}.");
        }
    }
}

string[] array = new string[6] {"Russia", "cat", "-0987", ":)", "France", "12"};

Console.WriteLine();
Console.WriteLine("Изначально заданный массив:");


for(int i = 0; i < array.Length; i++) 
{
    if(i < array.Length - 1) 
    {
        Console.Write($"{array[i]}, ");
    }
    else 
    {
        Console.Write($"{array[i]}.");
    }
}
Console.WriteLine();

Console.WriteLine();
Console.WriteLine("Массив, с элементами длиной не более 3 символов:");
PrintArray(CheckElements(array));
