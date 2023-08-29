/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab3A 
*/
using System;

class Lab3A
{
    public static void Main(string[] args)
    {
        Console.Write("Amount owed: ");
        float balance = float.Parse(Console.ReadLine());
        Console.Write("APR: ");
        float APR = float.Parse(Console.ReadLine());
        float mpr = APR / 12;
        float min = (mpr / 100) * balance;
        Console.WriteLine("Monthly percentage rate: " + mpr.ToString("n3"));
        Console.WriteLine("Minimum payment: $" + min.ToString("n2"));

    }

}