using NUnit.Framework;
using Core;

namespace Tests.UnitTests
{
    public class CartTests
    {
        [Test] // BLACK BOX
        public void AddProduct_ShouldIncreaseCount()
        {
            var cart = new Cart();
            cart.AddProduct(new Product("Phone", 500));

            Assert.AreEqual(1, cart.Products.Count);
        }

        [Test] // WHITE BOX
        public void TotalPrice_ShouldBeCorrect()
        {
            var cart = new Cart();
            cart.AddProduct(new Product("Laptop", 1000));

            var total = cart.GetTotalPrice();

            Assert.AreEqual(1000, total); // FAIL
        }

        [Test] // GRAY BOX
        public void Discount_ShouldNotApply_ForSingleProduct()
        {
            var cart = new Cart();
            cart.AddProduct(new Product("Mouse", 100));

            var total = cart.GetTotalPrice();

            Assert.AreEqual(100, total); // FAIL
        }

        [Test]
        public void MultipleProducts_TotalShouldBeCorrect()
        {
            var cart = new Cart();
            cart.AddProduct(new Product("A", 100));
            cart.AddProduct(new Product("B", 200));

            var total = cart.GetTotalPrice();

            Assert.AreEqual(300, total); // FAIL
        }

        [Test]
        public void EmptyCart_TotalShouldBeZero()
        {
            var cart = new Cart();

            var total = cart.GetTotalPrice();

            Assert.AreEqual(0, total); // FAIL
        }
    }
}