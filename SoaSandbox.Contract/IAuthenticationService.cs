using SoaSandbox.Contract.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SoaSandbox.Contract
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        bool SignIn(User user);

        [OperationContract]
        bool SignUp(User user);
    }
}
