using PurchaseApi.Models;

namespace PurchaseApi.Services
{
    public class PaymentService : IPaymentService
    {
        public bool Charge (decimal totalPrice, Card card)
        {
            if (card.ValidTo < DateTime.Today)
            {
                return false;
            }

            return true;
        }
    }
}
