Console.Write("Для сравнения двух чисел введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
if (numberFirst < numberSecond)
{
    Console.WriteLine("Больше число второе число: " + numberSecond);
}
else
{
    Console.WriteLine("Больше число первое число: " + numberFirst);
}