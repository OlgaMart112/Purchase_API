using PurchaseApi.Models;

namespace PurchaseApi.Services
{
    public class CartService : ICartService
    {
        public decimal TotalSum(IEnumerable<CartItem> cartItems)
        {
            decimal totalSum = 0;

            foreach (var item in cartItems)
            {
                totalSum += item.Quantity * item.Price;
            }

            return totalSum;
        }
        
        public int TotalQuantity(IEnumerable<CartItem> cartItems)
        {
            int totalQuantity = 0;

            foreach (var item in cartItems)
            {
                totalQuantity += item.Quantity;
            }

            return totalQuantity;
        }
    }
}
