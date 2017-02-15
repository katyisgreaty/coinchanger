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

      if (centAmount == 1)
      {
        penny = 1;
      }
      else if (centAmount == 5)
      {
        nickel = 1;
      }
      else if (centAmount == 10)
      {
        dime = 1;
      }
      else if (centAmount == 25)
      {
        quarter = 1;
      }
      else if (centAmount % 25 == 0)
      {
        quarter = centAmount / 25;
      }
      else if (centAmount % 10 == 0)
      {
        dime = centAmount / 10;
      }
      else if (centAmount % 5 == 0)
      {
        nickel = centAmount / 5;
      }
      else if (centAmount % 1 == 0)
      {
        penny = centAmount;
      }

      Dictionary<string, int> newDictionary = new Dictionary<string, int>{};
      newDictionary.Add("quarters", quarter);
      newDictionary.Add("dimes", dime);
      newDictionary.Add("nickels", nickel);
      newDictionary.Add("pennies", penny);
      return newDictionary;
    }


  }

}
