//Напишите программу, которая будет выдавать название дня недели по заданному номеру.
//3 -> Среда
//5 -> Пятница

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number <= 7 || number >= 1){
    switch(number){
case 1: Console.WriteLine("Monday"); break;
case 2: Console.WriteLine("Tuesday"); break;
case 3: Console.WriteLine("Wednesday"); break;
case 4: Console.WriteLine("Thursday"); break;
case 5: Console.WriteLine("Friday"); break;
case 6: Console.WriteLine("Saturday"); break;
case 7: Console.WriteLine("Sunday"); break;
default: Console.WriteLine("Enter a number from 1 to 7"); break;
    }
}