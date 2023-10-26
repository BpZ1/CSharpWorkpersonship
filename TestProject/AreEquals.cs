//https://fluentassertions.com/objectgraphs/

namespace TestProject
{
    public class AreEquals
    {
        public class Be
        {
            [Test]
            public void Class() 
            {
                var first = new TestClass("123");
                var second = new TestClass("123");

                first.Should().Be(second);
            }

            [Test]
            public void ClassWithEquals()
            {
                var first = new TestClassWithEquals("123");
                var second = new TestClassWithEquals("123");

                first.Should().Be(second);
            }

            [Test]
            public void Record()
            {
                var first = new TestRecord("123");
                var second = new TestRecord("123");

                first.Should().Be(second);
            }

            [Test]
            public void Enum()
            {
                var first = TestEnum.First;
                var second = TestEnum.First;

                first.Should().Be(second);
            }

            [Test]
            public void Value()
            {
                var first = 1;
                var second = 1;

                first.Should().Be(second);
            }
        }
        public class BeSameAs
        {
            [Test]
            public void Class()
            {
                var first = new TestClass("123");
                var second = new TestClass("123");

                first.Should().BeSameAs(second);
            }

            [Test]
            public void ClassWithEquals()
            {
                var first = new TestClassWithEquals("123");
                var second = new TestClassWithEquals("123");

                first.Should().BeSameAs(second);
            }

            [Test]
            public void Record()
            {
                var first = new TestRecord("123");
                var second = new TestRecord("123");

                first.Should().BeSameAs(second);
            }
        }
        public class BeEquivalentTo
        {
            [Test]
            public void Class()
            {
                var first = new TestClass("123");
                var second = new TestClass("123");

                first.Should().BeEquivalentTo(second);
            }

            [Test]
            public void ClassWithEquals()
            {
                var first = new TestClassWithEquals("123");
                var second = new TestClassWithEquals("123");

                first.Should().BeEquivalentTo(second);
            }

            [Test]
            public void Record()
            {
                var first = new TestRecord("123");
                var second = new TestRecord("123");

                first.Should().BeEquivalentTo(second);
            }
        }
        public class NotBe
        {
            [Test]
            public void Class()
            {
                var first = new TestClass("123");
                var second = new TestClass("123");

                first.Should().NotBe(second);
            }

            [Test]
            public void ClassWithEquals()
            {
                var first = new TestClassWithEquals("123");
                var second = new TestClassWithEquals("123");

                first.Should().NotBe(second);
            }

            [Test]
            public void Record()
            {
                var first = new TestRecord("123");
                var second = new TestRecord("123");

                first.Should().NotBe(second);
            }

            [Test]
            public void Enum()
            {
                var first = TestEnum.First;
                var second = TestEnum.First;

                first.Should().NotBe(second);
            }

            [Test]
            public void Value()
            {
                var first = 1;
                var second = 1;

                first.Should().NotBe(second);
            }
        }
        public class NotBeSameAs
        {
            [Test]
            public void Class()
            {
                var first = new TestClass("123");
                var second = new TestClass("123");

                first.Should().NotBeSameAs(second);
            }

            [Test]
            public void ClassWithEquals()
            {
                var first = new TestClassWithEquals("123");
                var second = new TestClassWithEquals("123");

                first.Should().NotBeSameAs(second);
            }

            [Test]
            public void Record()
            {
                var first = new TestRecord("123");
                var second = new TestRecord("123");

                first.Should().NotBeSameAs(second);
            }
        }
        public class NotBeEquivalentTo
        {
            [Test]
            public void Class()
            {
                var first = new TestClass("123");
                var second = new TestClass("123");

                first.Should().NotBeEquivalentTo(second);
            }

            [Test]
            public void ClassWithEquals()
            {
                var first = new TestClassWithEquals("123");
                var second = new TestClassWithEquals("123");

                first.Should().NotBeEquivalentTo(second);
            }

            [Test]
            public void Record()
            {
                var first = new TestRecord("123");
                var second = new TestRecord("123");

                first.Should().NotBeEquivalentTo(second);
            }
        }
    }
}
