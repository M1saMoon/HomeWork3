//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
int [] Binar = new int [8];
for (int i = 0; i < 8; i++)
{
    Binar[i] = new Random().Next(0,2);
    Console.Write(Binar[i] + " ");
}

