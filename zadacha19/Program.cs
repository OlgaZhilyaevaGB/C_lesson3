
/*Задача 19

Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

ОГРАНИЧЕНИЯ: нельзя использовать массивы и строки для решения задачи, исключительно работа с циклами и арифметическими опреациями!!!

14212 -> нет

12821 -> да

23432 -> да*/

Console.WriteLine("Введите число:");
int number = int.Parse(Console.ReadLine());
int n1=number/10000;
int n2=number%10;
int num1=(number-(n1*10000))/10;
int n3=num1/100;
int n4=num1%10;
if (n1==n2&&n3==n4)
  
Console.WriteLine($"Число {number} является палиндромом");
else {
 Console.WriteLine($"Число {number} не является палиндромом");
}