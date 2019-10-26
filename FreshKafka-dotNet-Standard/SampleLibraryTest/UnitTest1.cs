using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SampleLibraryTest
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.IsTrue(FreshKafka_dotNet_Standard.Class1.isValidString(""));
			Assert.IsFalse(FreshKafka_dotNet_Standard.Class1.isValidString(null));
		}
	}
}
