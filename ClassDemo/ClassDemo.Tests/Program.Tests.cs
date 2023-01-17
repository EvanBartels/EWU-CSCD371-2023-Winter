using Microsoft.VisualStudio.TestTools.UnitTesting; 
//this stuff very important to have

namespace ClassDemo.Tests;

[TestClass]
public class ProgramTests
{
    [TestMethod]
    public void GetName_InigoMontoya_InigoMontoya()
    {
        string actual = Program.GetName("Inigo", "Montoya");
        Assert.AreEqual<string>("Inigo Montoya", actual);
    }

    string? Text = "Inigo Montoya";
    // in your .tests file do
    // <TreatWarningAsErrors>true</TreatWarningAsErrors> (might be enable, not true) <TreatWarningsAsErrors>true</TreatWarningsAsErrors>
    // before turning in homework
    void Method(string text)
    {
        if (Text is not null) 
        { 
            Text.Replace("n", "l");
        }
        //string text1 = Text?.Replace("n", "l");

        Text = text;
    }

    [TestMethod]
    public void PlayingWithIntegers()
    {
        int number = 42;
        Assert.AreEqual("Int32", number.GetType().Name);
    }

    [TestMethod]
    public void PlayingWithStrings()
    {
        string number = "forty-two";
        Assert.AreEqual("System.String", number.GetType().FullName);
    }
}