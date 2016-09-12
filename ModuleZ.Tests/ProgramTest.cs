using System;
using Xunit;

namespace ModuleZ
{
    public class ProgramTest
    {
        [Fact]
        public void TestGetMessage()
        {
            var o = new Program();
            Assert.Equal("Hello world", o.GetMessage());
        }
    }
}
