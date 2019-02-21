using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFApp.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "FirstWebService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select FirstWebService.svc or FirstWebService.svc.cs at the Solution Explorer and start debugging.
    public class FirstWebService : IFirstWebService
    {
        public string Message()
        {
            return "Hello this is my first WCF web service";
        }

        public int add(int x, int y)
        {
            return x + y;
        }
    }
}
