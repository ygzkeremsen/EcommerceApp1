namespace Core
{
    public class OrderService
    {
        public bool PlaceOrder(Cart cart)
        {
            if (cart == null)
                return true; // HATA

            return true;
        }

        public bool ProcessPayment(double amount)
        {
            return amount >= 0; // HATA
        }
    }
}