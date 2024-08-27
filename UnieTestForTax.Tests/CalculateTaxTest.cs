using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using UnieTestForTax;


namespace UnieTestForTax.Tests;

[TestClass]
[TestSubject(typeof(CalculateTax))]
public class CalculateTaxTest
{
    [TestMethod]
    public void Given_Income_100000_When_CalculateTax_Then_5000()
    {
        decimal income = 100000;
        decimal expected = 5000;
        
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        decimal tolerance = 0.5m; // 誤差值設置為 0.5
        var actual =oper.Calculate(income);
    
        Assert.AreEqual(expected, actual,tolerance );
    }

    
    [TestMethod]
    public void Given_Income_540_000_When_CalculateTax_Then_27_000()
    {
        decimal icome = 540_000;
        decimal expected = 27_000;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = oper.Calculate(icome);
    
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Given_Income_540_001_When_CalculateTax_Then_27_000_12()
    {
        decimal icome = 540_001m;
        decimal expected = 27_000.12m;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = oper.Calculate(icome);
    
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Given_Income_1_210_000_When_CalculateTax_Then_107_400()
    {
        decimal icome = 1_210_000m;
        decimal expected = 107_400m;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = Math.Ceiling(oper.Calculate(icome));
    
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Given_Income_1_218_000_When_CalculateTax_Then_109_000()
    {
        decimal icome = 1_218_000;
        decimal expected = 109_000;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = Math.Ceiling(oper.Calculate(icome));
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Given_Income_2_420_000_When_CalculateTax_Then_349_400()
    {
        decimal icome = 2_420_000;
        decimal expected = 349_400;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = oper.Calculate(icome);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Given_Income_2_500_000_When_CalculateTax_Then_373_400()
    {
        decimal icome = 2_500_000;
        decimal expected = 373_400;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = oper.Calculate(icome);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Given_Income_4_530_000_When_CalculateTax_Then_982_400()
    {
        decimal icome = 4_530_000;
        decimal expected = 982_400;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = oper.Calculate(icome);
        Assert.AreEqual(expected, actual);
    }
    
    [TestMethod]
    public void Given_Income_5_530_000_When_CalculateTax_Then_1_382_400()
    {
        decimal icome = 5_530_000;
        decimal expected = 1_382_400;
        var list = TaxProvider.GivenTaxList();
        CalculateTax oper = new();
        var actual = oper.Calculate(icome);
        Assert.AreEqual(expected, actual);
    }
}