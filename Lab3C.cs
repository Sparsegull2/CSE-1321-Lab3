/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab3C 
*/

using System;

class Lab3C {
    public static void Main(string[] args){
        Console.Write("Enter the number of quarters: ");
        int Q = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of dimes: ");
        int D = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of nickels: ");
        int N = int.Parse(Console.ReadLine());
        Console.Write("Enter the number of pennies: ");
        int P = int.Parse(Console.ReadLine());
        Console.WriteLine("\nYou entered "+Q+" quarters.");
        Console.WriteLine("You entered "+D+" dimes.");
        Console.WriteLine("You entered "+N+" nickels.");
        Console.WriteLine("You entered "+P+" pennies.");
        int dollars = (Q*25 + D*10 + N*5 + P) / 100;
        int cents = (Q*25 + D*10 + N*5 + P) % 100;
        Console.WriteLine("\nYour total is "+dollars+" dollars and "+cents+" cents.");

    }

}
