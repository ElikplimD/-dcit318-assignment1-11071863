using System;

namespace GradeCalculator
{
    public class GradeCalculator
    {
        public string GetLetterGrade(int numericalGrade)
        {
            if (numericalGrade >= 90)
            {
                return "A";
            }
            else if (numericalGrade >= 80)
            {
                return "B";
            }
            else if (numericalGrade >= 70)
            {
                return "C";
            }
            else if (numericalGrade >= 60)
            {
                return "D";
            }
            else
            {
                return "F";
            }
        }
    }
}