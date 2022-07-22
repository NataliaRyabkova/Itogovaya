
string [] array = new string[10] {"hello", "57895", "257","car", "easy", "end", "sity", "","table", ":-)"};

string [] СhoiceOfWords(string [] array)
{
    int j = 0;
    string [] words = new string[10];
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i].Length <= 3)
        {
            words[j]= array[i];
            j = j + 1;
        }
    }
    return words; 
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}"+" ");
    }
}

string[] newarray = СhoiceOfWords(array);
ShowArray(newarray);
