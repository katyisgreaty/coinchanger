using Xunit;
using CoinComboMaker.Objects;
using System;
using System.Collections.Generic;

namespace CoinComboMaker
{
  public class CoinComboTest
  {
    [Fact]
    public void MakeChange_ForOneReturnsOnePenny_onePenny()
    {
      //arrange
      int inputtedNumber = 1;
      CoinCombo testCoinCombo = new CoinCombo(inputtedNumber);

      //act
      Dictionary<string, int> output = testCoinCombo.MakeChange();

      //assert
      Dictionary<string, int> testNumber = new Dictionary<string, int>{};
      testNumber.Add("quarters", 0);
      testNumber.Add("dimes", 0);
      testNumber.Add("nickels", 0);
      testNumber.Add("pennies", 1);

      Assert.Equal(testNumber, output);
    }
  }
}
