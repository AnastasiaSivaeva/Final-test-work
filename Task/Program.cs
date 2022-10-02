// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,
		// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры,
		// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
		// лучше обойтись исключительно массивами.

string[] array1 = {"Hello", "2", "world", ":-)"};
string[] array2 = {"1234", "1567", "-2", "computer science"};
string[] array3 = {"Russia", "Denmark", "Kazan"};

string [] NewArray(string[] arr)
{
    string[] result = new string[arr.Length];
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i].Length <= 3 )
        {
            result[count] = arr[i];
            count++;
        }
    }
    return result;
}

void PrintArray(string [] arr2)
{
    for (int i = 0; i < arr2.Length; i++)
    { 
        Console.Write($"{arr2[i]} ");
    }
    Console.WriteLine();
}

string[] MyArray = NewArray(array1);
PrintArray(MyArray);

string[] MyArray1 = NewArray(array2);
PrintArray(MyArray1);

string[] MyArray2 = NewArray(array3);
PrintArray(MyArray2);