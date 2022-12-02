Console.Write("Введите число, чтобы проверить является ли оно четным: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = number % 2;
if (evenNumber == 0)
{
    Console.Write("Ваше число " + number + " является четным.");
}
else
{
    Console.Write("Ваше число " + number + " является нечетным.");
}