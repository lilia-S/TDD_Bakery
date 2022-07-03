using System;

public class Bread: IBakery
{
  public int Amount { get; set; }
  public int Price { get; set; }

  public Bread(int amount, int price)
  {
    Amount = amount;
    Price = price;
  }

  public int calculatePrice()
  {
    if(this.Amount == 1)
      return this.Price;
    if(this.Amount == 2)
      return this.Price*2;

    return 0;
  }
}