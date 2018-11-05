using StrategyDesignPatternDemo.ApplicationLayer.Contracts;
using StrategyDesignPatternDemo.ApplicationLayer.Models;

namespace StrategyDesignPatternDemo.ApplicationLayer.Controllers
{
    public class PaymentController
    {
        readonly IPayment ipayment;

        public PaymentController(IPayment ipayment)
        {
            this.ipayment = ipayment;
        }

        public void StartPayment(Client client)
        {
            ipayment.ApplyFees(client);
            ipayment.CalculateDiscount(client);
            ipayment.MakePayment(client);
        }
    }
}