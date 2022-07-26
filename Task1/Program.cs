int number = 0;

Console.WriteLine("Введите пятизначное число: ");
number = int.Parse(Console.ReadLine());

String user = number;


for(int i = 0; i < user.Length; i++)


if(i == (user.Length-i))
{
    Console.WriteLine($"{number}-> Да");
}
else
Console.WriteLine($"{number}-> Нет");
