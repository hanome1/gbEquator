string ReadData(string msg) //чтение данных
{
    Console.WriteLine(msg);
    string item = Console.ReadLine();
    return item;
}
void PrintArray(string[] arr)  //печатаем массив красиво
{
    Console.Write("\n[ ");
    for (int i = 0; i < arr.Length - 1; i++)
    {
        Console.Write(arr[i] + ", ");
    }
    Console.WriteLine(arr[arr.Length - 1] + " ]");
}
string[] FillArray(string[] arr) //заполнение массива элементами пользователя
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadData($"Введите элемент {i + 1}:");
    }
    return arr;
}
string[] ShowShortItems(string[] arr) //вычисляет количество коротких элементов и выводит их
{
    int shorts = 0;
       for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) shorts++;
    }
    string[] newArr = new string[shorts];
    int j = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3)
        {
            newArr[j] = arr[i];
            j++;
        }
    }
    return newArr;
}
string[] userArray = new string[int.Parse(ReadData("Введите количество элементов массива: "))];
userArray = FillArray(userArray);
Console.WriteLine("Ваш массив:");
PrintArray(userArray);
Console.WriteLine("Элементы, состоящие из трёх символов или меньше:");
PrintArray(ShowShortItems(userArray));
