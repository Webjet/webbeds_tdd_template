using replaceName.Domain;
using System;
using Xunit;

namespace replaceName.Test
{
    public class DomainThingShould
    {
        [Fact]
        public void Exist()
        {
            var sut = new DoimainThing();
            Assert.NotNull(sut);
        }
    }
}
