using System;
using Xunit;

namespace Test1.Tests
{
    public class AlgebraTests
    {
        [Fact()]
        public void AddTest1()
        {
            Algebra al = new Algebra();
            Assert.Equal(2, al.Add(1, 1));
        }

        [Fact()]
        public void AddTest2()
        {
            Algebra al = new Algebra();
            Assert.Equal(3, al.Add(1, 2));
        }

        [Fact()]
        public void AddTest3()
        {
            Algebra al = new Algebra();
            Assert.Equal(2 << 10, al.Add(2 << 9, 2 << 9));
        }

        [Fact()]
        public void AddTestMax()
        {
            Algebra al = new Algebra();
            Assert.Equal(Math.Pow(2, 32) - 2, al.Add(int.MaxValue, int.MaxValue));
        }

        [Fact()]
        public void SubTest1()
        {
            Algebra al = new Algebra();
            Assert.Equal(0, al.Sub(1, 1));
        }
    }
}