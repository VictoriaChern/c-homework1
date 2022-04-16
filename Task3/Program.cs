using System;
using static System.Console;

WriteLine($"Enter the number: ");
int number = int.Parse(ReadLine());
if(number%2 == 0) {
    WriteLine($"The number {number} is even");
} else {
    WriteLine($"The number {number} is odd");
}

