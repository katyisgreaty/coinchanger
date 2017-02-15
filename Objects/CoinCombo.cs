using Nancy;
using System;
using System.Collections.Generic;

namespace CoinComboMaker.Objects
{
  public class CoinCombo
  {
    private int _centAmount;

    public CoinCombo (int centAmount)
    {
      _centAmount = centAmount;
    }

    public int GetCentAmount()
    {
      return _centAmount;
    }

    public Dictionary<string, int> MakeChange()
    {
      int quarter = 0;
      int dime = 0;
      int nickel = 0;
      int penny = 0;
      int centAmount = GetCentAmount();

      quarter = centAmount / 25;
      centAmount -= (quarter * 25);
      dime = centAmount / 10;
      centAmount -= dime * 10;
      nickel = centAmount / 5;
      centAmount -= nickel * 5;
      penny = centAmount;


      Dictionary<string, int> newDictionary = new Dictionary<string, int>{};
      newDictionary.Add("quarters", quarter);
      newDictionary.Add("dimes", dime);
      newDictionary.Add("nickels", nickel);
      newDictionary.Add("pennies", penny);
      return newDictionary;
    }


  }

}
