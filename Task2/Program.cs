// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine("Введите число: ");

int numberA = Convert.ToInt32(Console.ReadLine());
int sum = 0;

while (numberA > 0)
{
int num = numberA % 10;
numberA = numberA / 10;
sum = sum + num;
}
Console.WriteLine("сумма всех цифр в числе равна: " + sum);