namespace Obscure.Tests;

public sealed class CatchThisTests
{
    #region protected

    /// <summary>
    /// Make this test FAIL.
    /// Code inside 'protected' regions must not be changed.
    /// No solution applies to multiple puzzles.
    /// </summary>
    [Test]
    public void MakeThisFail()
    {
        try
        {
            CatchThis();
        }
        catch (Exception ex)
        {
            Assert.Pass(ex.Message);
        }
    }

    #endregion

    private static void CatchThis()
    {
        throw new NotImplementedException();
    }
}
