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

            // Array used to hold the names of the students. The names are in the same order as the scores.
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

            // Array used to hold the scores of the students.
            int[] studentScores = new int[10];

            // String used to hold the letter grade for each student.
            string currentStudentLetterGrade = "";

            // Write the Report Header to the console.
            Console.WriteLine("Student\t\tGrade\n");

            // Loop through the studentNames array and display the names of the students.
            foreach (string name in studentNames)
            {
                string currentStudent = name;

                if (currentStudent == "Sophia")
                    studentScores = sophiaScores;

                else if (currentStudent == "Andrew")
                    studentScores = andrewScores;

                else if (currentStudent == "Emma")
                    studentScores = emmaScores;

                else if (currentStudent == "Logan")
                    studentScores = loganScores;

                // Integer vars used to hold the sum of the exam scores.
                int sumAssignmentScores = 0;

                // Decimal vars used to hold the calculated average score.
                decimal currentStudentGrade = 0;

                // Loop through the sophiaScores array and sum the scores.
                foreach (int score in studentScores)
                {
                    // add the exam score to the sum
                    sumAssignmentScores += score;

                }

                // Equations used to calculate the average score for each student.
                currentStudentGrade = (decimal)(sumAssignmentScores) / currentAssignments;

                if (currentStudentGrade >= 97)
                    currentStudentLetterGrade = "A+";

                else if (currentStudentGrade >= 93)
                    currentStudentLetterGrade = "A";

                else if (currentStudentGrade >= 90)
                    currentStudentLetterGrade = "A-";

                else if (currentStudentGrade >= 87)
                    currentStudentLetterGrade = "B+";

                else if (currentStudentGrade >= 83)
                    currentStudentLetterGrade = "B";

                else if (currentStudentGrade >= 80)
                    currentStudentLetterGrade = "B-";

                else if (currentStudentGrade >= 77)
                    currentStudentLetterGrade = "C+";

                else if (currentStudentGrade >= 73)
                    currentStudentLetterGrade = "C";

                else if (currentStudentGrade >= 70)
                    currentStudentLetterGrade = "C-";

                else if (currentStudentGrade >= 67)
                    currentStudentLetterGrade = "D+";

                else if (currentStudentGrade >= 63)
                    currentStudentLetterGrade = "D";

                else if (currentStudentGrade >= 60)
                    currentStudentLetterGrade = "D-";

                else
                    currentStudentLetterGrade = "F";

                // Formatted output with the names, scores, and letter grades for each student.
                Console.WriteLine($"{currentStudent}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

            }

            Console.WriteLine("Press the Enter key to continue");
            // This pauses the application so user can review output.
            Console.ReadLine();

        }
    }
}