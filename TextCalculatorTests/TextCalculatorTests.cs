using System;
using Xunit;

public class TextCalculatorTests
{
     private readonly TextCalculator _calculator = new TextCalculator();

     [Fact]
     public void Add_EmptyString_ReturnsZero()
     {
          Assert.Equal("0", _calculator.Add(""));
     }

     [Fact]
     public void Add_SingleNumber_ReturnsNumber()
     {
          Assert.Equal("1", _calculator.Add("1"));
     }

     [Fact]
     public void Add_TwoNumbers_ReturnsSum()
     {
          Assert.Equal("12", _calculator.Add("5,7"));
     }

     [Fact]
     public void Add_DecimalNumbers_ReturnsSum()
     {
          Assert.Equal("4.5", _calculator.Add("1.1,3.4"));
     }

     [Fact]
     public void Add_MultipleNumbers_ReturnsSum()
     {
          Assert.Equal("15.5", _calculator.Add("1.1,3.4,11"));
     }

     [Fact]
     public void Add_MissingNumberInLastPosition_ThrowsException()
     {
          var ex = Assert.Throws<InvalidOperationException>(() => _calculator.Add("1,3,"));
          Assert.Equal("Missing number in last position.", ex.Message);
     }

     [Fact]
     public void Add_NegativeNumbers_ThrowsException()
     {
          var ex = Assert.Throws<InvalidOperationException>(() => _calculator.Add("-1,2"));
          Assert.Equal("Negative not allowed: -1", ex.Message);
     }

     [Fact]
     public void Add_MultipleNegativeNumbers_ThrowsException()
     {
          var ex = Assert.Throws<InvalidOperationException>(() => _calculator.Add("7,-4,1,-5"));
          Assert.Equal("Negative not allowed: -4, -5", ex.Message);
     }
}
