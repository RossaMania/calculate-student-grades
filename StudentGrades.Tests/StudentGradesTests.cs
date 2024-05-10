using NUnit.Framework;

namespace StudentGrades.Tests
{
    public class StudentGradesTests
    {
        [Test]
        public void CalculateSophiaGrade_ReturnsAWithExtraCredit()
        {
            // Arrange
            var sophia1 = 93;
            var sophia2 = 87;
            var sophia3 = 98;
            var sophia4 = 95;
            var sophia5 = 100;
            var sophiaExtraCredit = 10; // Extra credit points
            var currentAssignments = 5;
            var expectedGrade = "A";

            // Act
            var sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5 + sophiaExtraCredit;
            var totalAssignments = currentAssignments + 1; // Including extra credit assignment
            var sophiaScore = (decimal)sophiaSum / totalAssignments;
            var actualGrade = GetGrade(sophiaScore);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        // Add similar tests for other students with extra credit

        private string GetGrade(decimal score)
        {
            if (score >= 97)
                return "A+";
            else if (score >= 93)
                return "A";
            else if (score >= 90)
                return "A-";
            else if (score >= 87)
                return "B+";
            else if (score >= 83)
                return "B";
            else if (score >= 80)
                return "B-";
            else if (score >= 77)
                return "C+";
            else if (score >= 73)
                return "C";
            else if (score >= 70)
                return "C-";
            else if (score >= 67)
                return "D+";
            else if (score >= 63)
                return "D";
            else if (score >= 60)
                return "D-";
            else
                return "F";
        }
    }
}