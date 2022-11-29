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

