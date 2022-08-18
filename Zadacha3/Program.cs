//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number == 3)
{
    Console.WriteLine("Среда");
}
else(number == 5)
{
    Console.WriteLine("Пятница");
}