using System;
namespace PierresBakery.Models
{
  public class Pastry
  {
    public int NumberOfPastries {get;set;}
    public Pastry(int numberOfPastries)
    {
      NumberOfPastries = numberOfPastries;
    }

    public static int GetPastryPrice(int numberOfPastries)
    {
      int fiveDollars = (numberOfPastries / 3) * 5;   
      int twoDollars = (numberOfPastries % 3) * 2;      
      int price = fiveDollars + twoDollars;
      return price;
    }
  }
}