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
            int andrewSum = 0;
            int emmaSum = 0;
            int loganSum = 0;

            // Decimal vars used to hold the calculated average score.
            decimal sophiaScore;
            decimal andrewScore;
            decimal emmaScore;
            decimal loganScore;


            // Equations used to calculate the sum of the assignment scores for each student.
            sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            andrewSum = andrew1 + andrew2 + andrew3 + andrew4 + andrew5;
            emmaSum = emma1 + emma2 + emma3 + emma4 + emma5;
            loganSum = logan1 + logan2 + logan3 + logan4 + logan5;

            // Equations used to calculate the average score for each student.
            sophiaScore = (decimal)sophiaSum / currentAssignments;
            andrewScore = (decimal)andrewSum / currentAssignments;
            emmaScore = (decimal)emmaSum / currentAssignments;
            loganScore = (decimal)loganSum / currentAssignments;


            // Formatted output. The first line is a header line with column titles, followed by the names and scores for each student.
            Console.WriteLine("Student\t\tGrade\n");
            Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");
            Console.WriteLine("Andrew:\t\t" + andrewScore + "\tB+");
            Console.WriteLine("Emma:\t\t" + emmaScore + "\tB");
            Console.WriteLine("Logan:\t\t" + loganScore + "\tA-");

            Console.WriteLine("Press the Enter key to continue");

            // This pauses the application so user can review output.
            Console.ReadLine();

        }
    }
}