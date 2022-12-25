// Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести 
// с клавиатуры, либо задать на старте выполнения алгоритма. 
// Не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.


string[] array = new string [8] {"log", "2023", "milk", "cat", "hi", "23", "row", "5675"}; //массив задан на старте алгоритма


string[] CompleteNewArray (string[] points)          // функция для получения искомого массива     
{                                                    // с элементами состоящими из 3х и менее символов 
    int count = 0;
    for (int i = 0; i < points.Length; i++)  
    {
        if (points[i].Length <= 3)
        {
            points[count] = points[i];
            count++;
        }
    }
    string[] finarray = new string[count];
    for (int j = 0; j < count; j++) 
    {
        finarray[j] = points[j];
    }
    return finarray;
}

string text = string.Join(",", CompleteNewArray(array)); 
Console.WriteLine($"Final array:[{text}]"); // вывод иского массива
