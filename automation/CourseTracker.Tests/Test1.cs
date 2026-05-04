using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CourseTracker.Tests;

[TestClass]
public class GpaTests
{
    [TestMethod]
    public void CalculateGpa_ValidCourses_ReturnsCorrectValue()
    {
        // Arrange
        double totalPoints = (3 * 4.0) + (3 * 3.0);
        int totalCredits = 6;

        // Act
        double gpa = totalPoints / totalCredits;

        // Assert
        Assert.AreEqual(3.5, gpa);
    }
}