// Дан текст. В тексте нужно заменить пробелы на -, Букву К на к, букву С на с
string text = "У луКоморья дуб Сейл Онли"
            + "Злотая цепь на Срубе том";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if (text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}
string newText = Replace(text, newValue: 'к', oldValue: 'К');
Console.WriteLine(newText);
Console.WriteLine();
string newText1 = Replace(newText, newValue: '-', oldValue: ' ');
Console.WriteLine(newText1);