
Console.WriteLine("Введите пятизначное число: ");
string? number = Console.ReadLine();

void CheckUp (string number)
{
if(number[0] == number[4] && number[1] == number[3])
   {
    Console.WriteLine($"{number}-> Да");
   }
   else
   Console.WriteLine($"{number}-> Нет");
}

if (number!.Length == 5)
{
   CheckUp (number); 
}
else Console.WriteLine("Не корректное число");