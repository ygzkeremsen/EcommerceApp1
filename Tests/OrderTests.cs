using NUnit.Framework;
using Core;

namespace Tests
{
    public class OrderTests
    {
        [Test]
        public void PlaceOrder_ShouldFail_WhenCartIsNull()
        {
            var service = new OrderService();

            var result = service.PlaceOrder(null);

            Assert.IsFalse(result); // FAIL
        }

        [Test]
        public void Payment_ShouldFail_ForNegativeAmount()
        {
            var service = new OrderService();

            var result = service.ProcessPayment(-100);

            Assert.IsFalse(result); // FAIL
        }

        [Test]
        public void Payment_ShouldPass_ForValidAmount()
        {
            var service = new OrderService();

            var result = service.ProcessPayment(100);

            Assert.IsTrue(result);
        }

        [Test]
        public void Payment_ShouldPass_ForZeroAmount()
        {
            var service = new OrderService();

            var result = service.ProcessPayment(0);

            Assert.IsTrue(result);
        }

        [Test]
        public void FullOrderProcess_ShouldWork()
        {
            var cart = new Cart();
            cart.AddProduct(new Product("Mouse", 100));

            var service = new OrderService();

            var order = service.PlaceOrder(cart);
            var payment = service.ProcessPayment(cart.GetTotalPrice());

            Assert.IsTrue(order);
            Assert.IsTrue(payment);
        }
    }
}
