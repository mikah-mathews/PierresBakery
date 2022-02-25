using System;
namespace PierresBakery.Models
{
  public class Bread
  {
    public int NumberOfLoaves {get;set;}
    public Bread(int numberOfLoaves)
    {
      NumberOfLoaves = numberOfLoaves;
    }

    public static int GetLoafPrice(int numberOfLoaves)
    {
      int free = numberOfLoaves / 3;   
      int loavesToPrice = numberOfLoaves - free;      
      int price = loavesToPrice*5;
      return price;
    }
  }
}