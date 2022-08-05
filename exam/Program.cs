// Написать программу, которая из имеющегося массива строк формирует массив из строк,
// длина которых меньше или равна 3 символа. 
//Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполения алгоритма. 
//при решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

string Prompt(string message)
{
    System.Console.Write(message);
    return Console.ReadLine();
}

string[] GenerateArray(int length, string message)
{
    string[] massive = new string[length];
    for (int i = 0; i < length; i++)
    {
        massive[i] = Prompt(message);
    }
    return massive;
}

void PrintMassive(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}; ");
    }
}