using StrategyDesignPatternDemo.ApplicationLayer.Models;

namespace StrategyDesignPatternDemo.ApplicationLayer.Contracts
{
    public interface IPayment
    {
        void CalculateDiscount(Client client);
        void ApplyFees(Client client);
        void MakePayment(Client client);
    }
}