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
string[] FillArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = ReadData($"Введите элемент {i + 1}:");
    }
    return arr;
}
string[] ShowShortItems(string[] arr) //считает положительные числа в массиве и печатает его. требует указать кол-во элементов (n)
{
    int len = 0;
       for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3) len++;
    }
    string[] newArr = new string[len];
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
