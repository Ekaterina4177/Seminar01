Console.Write("Ввведите первое число: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ввведите второе число: ");
int numberB = Convert.ToInt32(Console.ReadLine());

if(numberA == (numberB * numberB))
{
   Console.WriteLine("Yes");
}

else{
   Console.WriteLine("No");
}