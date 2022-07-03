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
    if(this.Amount == 1)
      return this.Price = 2;
    if(this.Amount == 2)
    {
      return this.Amount*2;
    }
    else
    {
      var amountDiscount = this.Amount/3;
      var finalPrice = (this.Amount-amountDiscount)*2+amountDiscount;
      return finalPrice;
    }

    return 0;
  }
}