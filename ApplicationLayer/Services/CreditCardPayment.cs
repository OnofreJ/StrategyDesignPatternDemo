using StrategyDesignPatternDemo.ApplicationLayer.Contracts;
using StrategyDesignPatternDemo.ApplicationLayer.Models;
using static System.Console;

namespace StrategyDesignPatternDemo.ApplicationLayer.Services
{
    class CreditCardPayment : IPayment
    {
        public void ApplyFees(Client client)
        {
            WriteLine("ApplyFees in CreditCardPayment");
        }

        public void CalculateDiscount(Client client)
        {
            WriteLine("CalculateDiscount in CreditCardPayment");
        }

        public void MakePayment(Client client)
        {
            WriteLine("MakePayment in CreditCardPayment");
        }
    }
}