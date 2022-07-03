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
    {
      return this.Price;
    }
    else
    {
      var amount = this.Amount/3;
      var left = this.Amount - amount*3;
      var paidAmount = amount*2 + left;
      var free = this.Amount - paidAmount;
      return paidAmount*this.Price;
    }

    return 0;
  }
}