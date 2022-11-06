// Написать цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
Console.WriteLine("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberB == 0)
{
Console.WriteLine("А в степени В равно: 1");
}
else
{
int result = numberA;
for (int i = 1; i < numberB; i++)
{
result = result * numberA;
}
Console.WriteLine("A в степени B равно: " + result);
}