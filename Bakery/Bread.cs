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
    if(this.Amount % 3 != 0)
    {
      var calcAmount = this.Amount/3;
      var left = this.Amount - calcAmount;
      var price = this.Price*2;
      if(left == 1)
      {
        return price*calcAmount+this.Price;
      }
      
      return price*(calcAmount+1);
    }
    else
    {
      var calcAmount = this.Amount/3;
      var price = this.Price*2;
      return calcAmount*price;
    }

    return 0;
  }
}