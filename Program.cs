/* 
Задача 23 
 
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 
 
3 -> 1, 8, 27 
5 -> 1, 8, 27, 64, 125 
*/ 
 
Console.WriteLine("Введите число");
int userNumber = Convert.ToInt32(Console.ReadLine());
int result = 1;
double resultUser = 0;
while (resultUser > Math.Pow(userNumber, 2))
{
resultUser = Math.Pow(result, 2);
Console.Write($"{resultUser} ");
result++;
}
