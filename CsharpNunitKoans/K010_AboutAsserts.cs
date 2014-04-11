using System;
using NUnit.Framework;

namespace TheKoans
{
	[TestFixture]
	public class K010_AboutAsserts : KoanHelper
	{
		private static readonly Int32 FILL_ME_IN = new Int32 ();
		private static readonly bool FILL_ME__IN;

		[Test]
		public void AssertTruth ()
		{
			Assert.IsTrue (true);   
// Your long journey begins with a simple step.  We seek what's true, help us find it.
		}

		[Test]
		public void AssertsShouldHaveMessages ()
		{
			Assert.IsTrue (true, "This message should help you understand what failed. Please help us find truth.");
		}

		[Test]
		public void AssertFalse ()
		{
			Assert.IsFalse (false, "Truth comes in many forms. Here what is true should be false.");
		}

		[Test]
		public void AssertEquality ()
		{
			Assert.IsTrue (1 == 1, "Truth can be uncovered in boolean expressions when they are true.");
		}

		[Test]
		public void AssertEqualityTheBetterWay ()
		{
			var expectedValue = 2;
			var actualValue = 1 + 1;

			Assert.AreEqual (expectedValue, actualValue, "When your karma is broken it is more helpful to know what was expected and what it actually is.");
		}

		[Test]
		public void AssertFail ()
		{
			bool thePathToEnlightment = true;
			if (!thePathToEnlightment) {
				Assert.Fail ("Taking an unfortunate code path breaks your karma. Change the path towards truth.");
			}
            
			Assert.IsTrue (thePathToEnlightment, "The path has been found.");
		}
	}
}
