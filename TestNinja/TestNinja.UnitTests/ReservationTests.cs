// using Microsoft.VisualStudio.TestTools.UnitTesting; --> this using statement for importing Unit Testing framework
// for NUnit we don't need this statement
using NUnit.Framework;
using System;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    // For NUnit TestFixture // For MSTest --> [TestClass]
    [TestFixture]
    public class ReservationTests
    {
        [Test] //[TestMethod] For MSTest
        public void CanBeCanceledBy_AdminCancelling_ReturnTrue()
        {
            // Arrange
            var reservation = new Reservation();

            // Act 
            var result = reservation.CanBeCancelledBy(new User { IsAdmin = true });


            // Assert
            //  Assert.IsTrue(result);

            // Another ways is to write assertions (is more readable, reads like a plain English)
            // They're aqual, there is no technical differences; It is purely on developer's preference
            Assert.That(result, Is.True);
            // Assert.That(result == true);
        }

        [Test]
        // Name of testing method's  // Scenario       // Expected Behaviour
        public void CanBeCanceledBy_SameUserCancelling_ReturnTrue()
        {
            // Arrange
            var user = new User();
            var reservation = new Reservation { MadeBy = user };

            // Act
            var result = reservation.CanBeCancelledBy(user);

            // Assert
            Assert.IsTrue(result);
        }

        [Test]

        public void CanBeCancelledBy_AnotherUserCancelling_ReturnFalse()
        {
            // Arrange 
            // Here I'm creating a reservation object // In curly braces I'm initializing the reservation and set                                               MadeBy to a different User object
            var reservation = new Reservation { MadeBy = new User() };

            // Act
            // Storing result in a variable // Method call           // Passing User oblect
            var result = reservation.CanBeCancelledBy(new User());

            // Assert
            Assert.IsFalse(result);
        }
    }
}
