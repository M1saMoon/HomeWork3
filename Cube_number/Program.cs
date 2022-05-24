//Показать кубы чисел, заканчивающихся на четную цифру

Console.Clear();
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
if (n % 2 == 0)
{
    double result = Math.Pow(n, 3);
    Console.WriteLine(result);
}
else 
Console.WriteLine ($"Число {n} не заканчивается на четную цифру!");