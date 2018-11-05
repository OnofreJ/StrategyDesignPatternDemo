using StrategyDesignPatternDemo.ApplicationLayer.Contracts;
using StrategyDesignPatternDemo.ApplicationLayer.Models;
using static System.Console;

namespace StrategyDesignPatternDemo.ApplicationLayer.Services
{
    class InvoicePayment : IPayment
    {
        public void ApplyFees(Client client)
        {
            WriteLine("ApplyFees in InvoicePayment");
        }

        public void CalculateDiscount(Client client)
        {
            WriteLine("CalculateDiscount in InvoicePayment");
        }

        public void MakePayment(Client client)
        {
            WriteLine("MakePayment in InvoicePayment");
        }
    }
}