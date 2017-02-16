using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostConsoleAppTest
{
    [DeploymentItem("Support")]
    [TestClass]
    public class ProgramTests
    {

        [TestMethod]
        public void Test_Run_HappyPath()
        {
            HostConsoleApp.Program.Run();
            Assert.IsTrue(true);
        }
        [TestMethod]
        public void Test_CreateTestReference_HappyPath()
        {
            var testReference = HostConsoleApp.Program.CreateTestReference();
            testReference.Should().NotBeNull();
        }

    }
}
