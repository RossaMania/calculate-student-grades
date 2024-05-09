using System;

namespace StudentGrades
{
    class Program
    {
        static void Main(string[] args)
        {
            // initialize variables - graded assignments
            int examAssignments = 5;

            // Arrays used to hold the scores of graded assignments for each student.
            int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
            int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
            int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
            int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
            int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
            int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
            int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
            int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

            // Array used to hold the names of the students. The names are in the same order as the scores.
            string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

            // Array used to hold the scores of the students.
            int[] studentScores = new int[10];

            // String used to hold the letter grade for each student.
            string currentStudentLetterGrade = "";

            // Write the Report Header to the console.
            Console.WriteLine("Student\t\tExam Score\t\tOverall Grade\t\tExtra Credit\n");

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

                else if (currentStudent == "Becky")
                    studentScores = beckyScores;

                else if (currentStudent == "Chris")
                    studentScores = chrisScores;

                else if (currentStudent == "Eric")
                    studentScores = ericScores;

                else if (currentStudent == "Gregor")
                    studentScores = gregorScores;

                else
                    continue;

                // Integer var used to hold the sum of the exam scores.
                int sumAssignmentScores = 0;

                // Decimal vars used to hold the calculated average score.
                decimal currentStudentGrade = 0;

                // Initialize/reset a counter for the number of assignments
                int gradedAssignments = 0;

                // Int var for the sum of all graded assignments
                int gradedAssignmentsSum = 0;

                // Int var used to hold the sum of the exam scores.
                int examScoreSum = 0;

                // Decimal var used to hold the average exam score.
                decimal currentExamAverage = 0;

                // Decimal var used to hold the extra credit points.
                decimal extraCreditPoints = 0;

                // Integer var used to hold the extra credit score.
                int extraCreditScore = 0;

                // Integer var used to hold the sum of the extra credit scores.
                int extraCreditSum = 0;

                // Loop through the studentScores array and display the scores of the students.
                foreach (int score in studentScores)
                {

                    // increment the assignment counter
                    gradedAssignments += 1;

                    if (gradedAssignments <= examAssignments)

                        // add the exam score to the sum
                        examScoreSum = sumAssignmentScores += score;

                    else
                        // add the extra credit points to the sum - bonus points equal to 10% of an exam score
                        sumAssignmentScores += score / 10;
                        gradedAssignmentsSum += score;

                }

                // Calculate the average score for each student, including the extra credit.
                currentStudentGrade = Math.Round((decimal)(sumAssignmentScores) / examAssignments, 2);

                // Calculate the average exam score for each student.
                currentExamAverage = (decimal) examScoreSum / examAssignments;

                // Calculate the extra credit sum for each student.
                extraCreditSum = gradedAssignmentsSum - examScoreSum;

                // Calculate the number of extra credit assignments for each student.
                int extraCreditAssignments = gradedAssignments - examAssignments;

                // Calculate the extra credit score for each student.
                extraCreditScore = extraCreditSum / extraCreditAssignments;


                // Calculate the extra credit points for each student (10% of an exam score) and round to 2 decimal places for display.
                extraCreditPoints = Math.Round((decimal)extraCreditSum * 10 / 100 / examAssignments, 2);

                // Determine the letter grade for each student based on the current student grade score.
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

                // Formatted output with the names, exam scores, overall grades, extra credit score, and extra credit points.
                Console.WriteLine($"{currentStudent}\t\t{currentExamAverage}\t\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t\t{extraCreditScore} ({extraCreditPoints} pts)");

            }

            Console.WriteLine("Press the Enter key to continue");
            // This pauses the application so user can review output.
            Console.ReadLine();

        }
    }
}