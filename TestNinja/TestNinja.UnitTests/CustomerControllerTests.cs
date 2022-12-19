using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class CustomerControllerTests
    {
        [Test]
        public void GetCustomer_IdIsZero_ReturnNotFound()
        {
            // 1. creating controller Object
            var controller = new CustomerController();

            // 2. and call GetCustomer and pasing a 0 as the argument and keeping the result as a variable
            var result = controller.GetCustomer(0);

            // 3. now we want to Assert that this resultis NotFound object
            // 1 way:              TypeOf means - NotFound
            Assert.That(result, Is.TypeOf<NotFound>());

            // Another wayto write this Assertion InstanceOf means - NotFound or one of its derivatives
            // Assert.That(result, Is.InstanceOf<NotFound>());


        }

        [Test]
        public void GetCustomer_IsIsNotZero_ReturnOk()
        {

        }
    }
}
