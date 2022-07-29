// создать массив и заполнить его от 1 до размера массива N

int n = int.Parse(Console.ReadLine());
int[] array = new int [n];


for (int i = 0; i < n; i++)
{
   array[i] = i + 1;
Console.Write($"{array[i]} ");
}
//foreach (int element in array);



