// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Write("Введите пятизначное число: ");
int N = int.Parse(Console.ReadLine()!);
if (N<100000 & N>9999)
{
    int a = N/10000;
    int b = (N/1000)%10;
    int c = (N/10)%10;
    int d = N%10;

    if(a==d & b==c) {Console.WriteLine ("да");}
    else {Console.WriteLine ("нет");}

}
else {Console.WriteLine("Число не является пятизначным");}