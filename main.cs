// Created by: Kenny Le
// Created on: Mar 2022
//
// This program does calculations to solve for the area of a parallelogram

using System;

class Program
{
    public static void Main(string[] args)
    {
        // This function calculates the area of a parallelogram
        double baseOfParallelogram;
        double heightOfParallelogram;
        double area;

        // input
        Console.WriteLine("This program calculates the area of a parallelogram.");
        Console.WriteLine("");

        Console.Write("Enter the base measurement: ");
        baseOfParallelogram = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the height measurement: ");
        heightOfParallelogram = Convert.ToDouble(Console.ReadLine());

        // process
        Console.WriteLine("");
        area = baseOfParallelogram * heightOfParallelogram;

        // output
        Console.WriteLine("The area of parallelogram is: " + area.ToString("0.00") + " " + "cm².");

        Console.WriteLine("\nDone.");
    }
}