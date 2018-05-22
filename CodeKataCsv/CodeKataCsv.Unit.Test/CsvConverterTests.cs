using Shouldly;
using System;
using System.Collections.Generic;
using Xunit;

namespace CodeKataCsv.Unit.Test
{
    public class CsvConverterTests
    {
        [Fact]
        public void ReturnsAnEmtpyListWhenTheListIsEmpty()
        {
            var list = new List<User>();
            var converter = new CsvConverter();

            var result = converter.Convert(list);

            result.ShouldBe(new string[] { });
        }

        [Fact]
        public void ReturnsAnEmtpyListWhenTheListIsNull()
        {
            var converter = new CsvConverter();

            var result = converter.Convert((List<User>)null);

            result.ShouldBe(new string[] { });
        }

        [Fact]
        public void ReturnsCsvWhenTheListHasAnEmptyElement()
        {
            var converter = new CsvConverter();

            var result = converter.Convert(new List<User> { new User { } });

            result.ShouldBe(new string[] { ";;;" });
        }

        class User
        {
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
