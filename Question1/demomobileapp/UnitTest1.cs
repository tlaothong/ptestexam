using System;
using Xunit;

namespace demomobileapp
{
    public class UnitTest1
    {
        // [Theory]
        // [InlineData(100, 10, 90)]
        // [InlineData(80, 10, 70)]
        // [InlineData(90, 10, 80)]
        // [InlineData(1000, 500, 500)]
        // public void ChangeMoney(int mymoney, int price, int expected)
        // {
        //     var c = new CashEngine();
        //     var result = c.ChangeMoneyO(mymoney, price);

        //     Assert.Equal(expected, result);

        // }

        // [Theory]
        // [InlineData(-100)]
        // public void WrongInput(int mymoney)
        // {
        //     var c = new CashEngine();

        //     try
        //     {
        //         c.ChangeMoney(mymoney, 0);

        //         Assert.False(true);
        //     }
        //     catch (Exception ex)
        //     {
        //         Assert.Equal("Input less than 0", ex.Message.ToString());
        //     }

        // }



        // [Theory]
        // [InlineData(1000, 100)]
        // public void OverBud(int mymoney, int price)
        // {
        //     var c = new CashEngine();

        //     try
        //     {
        //         c.ChangeMoney(mymoney, price);
        //         Assert.False(true);
        //     }
        //     catch (Exception ex)
        //     {
        //         Assert.Equal("!! i can't change you cash For Diamond", ex.Message.ToString());
        //     }
        // }

        // [Theory]
        // [InlineData(1100, 500)]
        // public void OverBudO(int mymoney, int price)
        // {
        //     var c = new CashEngine();

        //     try
        //     {
        //         c.ChangeMoneyO(mymoney, price);
        //         Assert.False(true);
        //     }
        //     catch (Exception ex)
        //     {
        //         Assert.Equal("!! i can't change you cash For O", ex.Message.ToString());
        //     }
        // }
    }
}
