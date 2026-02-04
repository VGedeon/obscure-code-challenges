namespace Obscure.Tests;

public sealed class ToString
{
    #region protected

    /// <summary>
    /// Make this test PASS.
    /// Code inside 'protected' regions must not be changed.
    /// No solution applies to multiple puzzles.
    /// </summary>
    [Test]
    public void MakeThisPass()
    {
        var actual = new object();
        Assert.That(actual.ToString() == "TestString");
    }

    #endregion
}

public static class StringExtensions
{
    public static string ToString(this object obj)
    {
        return "TestString";
    }
}
