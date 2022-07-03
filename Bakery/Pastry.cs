using System;

public class Pastry: IBakery
{
  public int Amount { get; set; }
  public int Price { get; set; }

  public Pastry(int amount, int price)
  {
    Amount = amount;
    Price = price;
  }

  public int calculatePrice()
  {
    

    return 0;
  }
}