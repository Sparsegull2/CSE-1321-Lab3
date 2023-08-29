/* 
Class: CSE 1321L 
Section: #03 
Term: Fall 2023
Instructor: John Blake 
Name: Christopher Morrison
Lab#: Lab3B
*/

using System;

class Lab3B {
    public static void Main(string[] args){
        Console.Write("Course 1 hours: ");
        float c1_h = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 1: ");
        float c1_g = float.Parse(Console.ReadLine());   
        Console.Write("Course 2 hours: ");
        float c2_h = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 2: ");
        float c2_g = float.Parse(Console.ReadLine());
        Console.Write("Course 3 hours: ");
        float c3_h = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 3: ");
        float c3_g = float.Parse(Console.ReadLine());
        Console.Write("Course 4 hours: ");
        float c4_h = float.Parse(Console.ReadLine());
        Console.Write("Grade for course 4: ");
        float c4_g = float.Parse(Console.ReadLine());
        float hours = c1_h + c2_h + c3_h + c4_h;
        float points = c1_g*c1_h + c2_g*c2_h + c3_g*c3_h + c4_g*c4_h;
        float GPA = points / hours;
        Console.WriteLine("Total hours is: "+ hours);
        Console.WriteLine("Total quality points is: "+ points);
        Console.WriteLine("Your GPA for this semester is "+GPA.ToString("n5"));
    }
}
