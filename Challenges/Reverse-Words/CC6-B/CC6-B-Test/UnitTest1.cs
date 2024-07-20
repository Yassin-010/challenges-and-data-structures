using CC6_B;

namespace CC6_B_Test
{
    public class ReverseWordsTests
    {
        [Fact]
    public void ReverseWords_Case1()
    {
        // Arrange
        string input = "csharp is programming language";
        string result = "language programming is csharp";

        // Act
        string actual = Program.ReverseWords(input);

        // Assert
        Assert.Equal(result, actual);
    }

    [Fact]
    public void ReverseWords_Case2()
    {
        // Arrange
        string input = "Reverse the words in this sentence";
        string result = "sentence this in words the Reverse";

        // Act
        string actual = Program.ReverseWords(input);

        // Assert
        Assert.Equal(result, actual);
    }

    [Fact]
    public void ReverseWords_Case3()
    {
        // Arrange
        string input = "challenges and data structures";
        string result = "structures data and challenges";

        // Act
        string actual = Program.ReverseWords(input);

        // Assert
        Assert.Equal(result, actual);
    }
    }
}