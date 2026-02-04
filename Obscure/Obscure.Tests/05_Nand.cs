namespace Obscure.Tests;

public sealed class NandTest
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
        if (DoStuff() && Predicate())
        {
            Assert.Pass("Nice!");
        }

        Assert.Fail("Zonk!");
    }

    private static bool Predicate()
    {
        throw new Exception("Hehe ;-)");
    }

    #endregion

    private static bool DoStuff()
    {
        return false;
    }
}
