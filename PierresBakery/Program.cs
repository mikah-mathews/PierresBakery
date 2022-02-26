using System;

namespace PierresBakery.Models
{
  public class Program
  {
    public static void Main()
    {
      bool keepGoing = true;
      int pastries = 0;
      int loaves = 0;
      int totalBill = 0;
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("Have some coffee while you decide what you want.");
      Console.WriteLine(
      "  .-~~-.\n"+
      ",|`-__-'|\n" +
      "||      |\n" +
      "`|      |\n" +
      "  `-__-' \n" 
      );
      Console.WriteLine("-----MENU------");
      Console.WriteLine("| BREAD - $5  |");
      Console.WriteLine("| PASTRY - $2 |");
      Console.WriteLine("---------------");
      Console.WriteLine("We also have 2 specials today.");
      Console.WriteLine("Buy 2 loaves, get 1 for free");
      Console.WriteLine("Buy 1 pastry for $2 or 3 for $5");
      while (keepGoing == true)
      {        
        Console.WriteLine("Do you want to get something? yes to order or no to leave");
        string getSomethingResponse = Console.ReadLine().ToLower();
        if (getSomethingResponse == "yes") 
        {
          Console.WriteLine("Do you want Bread or Pastries?");
          string selectionResponse = Console.ReadLine().ToLower();
          if (selectionResponse == "bread")
          {
            Console.WriteLine("How many loaves do you want?");
            string loafSelectionString = Console.ReadLine();
            int loafSelection = int.Parse(loafSelectionString);
            totalBill += Bread.GetLoafPrice(loafSelection);
            loaves += loafSelection;
            Console.WriteLine("You want " + pastries + " pastries and " + loaves + " loaves of bread. Your total will be $" + totalBill);
          }
          else if (selectionResponse == "pastries")
          {
            Console.WriteLine("How many pastries do you want?");
            string pastrySelectionString = Console.ReadLine();
            int pastrySelection = int.Parse(pastrySelectionString);
            totalBill += Pastry.GetPastryPrice(pastrySelection);
            pastries += pastrySelection;
            Console.WriteLine("You want " + pastries + " pastries and " + loaves + " loaves of bread. Your total will be $" + totalBill);
          }
          else{
            Console.WriteLine("Sorry - can you repeat that?");
          }
        }
        else if (getSomethingResponse == "no")
        {
          keepGoing = false;
        }
        else
        {
          Console.WriteLine("I'm sorry, I didn't catch that. Please type 'yes' or 'no'");
        }
      } 
      Console.WriteLine("Thank you for coming! Have a nice day.");     
    }
  }
}