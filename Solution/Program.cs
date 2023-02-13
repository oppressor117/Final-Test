string[] array1 = new string[6] {"hello", "world", "fin", "task", "333", "excellent"};
string[] array2 = new string[array1.Length];

void NewArray(string[] array1, string[] array2) // метод формирования массива из строк, длина которых меньше либо равна 3 символа
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArr(string[] arr) // метод оформление массива
{
    Console.Write("[");
    for(int i = 0; i < arr.Length-1; i++)
    {
        Console.Write(arr[i]+", ");
    }
    Console.WriteLine(arr[arr.Length-1]+"]");
}

PrintArr(array1);
NewArray(array1, array2);
PrintArr(array2);