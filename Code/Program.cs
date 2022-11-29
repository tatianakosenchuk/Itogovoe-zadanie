string[] TextNotMore3Symbols(string[] text)
{
    int maxlength = 3;
    string[] result = new string[text.Length];
    int count = 0;
    for (int i = 0; i < text.Length; i++)
    {
        if (text[i].Length <= maxlength) result[count] = text[i];
        count++;
    }
    return result;
}


void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}


string[] input = new string[5] { "Om", "Volt", "Vat", "Amper", "MC" };
string[] output = TextNotMore3Symbols(input);
PrintArray(output);
