using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class LabActivity1
{
    public static void Main(string[] args)
    {
        // Question 1

        float CircleArea;
        float CircleRadius;

        Console.Write("Enter the radius of the circle: ");
        CircleRadius = float.Parse(Console.ReadLine());


        CircleArea = 3.14f * CircleRadius * CircleRadius;

        Console.WriteLine("The area of the circle is: " + CircleArea);
        Console.WriteLine();


        // Question 2

        float RectangleLength;
        float RectangleWidth;
        float RectanglePerimeter;

        Console.Write("Enter the length of the rectangle: ");
        RectangleLength = float.Parse(Console.ReadLine());

        Console.Write("Enter the width of the rectangle: ");
        RectangleWidth = float.Parse(Console.ReadLine());

        RectanglePerimeter = (RectangleLength * 2) + (RectangleWidth * 2);

        Console.WriteLine("The perimeter of the rectangle is: " + RectanglePerimeter);
        Console.WriteLine();


        // Question 3

        float SubjectMarks;
        float TotalMarks = 0;
        float AverageMarks;

        for (int i = 1; i <= 3; i++)
        {
            Console.Write("Enter marks for subject " + i + ": ");
            SubjectMarks = int.Parse(Console.ReadLine());

            TotalMarks += SubjectMarks;
        }

        AverageMarks = TotalMarks / 3;

        Console.WriteLine("The total marks for these subjects is: " + TotalMarks);
        Console.WriteLine("The average marks for these subjects is: " + AverageMarks);
        Console.WriteLine();


        // Question 4

        float Celsius;
        float Fahrenheit;

        Console.Write("Enter the temperature in Celsius: ");
        Celsius = float.Parse(Console.ReadLine());

        Fahrenheit = (Celsius * 9 / 5) + 32;

        Console.WriteLine("The temperature in Fahrenheit is: " + Fahrenheit);
        Console.WriteLine();


        //Question 5

        float BasicSalary;
        float Allowance;
        float Bonus;
        float TotalSalary;

        Console.Write("Enter the basic salary: ");
        BasicSalary = float.Parse(Console.ReadLine());

        Console.Write("Enter the allowance: ");
        Allowance = float.Parse(Console.ReadLine());

        Console.Write("Enter the bonus: ");
        Bonus = float.Parse(Console.ReadLine());

        TotalSalary = BasicSalary + Allowance + Bonus;

        Console.WriteLine("The total salary is: " + TotalSalary);
        Console.WriteLine();


        // Question 6

        float TotalBillAmount;
        float AmountPaid;
        float Balance;

        Console.Write("Enter the total bill amount: ");
        TotalBillAmount = float.Parse(Console.ReadLine());

        Console.Write("Enter the amount paid by the customer: ");
        AmountPaid = float.Parse(Console.ReadLine());

        Balance = AmountPaid - TotalBillAmount;

        Console.WriteLine("The balance to be returned to the customer is: " + Balance);
    }
}