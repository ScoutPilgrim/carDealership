using System;
using System.Collections.Generic;

namespace Dealership
{
  class Program
  {
    static void Main()
    {
      Car porsche =  new Car("2014 Porsche 911", 114991, 7864);
      Car ford = new Car("2011 Ford F450", 55995, 14241);
      Car lexus = new Car("2013 Lexus RX 350", 44700, 20000);
      Car mercedes = new Car("Mercedes Benz CLS550", 39900, 37979);

      List<Car> Cars = new List<Car>() {porsche, ford, lexus, mercedes};

      string messageStr = "This car is ";
      Console.WriteLine("Name your maximum price:");
      string budgetString = Console.ReadLine();
      int budget = int.Parse(budgetString);

      Console.WriteLine("Name your maximum desired miles:");
      string milesString = Console.ReadLine();
      int miles = int.Parse(milesString);

      porsche.SetMessage(messageStr + "nice!");
      ford.SetMessage(messageStr + "tough.");
      lexus.SetMessage(messageStr + "gaudy.");
      mercedes.SetMessage(messageStr + "mega-gaudy.");


      List<Car> CarsWithinBudget = new List<Car>(0);

      foreach (Car auto in Cars)
      {
        if(auto.WorthBuying(budget, miles))
        {
          CarsWithinBudget.Add(auto);
        }
      }
      if(CarsWithinBudget.Count == 0){
          Console.WriteLine("No cars have met your conditions.");
          return;
      }

      foreach (Car auto in CarsWithinBudget)
      {
        Console.WriteLine("-------------");
        Console.WriteLine(auto.GetMakeModel());
        Console.WriteLine(auto.GetMiles() + " miles");
        Console.WriteLine("$" + auto.GetPrice());
        Console.WriteLine(auto.GetMessage());
      }
    }
  }
}
