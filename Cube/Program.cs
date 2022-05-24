//Найти кубы чисел от 1 до N

Console.Clear();
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    //Console.WriteLine($"Куб числа {i} = {i*i*i}");
    double result = Math.Pow(i, 3);
    Console.WriteLine(result);
}
