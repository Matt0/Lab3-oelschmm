using System;
using Expedia;
using NUnit.Framework;

namespace ExpediaTest
{
	[TestFixture()]
	public class FlightTest
	{


        [Test()]
        public void TestThatFlightInitializes()
        {
            var target = new Flight(new DateTime(1992, 2, 20), new DateTime(1992, 2, 21), 10);
            Assert.IsNotNull(target);
        }

        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestThatFlightThrowsExceptionOnInvalidDate()
        {
            var target = new Flight(new DateTime(1992, 2, 21), new DateTime(1992, 2, 20), 10);
        }

        [Test()]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestThatFlightThrowsExceptionOnNegativeMiles()
        {
            var target = new Flight(new DateTime(1992, 2, 20), new DateTime(1992, 2, 21), -10);
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForOneDayFlight()
        {
            var target = new Flight(new DateTime(1992, 2, 20), new DateTime(1992, 2, 21), 10);
            Assert.AreEqual(220, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTwoDayFlight()
        {
            var target = new Flight(new DateTime(1992, 2, 20), new DateTime(1992, 2, 22), 10);
            Assert.AreEqual(240, target.getBasePrice());
        }

        [Test()]
        public void TestThatFlightHasCorrectBasePriceForTenDaysFlight()
        {
            var target = new Flight(new DateTime(1992, 3, 20), new DateTime(1992, 3, 30), 10);
            Assert.AreEqual(400, target.getBasePrice());
        }
	}
}
