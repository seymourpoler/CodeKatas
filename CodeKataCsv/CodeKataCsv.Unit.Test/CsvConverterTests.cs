using Shouldly;
using System.Collections.Generic;
using Xunit;

namespace CodeKataCsv.Unit.Test
{
    public class CsvConverterTests
    {
        [Fact]
        public void ReturnsAnEmtpyListWhenTheListIsNull()
        {
            var converter = new CsvConverter();

            var result = converter.Convert((List<User>)null);

            result.ShouldBe(new string[] { });
        }

        [Fact]
        public void ReturnsAnEmtpyListWhenTheListIsEmpty()
        {
            var list = new List<User>();
            var converter = new CsvConverter();

            var result = converter.Convert(list);

            result.ShouldBe(new[] { "Email;FirstName;LastName;Age" });
        }

        [Fact]
        public void ReturnsCsvWhenTheListHasAnEmptyElement()
        {
            var converter = new CsvConverter();

            var result = converter.Convert(new List<User> { new User { } });

            result.ShouldBe(new[] { "Email;FirstName;LastName;Age", ";;;0" });
        }

        [Fact]
        public void ReturnsCsvWhenTheListHasSomeElements()
        {
            var converter = new CsvConverter();

            var result = converter.Convert(new List<User> { new User {Email="a@a.es" } });

            result[1].ShouldBe("a@a.es;;;0");
        }

        [Fact]
        public void ReturnsCsvWhenTheListHasAllElements()
        {
            var converter = new CsvConverter();

            var result = converter.Convert(new List<User> { new User { FirstName = "First", LastName = "Last", Email = "a@a.es", Age = 24 } });

            result[1].ShouldBe("a@a.es;First;Last;24");
        }

        public class User
        {
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }
        }
    }
}
