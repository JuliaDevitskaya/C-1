 //Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
//a = 5; b = 7 -> max = 7
//a = 2 b = 10 -> max = 10
//a = -9 b = -3 -> max = -3

using static System.Console;
Clear();
WriteLine("Введите первое число: ");
int numberA=Convert.ToInt32(ReadLine());
WriteLine("Введите второе число: ");
int numberB=Convert.ToInt32(ReadLine());
if(numberA>numberB)
{
    Write("max = ");
    WriteLine(numberA);
}
else
{
    Write("max = ");
    WriteLine(numberB);
}
