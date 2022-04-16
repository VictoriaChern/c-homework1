using System;
using static System.Console;

WriteLine("Please write first number: ");
int number1 = int.Parse(ReadLine());
WriteLine("Please write second number: ");
int number2 = int.Parse(ReadLine());
int maxNumber = number1;
if(number2 > number1) {
    maxNumber = number2;
}
WriteLine($"Max number = {maxNumber}");
