using NUnit.Framework;

namespace StudentGrades.Tests
{
    public class StudentGradesTests
    {
        [Test]
        public void CalculateSophiaGrade_ReturnsA()
        {
            // Arrange
            var sophia1 = 93;
            var sophia2 = 87;
            var sophia3 = 98;
            var sophia4 = 95;
            var sophia5 = 100;
            var currentAssignments = 5;
            var expectedGrade = "A";

            // Act
            var sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
            var sophiaScore = (decimal)sophiaSum / currentAssignments;
            var actualGrade = GetGrade(sophiaScore);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [Test]
        public void CalculateNicolasGrade_ReturnsB()
        {
            // Arrange
            var nicolas1 = 80;
            var nicolas2 = 83;
            var nicolas3 = 82;
            var nicolas4 = 88;
            var nicolas5 = 85;
            var currentAssignments = 5;
            var expectedGrade = "B";

            // Act
            var nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
            var nicolasScore = (decimal)nicolasSum / currentAssignments;
            var actualGrade = GetGrade(nicolasScore);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [Test]
        public void CalculateZahirahGrade_ReturnsB()
        {
            // Arrange
            var zahirah1 = 84;
            var zahirah2 = 96;
            var zahirah3 = 73;
            var zahirah4 = 85;
            var zahirah5 = 79;
            var currentAssignments = 5;
            var expectedGrade = "B";

            // Act
            var zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
            var zahirahScore = (decimal)zahirahSum / currentAssignments;
            var actualGrade = GetGrade(zahirahScore);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        [Test]
        public void CalculateJeongGrade_ReturnsA()
        {
            // Arrange
            var jeong1 = 90;
            var jeong2 = 92;
            var jeong3 = 98;
            var jeong4 = 100;
            var jeong5 = 97;
            var currentAssignments = 5;
            var expectedGrade = "A";

            // Act
            var jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;
            var jeongScore = (decimal)jeongSum / currentAssignments;
            var actualGrade = GetGrade(jeongScore);

            // Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        private string GetGrade(decimal score)
        {
            if (score >= 90)
                return "A";
            else if (score >= 80)
                return "B";
            else if (score >= 70)
                return "C";
            else if (score >= 60)
                return "D";
            else
                return "F";
        }
    }
}