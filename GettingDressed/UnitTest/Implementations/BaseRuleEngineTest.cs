using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Dresser.BusinessLogic.Implementations;

namespace UnitTest.Implementations
{
    [TestFixture]
    public class BaseRuleEngineTest
    {
        [Test]
        public void CheckInheritance()
        {
            var sut = new HotRuleEngine();

            Assert.That(sut, Is.InstanceOf<HotRuleEngine>());
            Assert.That(sut, Is.InstanceOf<ColdRuleEngineTest>());
        }
    }
}
