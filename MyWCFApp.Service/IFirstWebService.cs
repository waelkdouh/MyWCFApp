﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MyWCFApp.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IFirstWebService" in both code and config file together.
    [ServiceContract]
    public interface IFirstWebService
    {
        [OperationContract]
        string Message();


        [OperationContract]
        int add(int x, int y);
    }
}
