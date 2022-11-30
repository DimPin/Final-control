string[] CreateNewArray(string[] arr)
{
    string[] newArr = new string[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[i] = arr[i];
        }
    }
    return newArr;
}

void ShowArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        Console.Write(arr[i] + " ");

    Console.WriteLine();
}

string[] array = {"abc", "abcd", "ab", "b", "bcdf"};
ShowArray(array);
ShowArray(CreateNewArray(array));