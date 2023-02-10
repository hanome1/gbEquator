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
    
}
string[] ShowShortItems(string[] arr) //считает положительные числа в массиве и печатает его. требует указать кол-во элементов (n)
{
   
}
