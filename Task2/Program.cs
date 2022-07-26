/*
int GetCountNum (int a)
{
int count = 0;
for(int i = 1; i <= a; i++)
{
count = 1 + i;

}
return count;
}

int A = int.Parse(Console.ReadLine());
Console.Write($"Количество цифр в числе {A} = {GetCountNum (A)}");

Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

4  -> 24
5  -> 120
*/

int n = 0;

Console.WriteLine("Введите число N: ");
n = int.Parse(Console.ReadLine());

int GetNum (int n)
{
int count = 1;

for(int i = 1; i <= n; i++)
{
count = count * i;
}
return count;
}

Console.Write($"Произведение чисел от 1 до {n} = {GetNum (n)}");
