using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
	[TestClass]
	public class UnitTest1
	{
		[TestMethod]
		public void TestMethod1()
		{
			Assert.IsTrue(FreshKafka_withoutGitignore.Class1.isValidString(""));
			Assert.IsFalse(FreshKafka_withoutGitignore.Class1.isValidString(null));
		}
	}
}
