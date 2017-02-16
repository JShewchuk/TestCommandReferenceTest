using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using InterfaceAssembly;

namespace ImplAssembly
{
    public class TestReference   : InterfaceAssembly.ITestReference
    {
        public TestReference()
        {
        }

        public TestResponse DoSomething(TestRequest request)
        {
            TestResponse response = new TestResponse()
            { Request = request
            , Information = string.Format("Request received to do something at [{0}] in class [{1}]", DateTime.UtcNow.ToString(), typeof(TestReference).FullName)  };

            return response;
        }
    }
}
