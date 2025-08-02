using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numerical grade (0 - 100):");
            string input = Console.ReadLine();
            int grade;

            if (int.TryParse(input, out grade) && grade >= 0 && grade <= 100)
            {
                GradeCalculator calculator = new GradeCalculator();
                string letterGrade = calculator.GetLetterGrade(grade);
                Console.WriteLine($"The letter grade is: {letterGrade}");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}