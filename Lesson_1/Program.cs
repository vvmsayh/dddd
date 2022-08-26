/*
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/
System.Console.Write("введите количество чисел: " );
int size = Convert.ToInt32(Console.ReadLine());
int[] array = new int[size];
int count = 0;
int counter = 0;
System.Console.Write("введите числа: ");
for (int i = 0; i < size; i++)
{
    System.Console.Write($"введите число с идексом {counter}:  "); counter++;
    array[i] = Convert.ToInt32(Console.ReadLine());
}
    for (int j = 0; j < size; j++)
    {
        if(array[j]>0) count++;
    }

System.Console.WriteLine($"Числа:  {string.Join(", ",array )}");
System.Console.WriteLine($"Количество четных чисел = {count}");



/*
for (int i = 0; i < count; i++)
{
    for (int j = 0; j < count; j++)
    {
         System.Console.Write("введите числа: ");
        int num = Convert.ToInt32(Console.ReadLine());
    }
    if
 
}
System.Console.WriteLine($"{num}");
if (num[i]>0) numbers+=1;
System.Console.WriteLine($"[ {num} ]. Количество чисел больше нуля - {numbers}");
*/

