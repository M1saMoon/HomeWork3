﻿//Найти сумму чисел от 1 до А

Console.Clear();
Console.WriteLine("Введите число A: ");
int a = int.Parse(Console.ReadLine());
int sum = 0;
for (int i = 1; i <= a; i++) 
{
    sum = sum + i;
}
Console.WriteLine($"Сумма чисел от 1 до {a} = {sum}");