// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()!);
int i = 1;
int x=1;

while (i<=N) {

x=i*i*i;
i++;
Console.Write(" " + x + " ");

}
