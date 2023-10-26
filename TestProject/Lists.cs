namespace TestProject
{
    internal class Lists
    {
        [Test]
        public void Equal_WithValueTypes()
        {
            var first = new List<int>()
                {
                    1,
                    2
                };
            var second = new List<int>()
                {
                    1,
                    2
                };

            first.Should().BeEquivalentTo(second);
        }

        [Test]
        public void Equal_WithValueTypes_DifferentOrder()
        {
            var first = new List<int>()
                {
                    1,
                    2
                };
            var second = new List<int>()
                {
                    2,
                    1
                };

            first.Should().BeEquivalentTo(second);
        }

        [Test]
        public void Equal_WithReferenceTypes_NoEqualsImplemented()
        {
            var first = new List<TestClass>()
                {
                    new TestClass("123"),
                    new TestClass("456"),
                };
            var second = new List<TestClass>()
                {
                    new TestClass("123"),
                    new TestClass("456"),
                };

            first.Should().BeEquivalentTo(second);
        }

        [Test]
        public void Equal_WithReferenceTypes_EqualsImplemented()
        {
            var first = new List<TestClassWithEquals>()
                {
                    new TestClassWithEquals("123"),
                    new TestClassWithEquals("456"),
                };
            var second = new List<TestClassWithEquals>()
                {
                    new TestClassWithEquals("123"),
                    new TestClassWithEquals("456"),
                };

            first.Should().BeEquivalentTo(second);
        }
    }
}
