using NUnit.Framework;

namespace TestProject
{
    public class TaskTests
    {
        [TestCase(true)]
        [TestCase(false)]
        public void Should_NotThrows_NoAsyncMethod(bool throws)
        {
            var task = () => DoStuff(throws);

            task.Should().NotThrow<Exception>();
        }

        [TestCase(true)]
        [TestCase(false)]
        public void Should_NotThrow_AsyncMethod(bool throws)
        {
            var task = () => DoStuffAsync(throws);

            task.Should().NotThrowAsync<Exception>();
        }

        [TestCase(true)]
        [TestCase(false)]
        public async Task Should_NotThrow_AsyncMethod_Await(bool throws)
        {
            var task = () => DoStuffAsync(throws);

            await task.Should().NotThrowAsync<Exception>();
        }

        [TestCase(true)]
        [TestCase(false)]
        public async Task Should_NotThrow_AsyncMethod_Await_AdditionalSyntax(bool throws)
        {
            var task = async () => await DoStuffAsync(throws);

            await task.Should().NotThrowAsync<Exception>();
        }

        [TestCase(true)]
        [TestCase(false)]
        public void JustCallingAMethod(bool throws)
        {
            PerformDoStuffAndAssert(throws);   
        }

        [Test]
        public async Task StackTraceTest1()
        {
            var task = async () => await Method1();

            await task.Should().NotThrowAsync<Exception>();
        }

        [Test]
        public async Task StackTraceTest2()
        {
            var task = () => Method1();

            await task.Should().NotThrowAsync<Exception>();
        }

        [Test]
        public async Task OldFluentAssertionsCheckReturnValue()
        {
            bool? result = null;
            var task = async () => result = await ReturnStuffAsync(false);

            await task.Should().NotThrowAsync<Exception>();
            result.Should().BeTrue();
        }

        [Test]
        public async Task NewFluentAssertionsCheckReturnValue2()
        {

            var task = () => ReturnStuffAsync(false);

            // Act-Assert
            await task.Should().NotThrowAsync().WithResult(true);
        }


        //TestMethods

        private void DoStuff(bool throws)
        {
            Thread.Sleep(2000);
            if (throws)
            {
                throw new Exception();
            }
        }

        private async Task DoStuffAsync(bool throws)
        {
            await Task.Run(() => Thread.Sleep(2000));
            if(throws)
            {
                throw new Exception();
            }
        }

        private async Task<bool> ReturnStuffAsync(bool throws)
        {
            await Task.Run(() => Thread.Sleep(2000));
            if (throws)
            {
                throw new Exception();
            }
            return true;
        }

        public void PerformDoStuffAndAssert(bool throws)
        {
            var doStuff = () => DoStuffAsync(throws);
            doStuff.Should().NotThrowAsync();
        }

        public async Task Method1()
        {
            await Method2();
        }

        public async Task Method2()
        {
            await Method3();
        }

        public async Task Method3()
        {
            var doStuff = () => DoStuffAsync(true);
            await doStuff.Should().NotThrowAsync();
        }
    }
}