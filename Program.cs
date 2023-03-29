// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите числа через пробел: ");
int[] array = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
Console.WriteLine(SumOfEven(array));

// ----------Метод---------------
int SumOfEven(int[] newArray)
{   
    int count =0;
    for (int i = 0; i < newArray.Length; i++)
    {
        if (newArray[i] > 0)
        {
            count++;
        }
    }
    return count;
}