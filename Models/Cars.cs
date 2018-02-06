using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    private static List<Car> _instances = new List<Car> {};

    public string MakeModel;
    public string Year;
    public string Color;
    public int Mileage;
    private int _price;
    private bool _isNew;

    public Car(string makeModel, string year, string color, int mileage, int price, bool isNew)
    {
      MakeModel = makeModel;
      Year = year;
      Color = color;
      Mileage = mileage;
      _price = price;
      _isNew = isNew;
    }

    public int GetPrice()
    {
      return _price;
    }

    public void SetPrice(int price)
    {
      _price = price;
    }

    public bool CheckIsNew()
    {
      return _isNew;
    }

    public void SetIsNew(bool isNew)
    {
      _isNew = isNew;
    }

    public void Save()
    {
     _instances.Add(this);
    }


  }
}
