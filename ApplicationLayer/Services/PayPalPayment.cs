using StrategyDesignPatternDemo.ApplicationLayer.Contracts;
using StrategyDesignPatternDemo.ApplicationLayer.Models;
using static System.Console;

namespace StrategyDesignPatternDemo.ApplicationLayer.Services
{
    public sealed class PayPalPayment : IPayment
    {
        public void ApplyFees(Client client)
        {
            WriteLine("ApplyFees in PayPalPayment");
        }

        public void CalculateDiscount(Client client)
        {
            WriteLine("CalculateDiscount in PayPalPayment");
        }

        public void MakePayment(Client client)
        {
            WriteLine("MakePayment in PayPalPayment");
        }
    }
}