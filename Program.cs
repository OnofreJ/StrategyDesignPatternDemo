using StrategyDesignPatternDemo.ApplicationLayer.Controllers;
using StrategyDesignPatternDemo.ApplicationLayer.Enums;
using StrategyDesignPatternDemo.ApplicationLayer.Models;
using StrategyDesignPatternDemo.ApplicationLayer.Services;
using System;

namespace StrategyDesignPatternDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the payment. Select the type of payment:");
            Console.WriteLine("Credit card = 1, Invoice = 2, PayPal = 3");

            int.TryParse(Console.ReadLine(), out int paymentSelected);

            Client client = new Client();
            PaymentType paymentType = (PaymentType)paymentSelected;

            switch (paymentType)
            {
                case PaymentType.CreditCard:
                    new PaymentController(new CreditCardPayment()).StartPayment(client);
                    break;
                case PaymentType.Invoice:
                    new PaymentController(new InvoicePayment()).StartPayment(client);
                    break;
                case PaymentType.PayPal:
                    new PaymentController(new PayPalPayment()).StartPayment(client);
                    break;
                default:
                    Console.WriteLine("Invalid type of payment.");
                    break;
            }

            Console.Read();
        }
    }
}