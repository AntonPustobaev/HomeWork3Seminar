// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

using System;
Console.Clear();

Console.Write("Ввведите пятизначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

String numS = num.ToString();

int a1 = Convert.ToInt32(numS[0].ToString());
int a2 = Convert.ToInt32(numS[1].ToString());
int a4 = Convert.ToInt32(numS[3].ToString());
int a5 = Convert.ToInt32(numS[4].ToString());

string answer = (a1==a5&&a2==a4)?$"{num}=> да":$"{num}=> нет";

Console.WriteLine(answer);