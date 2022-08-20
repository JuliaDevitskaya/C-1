//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22

using static System.Console;
Clear();
WriteLine("Введите первое число");
int numberA = Convert.ToInt32(ReadLine());
WriteLine("Введите второе число");
int numberB = Convert.ToInt32(ReadLine());
WriteLine("Введите третье число");
int numberC = Convert.ToInt32(ReadLine());
int max = numberA;

if (numberA>max)
{
    max=numberA;
}
if(numberB>max)
{
    max=numberB;
}
if (numberC>max)
{
    max=numberC;
}
WriteLine(max);