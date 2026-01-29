namespace EncryptionApi.Tests;

public class EncryptionTests
{
    [Fact]
    public void ReverseLogic_ShouldReverseString()
    {
        // Arrange
        var input = "hello";
        var expected = "olleh";

        // Act
        var result = new string(input.Reverse().ToArray());

        // Assert
        Assert.Equal(expected, result);
    }
}