using Xunit;

namespace NuGet.Workflow.Tests
{
    public class FooTests
    {
        [Fact]
        public void Test1()
        {
            var target = new Foo();

            var actual = target.GetOk(); 

            Assert.Equal("Ok", actual);
        }
    }
}
