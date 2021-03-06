﻿using System;
using System.Collections;
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

            result.ShouldBe(String.Empty);
        }

        [Test]
        public void ReturnsEmptyStringWhenIsEmpty()
        {
            var result = objectLiteralToQueryString.ToQueryString(new Hashtable());

            result.ShouldBe(String.Empty);
        }

        [Test]
        public void ReturnsQueryStringWithStringObjectLiteral()
        {
            var result = objectLiteralToQueryString.ToQueryString(new Hashtable{{"a", "b"}});

            result.ShouldBe("a=b");
        }

		[Test]
        public void ReturnsQueryStringWithSomeStringObjectLiterals()
        {
			var result = objectLiteralToQueryString.ToQueryString(new Hashtable { { "keyOne", "valueOne" }, { "keyTwo", "valueTwo" } });

            result.ShouldBe("keyOne=valueOne&keyTwo=valueTwo");
        }
<<<<<<< HEAD

		[Test]
		public void ReturnQueryStringWithObjectLiteral()
		{
			var result = objectLiteralToQueryString.ToQueryString(new Hashtable { { "keyOne", new Hashtable { { "a", "b" } } } });

			result.ShouldBe("keyOne[a]=b");
		}
=======
        [Test]
        public void ReturnsQueryStringWithObjectLiterals()
        {
            var result = objectLiteralToQueryString.ToQueryString(new Hashtable { { "keyOne", new Hashtable { { "a", "b" } } } });

            result.ShouldBe("keyOne[a]=b");
        }
>>>>>>> 80a49857d55fcb3cb25eac86bbf066a684ffa34b
    }
}
