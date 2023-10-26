namespace TestProject
{
    public class TestClass
    {
        public string Value { get; set; }

        public TestClass(string value)
        {
            Value = value;
        }
    }

    public class TestClassWithEquals
    {
        public string Value { get; set; }

        public TestClassWithEquals(string value)
        {
            Value = value;
        }

        public override bool Equals(object? obj)
        {
            if (obj is not TestClassWithEquals other)
            {
                return false;
            }
            return other.Value == Value;
        }
    }

    public record TestRecord
    {
        public string Value { get; set; }

        public TestRecord(string value)
        {
            Value = value;
        }
    }

    public enum TestEnum
    {
        First,
        Second,
        Third
    }
}
