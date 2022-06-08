/* Задача 2: Напишите программу, которая принимает на 
вход три числа и выдаёт максимальное из этих чисел. 
Пример: 2, 3, 7 -> 7  */

Console.Clear();
Console.WriteLine("Введите первое число: "); 
double num1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите второе число: "); 
double num2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите третье число: "); 
double num3 = Convert.ToDouble(Console.ReadLine());

double maxNumber = num1;

if (num2 > maxNumber)
{
   maxNumber = num2;
}
else if (num3 > maxNumber)
{
    maxNumber = num3;
}
Console.Write( " Максимальное число: " + maxNumber);
