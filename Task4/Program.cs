Start();
void Start()
{
    while (true)
    {
        Console.ReadLine();
        Console.Clear();
        System.Console.WriteLine("Задание 1 (введите 1)");
        System.Console.WriteLine("Задание 2 (введите 2)");
        System.Console.WriteLine("Задание 3 (введите 3)");
        System.Console.WriteLine("End (если введено - 0)");
        int numTask = Convert.ToInt32(Console.ReadLine());

        switch (numTask)
        {
            case 0: return; break;
            case 1: MyPow(); break;
            case 2: SummNumbers(); break;
            case 3: ViewArray(); break;
            default: System.Console.WriteLine("Ошибка ввода"); break;
        }
    }
}

// Написать цикл, который принимает на вход два числа (A и B) и возводит 
// число A в натуральную степень B.
void MyPow()
{
  Console.Clear();

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
}
// End

// Программа, которая принимает на вход число и выдаёт сумму цифр в числе.
void SummNumbers()
{
    Console.Clear();

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
}
// End
// Программа, которая задаёт массив из 8 элементов и выводит их на экран.
void ViewArray()
{
    Console.Clear();

    int[] arr = {5, 6, 3, 2, 2, 6, 7, 1, 0};

    void PrintArray(int[] array)
    {
       int count = array.Length;
       for (int i = 0; i < count; i++)
       {
          Console.Write($"{array[i]} ");
       }
       Console.WriteLine();
    }
    PrintArray(arr);
}
// End