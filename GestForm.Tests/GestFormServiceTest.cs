using System.Collections.Generic;
using Xunit;

namespace GestForm.Tests;

/// <summary>
/// Gest Form Service Test
/// </summary>
public class GestFormServiceTest
{
    /// <summary>
    /// Writes the label test.
    /// </summary>
    /// <param name="number">The number.</param>
    /// <param name="label">The label.</param>
    [Theory]
    [InlineData(486, "Gest")]
    [InlineData(430, "Form")]
    [InlineData(15, "Gest\nGestform")]
    [InlineData(838, "838")]
    public void WriteLabelTest(int number, string label)
    {
        string result = GestFormService.WriteLabel(number);
        Assert.NotNull(result);
        Assert.NotEmpty(result);
        Assert.Equal(label, result);
    }

    /// <summary>
    /// Generates the random list test.
    /// </summary>
    [Fact]
    public void GenerateRandomListTest()
    {
        IEnumerable<int> numbers = GestFormService.GenerateRandomNumber();
        Assert.NotNull(numbers);
        Assert.NotEmpty(numbers);
    }

    /// <summary>
    /// Runs the test.
    /// </summary>
    [Fact]
    public void RunTest()
    {
        GestFormService.Run();
        Assert.True(true);
    }
}
