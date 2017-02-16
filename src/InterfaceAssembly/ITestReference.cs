using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InterfaceAssembly
{
    public interface ITestReference
    {

        TestResponse DoSomething(TestRequest request);
       
    }

    public class TestResponse
    {
        public TestRequest Request { get; set; }

        public string Information { get; set; }
    }

    public class TestRequest
    {
        public string Information { get; set; }
    }
}
