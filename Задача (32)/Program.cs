﻿// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран
int [] Arr = new int [8];
Console.Clear();
for (int i=0;i<Arr.Length;i++)
    Arr[i]=new Random().Next(0,2);

for (int i=0;i<Arr.Length;i++)
    System.Console.Write($" {Arr[i]} ");
