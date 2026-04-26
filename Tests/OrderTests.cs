using NUnit.Framework;
using Core;

namespace Tests.UnitTests
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
    }
}