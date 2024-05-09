using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments
            int currentAssignments = 5;

            // Arrays used to hold the scores of graded assignments for each student.
            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

            // Integer vars used to hold the sum of the exam scores.
            int sophiaSum = 0;

            // Decimal vars used to hold the calculated average score.
            decimal sophiaScore;

            // Loop through the sophiaScores array and sum the scores.
            foreach (int score in sophiaScores)
            {
                // add the exam score to the sum
                sophiaSum += score;
            }

            // Equations used to calculate the sum of the assignment scores for each student.

            // Equations used to calculate the average score for each student.
            sophiaScore = (decimal)sophiaSum / currentAssignments;

            // Formatted output. The first line is a header line with column titles, followed by the names and scores for each student.
            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");

            Console.WriteLine("Press the Enter key to continue");

            // This pauses the application so user can review output.
            Console.ReadLine();

        }
    }
}