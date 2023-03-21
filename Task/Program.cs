﻿// Написать программу, которая из имеющегося массива строк формирует массив из строк, 
// длинна которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры с клавиатуры, либо задать на старте 
// выполнение алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами 


// Примеры: 
// ["hello", "2", "woorld",":-)"] -> ["2", ":-)"]

using System; 
using static System.Console; 

Write ("Введите элементы массива через через пробел: ");



string [] array = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int m = 3;  //колличество символов 
PrintArray(array);


void PrintArray(string [] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (array[i].Length <= m)
        Write ($"{array[i]}; ");
    }
}


