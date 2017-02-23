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
        //Either Test_CreateTestReference_HappyPath or Test_createTestReference_NoDot will fail
        [TestMethod]
        public void Test_CreateTestReference_HappyPath()
        {
            var testReference = HostConsoleApp.Program.CreateTestReference();
            testReference.Should().NotBeNull();
        }
        [TestMethod]
        public void Test_CreateTestReference_NoDot()
        {
            var testReference = HostConsoleApp.Program.CreateTestReferenceNoDot();
            testReference.Should().NotBeNull();
        }

    }
}
