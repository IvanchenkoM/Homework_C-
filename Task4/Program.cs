Console.Write("Для сравнения трех чисел введите первое число: ");
int numberFirst = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberSecond = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int numberThird = Convert.ToInt32(Console.ReadLine());
if (numberFirst > numberSecond)
{
    if (numberFirst > numberThird)
    {
        Console.WriteLine("Больше число первое число: " + numberFirst);
    }
    else 
    {
        Console.WriteLine("Больше число  третье число: " + numberThird);
    }
    
}
else
{
    if (numberSecond > numberThird)
    {
        Console.WriteLine("Больше число второе число: " + numberSecond);
    }
    else 
    {
        Console.WriteLine("Больше число третье число: " + numberThird);
    }
    
}