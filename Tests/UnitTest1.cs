using System;
using Xunit;
using Testing2;

namespace Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            int a = 10;
            int b = 10;
            Assert.Equal(a,b);
        }

        [Fact]
        public void Test2()
        {
            int a = 10;
            int b = 10;
            Assert.Equal(a,b);
        }

        [Fact]
        public void Test3()
        {
            int a = 10;
            int b = 10;
            Assert.Equal(a,b);
        }

        
        [Fact]
        public void Test4()
        {
            int a = 10;
            int b = ToTest.testMethod();
            Assert.Equal(a,b);
        }
        
        [Fact]
        public void TestFail()
        {
            int a = 10;
            int b = 11;
            Assert.Equal(a,b);
        }
        
        [Fact (Skip = "Testing skipping")]
        public void TestIgnore()
        {
            int a = 10;
            int b = 11;
            Assert.Equal(a,b);
        }
    }
}
