Console.Write("Введите 1-ое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите 2-ое число: ");
int b = Convert.ToInt32(Console.ReadLine());
// 2. Напишите программу, которая на вход принмает 2 числа и
// выдает, какое число большее, а какое меньшее.
// a=5 b=7 -> max = 7
// a=2 b=10 -> max = 10
// a=-9 b=-3 -> max = -3

int maxNumber = a;
int minNumber = a;

if (b > maxNumber)
   maxNumber = b;
if (b < minNumber)
   minNumber = b;
Console.WriteLine(maxNumber);  
Console.WriteLine(minNumber);