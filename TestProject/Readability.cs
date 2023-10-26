namespace TestProject
{
    internal class Readability
    {
        public class ListDoesNotContainExpectedValue
        {

            [Test]
            public void Good()
            {
                var first = new List<string>()
                {
                    "first",
                    "second",
                    "third"
                };
                var expectedValue = "fourth";

                first.Contains(expectedValue).Should().BeTrue();
            }
            [Test]
            public void Bad()
            {
                var first = new List<string>()
                {
                    "first",
                    "second",
                    "third"
                };
                var expectedValue = "fourth";

                first.Should().Contain(expectedValue);
            }
        }

        public class ListShouldOnlyHaveOneValue
        {

            [Test]
            public void Good()
            {
                var values = new List<string>()
                {
                    "first",
                    "second",
                    "third"
                };

                values.Count().Should().Be(1);
            }
            [Test]
            public void Bad()
            {
                var values = new List<string>()
                {
                    "first",
                    "second",
                    "third"
                };
                var expectedValue = "first";

                values.Should().ContainSingle(expectedValue);
            }
        }

        public class Other 
        {
            [Test]
            public void AdditionalInfo()
            {
                var value = false;

                value.Should().BeTrue("This value should be true because ... which could mean ...");
            }

            [Test]
            public void BadOutPut()
            {
                var first = new TestClass("123");
                var second = new TestClass("123");

                first.Should().Be(second);
            }

            [Test]
            public void ClassWithEquals()
            {
                var first = new TestClassWithEquals("123");
                var second = new TestClassWithEquals("456");

                first.Should().Be(second);
            }
        }
    }
}
