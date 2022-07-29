/*Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/


Console.Write("Введите число: ");
int cube = int.Parse(Console.ReadLine());

void Cube(int[] cube)
{
  int counter = 0;
  int length = cube.Length;
  while (counter <  length){
    cube[counter] = counter*counter*counter;
    counter++;
  }
}

void PrintArry(int[] collection)
{
  int count = collection.Length;
  int index = 0;
  while(index < count){
    Console.Write(collection[index]+ " ");
    index++;
  }
} 

int[] array = new int[cube+1];
Cube(array);
PrintArry(array);