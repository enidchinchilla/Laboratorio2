﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Laboratorio2.WCFLayer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface ICustomerService
    {
        [OperationContract]
        string GetData(int value);

        /*[OperationContract]
        CompositeType GetDataUsingDataContract(CompositeType composite);*/

        // TODO: Add your service operations here
    }
}
