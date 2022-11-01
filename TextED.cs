string text = "Популярность повлекла за собой появление спин-оффов. " +
              "В центре повествования этого проекта оказывается " +
              "Симона Кларк, мать-одиночка, которая так и не смогла воплотить в жизнь свои мечты. " +
              "Главная героиня мечтает о том, чтобы обеспечить своих детей во что бы то ни стало.";

string Replace(string texts, char oldValue, char newValue)
{
    string result = String.Empty;
    int length = texts.Length;
    for (int i = 0; i < length; i++)
    {
        if (texts[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');

Console.WriteLine(newText);
Console.WriteLine();

string texts = Replace(newText, 'а','А');
Console.WriteLine(texts);
