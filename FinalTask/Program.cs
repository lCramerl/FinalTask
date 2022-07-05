void FillArray(string[] array)
{
    Console.WriteLine("Введите элементы массива по очереди: ");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{i}. ");
        array[i] = Console.ReadLine()!;
    }
}

void PrintArray(string[] arrayToPrint)
{
    Console.Write("[  ");
    for (int i = 0; i < arrayToPrint.Length; i++)
    {
        const string quote = "\"";
        Console.Write(quote + arrayToPrint[i] + quote);
        if (i != arrayToPrint.Length - 1)
        {
            Console.Write(",  ");
        }
    }
    Console.Write("  ]");
}

string[] FindSringOfCertaintLenght(string[] arrayToCheck, int stringLength)
{
    int count = 0;
    for (int i = 0; i < arrayToCheck.Length; i++)
    {
        if (arrayToCheck[i].Length <= stringLength)
        {
            count++;
        }
    }
    string[] result = new string[count];
    int buf = 0;
    for (int k = 0; k < count; k++)
    {
        for (int j = buf; j < arrayToCheck.Length; j++)
        {
            if (arrayToCheck[j].Length <= stringLength)
            {
                result[k] = arrayToCheck[j];
                buf = j + 1;
                break;
            }
        }
    }
    return result;
}


Console.Clear();
Console.Write("Введите количество эллементов, которое вы хотите задать для будующего массива: ");
int length = Convert.ToInt32(Console.ReadLine());
string[] newArray = new string[length];
FillArray(newArray);
Console.WriteLine("Ваш массив:");
PrintArray(newArray);
int stringLength = 3;
string[] arrayToCheck = FindSringOfCertaintLenght(newArray, stringLength);
Console.WriteLine();
Console.WriteLine($"Массив, каждый элемент которого состоит не более, чем из {stringLength} символов: ");
PrintArray(arrayToCheck);