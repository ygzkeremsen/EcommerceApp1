using NUnit.Framework;
using Core;

namespace Tests.IntegrationTests
{
    public class OrderIntegrationTests
    {
        [Test] // INTEGRATION TEST
        public void FullOrderProcess_ShouldWork()
        {
            var cart = new Cart();
            cart.AddProduct(new Product("Keyboard", 200));

            var service = new OrderService();

            var order = service.PlaceOrder(cart);
            var payment = service.ProcessPayment(cart.GetTotalPrice());

            Assert.IsTrue(order);
            Assert.IsTrue(payment);
        }
    }
}