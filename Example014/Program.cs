﻿// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, 
// сумма отрицательных равна -20.

int[] arr = new int[12]; // задаем массив и кол-во его элементов. Здесь же можно random
int sumPos = 0;
int sumNeg = 0;

for (int i = 0; i < arr.Length; i++) // не строгое условие, т.к. иначе уйдем за его длину
{
    arr[i] = new Random().Next(-9, 20); //т.к. правая часть не увеличивается, то на 1 больше
    Console.Write($"{arr[i]}, ");
    if (arr[i] < 0) sumNeg += arr[i]; // если одна строка/действие, то допускается запись в строчку
    else sumPos += arr[i];
}
Console.WriteLine("\b\b ");

Console.WriteLine("Сумма положительных чисел в массиве: {0}", sumPos);
Console.WriteLine("Сумма отрицательных чисел в массиве: {0}", sumNeg);