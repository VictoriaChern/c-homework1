using System;
using static System.Console;

WriteLine($"Please write first number: ");
int number1 = int.Parse(ReadLine());
WriteLine($"Please write second number: ");
int number2 = int.Parse(ReadLine());
WriteLine($"Please write third number: ");
int number3 = int.Parse(ReadLine());
int maxNumber = number1;
if(number2 > maxNumber){
    maxNumber = number2;
}
if(number3 > maxNumber){
    maxNumber = number3;
} 
WriteLine($"Max number {maxNumber}");

