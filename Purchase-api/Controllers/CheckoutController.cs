using Microsoft.AspNetCore.Mvc;
using PurchaseApi.Models;
using PurchaseApi.Services;

namespace PurchaseApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckoutController(ICartService cartService, IPaymentService paymentService, IShipmentService shipmentService) : ControllerBase
    {
        [HttpPost]
        public string ConductCheckout(Cart cart)
        {
            decimal totalAmount = cartService.TotalSum(cart.items);

            if (paymentService.Charge(totalAmount, cart.card))
            {
                string shipData = shipmentService.Ship(cart.addressInfo, cart.items);

                return shipData;
            } else
            {

                return "not charged";

            }

        }
    }
}