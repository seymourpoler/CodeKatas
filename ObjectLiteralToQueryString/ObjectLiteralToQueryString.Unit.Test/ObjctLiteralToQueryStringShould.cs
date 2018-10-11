using NUnit.Framework;
using Shouldly;

namespace ObjectLiteralToQueryString.Unit.Test
{
    [TestFixture]
	public class ObjctLiteralToQueryStringShould
    {
		ObjectLiteralToQueryString objectLiteralToQueryString;

		[SetUp]
        public void SetUp()
		{
			objectLiteralToQueryString = new ObjectLiteralToQueryString();
		}

		[Test]
        public void ReturnsEmptyStringWhenIsNull()
		{
			var result = objectLiteralToQueryString.ToQueryString(null);

			result.ShouldBe(string.Empty);
		}
    }
}
