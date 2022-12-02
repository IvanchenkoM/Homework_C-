Console.Write("Чтобы узнать все четные числа от 1 до числа, введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int evenNumber = 2;
if (number < 1) 
{
    Console.Write("Вы введи некоректрное число, попробуйте снова!");
}
else
{
    Console.Write("От 1 до вашего числа " + number + " находятся следующие четные числа: ");
}
while (evenNumber < number)
{
    Console.Write(" " + evenNumber + " ");
    evenNumber +=2;
}
