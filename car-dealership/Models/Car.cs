using System;

namespace Dealership
{
  class Car
  {
    private string MakeModel;
    private int Miles;
    private int Price;
    private string Message;

    public Car(string makeModel, int price, int miles)
    {
      MakeModel = makeModel;
      Price = price;
      Miles = miles;
    }

    public string GetMakeModel()
    {
      return MakeModel;
    }

    public int GetMiles()
    {
      return Miles;
    }

    public int GetPrice()
    {
      return Price;
    }

    public string GetMessage()
    {
      return Message;
    }

    public void SetMakeModel(string makeModel)
    {
      MakeModel = makeModel;
    }

    public void SetMiles(int miles)
    {
      Miles = miles;
    }

    public void SetPrice(int price)
    {
      Price = price;
    }

    public void SetMessage(string message)
    {
      Message = message;
    }

    public bool WorthBuying(int budget, int miles)
    {
      return (Price <= budget && Miles <= miles);
    }
  }
}
