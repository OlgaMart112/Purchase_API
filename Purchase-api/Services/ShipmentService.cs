using PurchaseApi.Models;
using System.Globalization;

namespace PurchaseApi.Services
{
    public class ShipmentService(ICartService cartService) : IShipmentService
    {
        public string Ship(AddressInfo info, IEnumerable<CartItem> items)
        {
            decimal totalSum = cartService.TotalSum(items);
            int quantity = cartService.TotalQuantity(items);

            return ($"Shipped {quantity} items to  {info.City} on total sum {totalSum.ToString("0.00$", CultureInfo.InvariantCulture)}");
        }
    }
}
