namespace Obscure.Tests;

#if REMOVE_THIS
#region protected

public sealed class TransmorpherTests
{

    /// <summary>
    /// Make this test PASS.
    /// Code inside 'protected' regions must not be changed.
    /// No solution applies to multiple puzzles.
    /// </summary>
    [Test]
    public void MakeThisPass()
    {
        Func<Cat, Dog> transmorpher = Transmorph;

        var actual = transmorpher(new Cat { MakesSound = "Barks" });
        Assert.That(actual is { MakesSound: "Barks" });
    }

    private static Cat Transmorph(Dog dog)
    {
        return new Cat { MakesSound = dog.MakesSound };
    }

}
#endregion

public sealed class Cat
{
    public string MakesSound { get; set; }
}

public sealed class Dog
{
    public string MakesSound { get; set; }
}

#endif