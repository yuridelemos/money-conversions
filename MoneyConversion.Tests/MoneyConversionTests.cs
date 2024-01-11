global using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MoneyConversion.Tests;

[TestClass]
public class MoneyConversionTests
{
    [TestMethod]
    public void ShouldConvertDecimalToInt()
    {
        decimal valor = 279.98M;
        var cents = valor.ToCents();
        
        Assert.AreEqual(27998, cents);
    }
}