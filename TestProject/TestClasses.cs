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

    public class NestedTestClass
    {
        public string Value { get; set; }

        public NestedTestClass? nestedClass { get; set; }

        public NestedTestClass(string value)
        {
            Value = value;
        }

        public static NestedTestClass Get14TimesNestedClass()
        {
            return new NestedTestClass("1")
            {
                nestedClass = new NestedTestClass("2")
                {
                    nestedClass = new NestedTestClass("3")
                    {
                        nestedClass = new NestedTestClass("4")
                        {
                            nestedClass = new NestedTestClass("5")
                            {
                                nestedClass = new NestedTestClass("6")
                                {
                                    nestedClass = new NestedTestClass("7")
                                    {
                                        nestedClass = new NestedTestClass("8")
                                        {
                                            nestedClass = new NestedTestClass("9")
                                            {
                                                nestedClass = new NestedTestClass("10")
                                                {
                                                    nestedClass = new NestedTestClass("11")
                                                    {
                                                        nestedClass = new NestedTestClass("12")
                                                        {
                                                            nestedClass = new NestedTestClass("13")
                                                            {
                                                                nestedClass = new NestedTestClass("14")
                                                                {

                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            };
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
