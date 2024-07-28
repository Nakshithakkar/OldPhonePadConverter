using System;
using NUnit.Framework;

[TestFixture]
public class OldPhonePadConverterTests
{
    private OldPhonePadConverter converter;

    [SetUp]
    public void SetUp()
    {
        converter = new OldPhonePadConverter();
    }

    [Test]
    public void TestSimpleInput()
    {
        Assert.AreEqual("HI", converter.Convert("44 444#"));
    }

    [Test]
    public void TestLongerPhrase()
    {
        Assert.AreEqual("HOW ARE YOU", converter.Convert("4466690277733099966688#"));
    }

    [Test]
    public void TestWithoutEndMarker()
    {
        Assert.AreEqual("I AM FINE", converter.Convert("4440 260 3334446633"));
    }
   
} 
