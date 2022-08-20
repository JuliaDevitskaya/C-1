//Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8

using static System.Console;
Clear();
WriteLine("Введите число: ");
int numberN=Convert.ToInt32(ReadLine());
int numberA=1;
while(numberA<=numberN)
{
    if(numberA%2==0)
    {
        WriteLine(numberA);
    }
    numberA++;
}
