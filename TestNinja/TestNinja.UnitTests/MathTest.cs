using NUnit.Framework;
using System.Linq;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    public class MathTests
    {  
        // defined a private field
        private Math _math;

        // Setup method to initialize the object you're going to test
        // TearDown

        [SetUp]
        public void Setup()
        {
            // Initializing Math object to a new instance of the math class
            _math = new Math();
        }

        [Test]
        // Ignore better then just commenting or removing tests because we could forget, but  in Ignore we can put description why we're ignoring it for now and it will be in front of our eyes every time we're running tests
        // [Ignore("Because I wanted to do it!")]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange // (I can remove this line because of I SetUp Math object on lines 10-20) and I need to reference now to our private field now(not instance of the Object)
            //var math = new Math();

            // Act
            var result = _math.Add(1, 2);

            // Assert
             Assert.That(result, Is.EqualTo(3));
            //Assert.That(_math, Is.Not.Null);
        }

        [Test]
        [TestCase(2, 1, 2)]
        [TestCase(1, 2, 2)]
        [TestCase(1, 1, 1)]
        public void Max_WhenCalled_ReturnTheGreaterArgument(int a, int b, int expectedResult)
        {
            // Arrange  First we should to create an instance of the Math Class
            //var math = new Math();

            // Act  After we call the Max method
            var result = _math.Max(a, b);

            // Assert
            Assert.That(result, Is.EqualTo(expectedResult));

        }

        [Test]
        public void GetOddNumbers_LimitIsGreaterThanZero()
        {
            var result = _math.GetOddNumbers(5);

            // Assert.That(result, Is.Not.Empty); // Too General

            // Assert.That(result.Count(), Is.EqualTo(3)); // More specific

            // Assert.That(result, Does.Contain(1)); // Even more specific
            // Assert.That(result, Does.Contain(3));
            // Assert.That(result, Does.Contain(5));

            Assert.That(result, Is.EquivalentTo(new[] { 1, 3, 5 })); // Shorter way to write these 3 assertions

            // Assert.That(result, Is.Ordered); // to be sure items ordered(if it's supposed to be)
            // Assert.That(result, Is.Unique); // to make sure there are no duplicate items in array
        }











        /*
        // Old Way
        [Test]
        public void Add_WhenCalled_ReturnTheSumOfArguments()
        {
            // Arrange // (I can remove this line because of I SetUp Math object on lines 10-20) and I need to reference now to our private field now(not instance of the Object)
            //var math = new Math();

            // Act
            var result = _math.Add(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(3));
        }

        [Test]
        public void Max_FirstArgumentIsGreater_ReturnTheFirstArgument()
        {
            // Arrange  First we should to create an instance of the Math Class
            //var math = new Math();

            // Act  After we call the Max method
            var result = _math.Max(2, 1);

            // Assert
            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Max_SecondArgumentIsGreater_ReturnTheSecondArgument()
        {
            // Arrange  First we should to create an instance of the Math Class (initializing of the Object)
            //var math = new Math();

            // Act  After we call the Max method
            var result = _math.Max(1, 2);

            // Assert
            Assert.That(result, Is.EqualTo(2));

        }

        [Test]
        public void Max_ArgumentsAreEqual_ReturnTheSameArgument()
        {
            // Arrange  First we should to create an instance of the Math Class
            var math = new Math();

            // Act  After we call the Max method
            var result = math.Max(1, 1);

            // Assert
            Assert.That(result, Is.EqualTo(1));

        }
        */

    }
}