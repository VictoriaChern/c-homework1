using System;
using static System.Console;

WriteLine($"Enter number: ");
int number = int.Parse(ReadLine());
Write($"{number} -> ");
int count = 1;
while(count <= number) {
    if(count%2 == 0) {
        Write($"{count} ");
    }
    count++;
}
WriteLine();
