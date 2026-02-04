namespace Obscure.Tests;

public sealed class ThrowsTests
{
    #region protected
    
    /// <summary>
    /// Make this test PASS.
    /// Code inside 'protected' regions must not be changed.
    /// No solution applies to multiple puzzles.
    /// </summary>
    [Test]
    public static void MakeThisPass()
    {
        var left = ProcureValue();

        if (left.ToString() == null)
        {
            Assert.Fail();
        }

        Assert.Throws<NullReferenceException>(() => Console.WriteLine(left.GetType()));
    }

    #endregion

    private static object ProcureValue()
    {
        throw new NotImplementedException();
    }
}