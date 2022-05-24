//Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

Console.Clear();
int [] Binar = new int [8];
for (int i = 0; i < 8; i++)
{
    Binar[i] = new Random().Next(0,2);
    Console.Write(Binar[i] + " ");
}


Console.WriteLine();

int[,] Matrix = new int [4,4];
for (int i = 0; i < Matrix.GetLength(0); i++)
{
    for (int j = 0; j < Matrix.GetLength(1); j++)
    {
        Matrix [i,j] = new Random().Next(0,2);
        Console.Write(Matrix[i,j] + " ");
    }
Console.WriteLine();
}
