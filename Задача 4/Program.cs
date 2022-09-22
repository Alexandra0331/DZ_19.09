Console.Write("Введите значение 1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 2: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение 3: ");
int c = Convert.ToInt32(Console.ReadLine());

int maxNumber = a;

if (b > maxNumber)
   maxNumber = b;
if (c> maxNumber)
   maxNumber = c;

// 4. Напишите программу, которая принмает на вход три числа и
// выдает, максимальное из этих чисел.
// 2,3,7 -> 7
// 44,5,78 -> 78
// 22,3,9 -> 22
Console.WriteLine(maxNumber);