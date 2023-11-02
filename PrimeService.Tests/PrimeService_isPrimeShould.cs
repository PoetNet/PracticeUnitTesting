using Microsoft.VisualStudio.TestTools.UnitTesting;
using Prime.Services;

namespace Prime.UnitTests.Services;

[TestClass]
public class PrimeService_isPrimeShould
{
    private readonly PrimeService _primeService;

    public PrimeService_isPrimeShould()
    {
        _primeService = new PrimeService();
    }

    [TestMethod]
    public void IsPrime_InputsPrimes_ReturnTrue()
    {
        int[] primeValues = { 5, 7, 11, 29, 43, 47 };

        foreach (int value in primeValues)
        {
            bool result = _primeService.IsPrime(value);
            Assert.IsTrue(result, $"{value} is prime");
        }
    }

    [TestMethod]
    [DataRow(2)]
    [DataRow(3)]
    public void IsPrime_ValuesLessThan3OrEqual3_ReturnTrue(int value)
    {
        bool result = _primeService.IsPrime(value);
        Assert.IsTrue(result, $"{value} should not be prime");
    }

    [TestMethod]
    [DataRow(-1)]
    [DataRow(0)]
    [DataRow(1)]
    public void IsPrime_InputsLessThan1OrEqual1_ReturnFalse(int value)
    {
        bool result = _primeService.IsPrime(value);
        Assert.IsFalse(result, $"{value} is not prime");
    }

    [TestMethod]
    public void IsPrime_InputsNotPrimes_ReturnTrue()
    {
        int[] primeValues = { 4, 8, 12, 33, 48, 74 };

        foreach (int value in primeValues)
        {
            bool result = _primeService.IsPrime(value);
            Assert.IsFalse(result, $"{value} is not prime");
        }
    }
}