﻿// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int numberA = ReadInt("Введите число: ");
int numberB = ReadInt("Введите степень: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b) {
    int result = 1;
    for (int i = 1; i <= b; i++) {
        result = result * a;
    }
    Console.WriteLine(a + " в степени " + b + " = " + result);
}

// Функция ввода
int ReadInt(string message) {
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}