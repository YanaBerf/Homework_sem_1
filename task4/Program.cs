﻿Console.Clear();
Console.Write("число первое: ");
int a = int.Parse(Console.ReadLine()); 
Console.Write("число второе: ");
int b = int.Parse(Console.ReadLine());
Console.Write("число третье: ");
int c = int.Parse(Console.ReadLine());

if (a > b && a > c)
{
    Console.WriteLine($"max = {a}");
}
if (b > a && b > c){
    Console.WriteLine($"max = {b}");
}
if (c > a && c > b){
    Console.WriteLine($"max = {c}");
}
