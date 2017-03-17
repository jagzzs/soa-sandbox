using SoaSandbox.Contract.DataContracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SoaSandbox.Contract
{
    [ServiceContract]
    public interface IAuthenticationService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SignIn", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json | WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Json | WebMessageFormat.Xml)]
        bool SignIn(User user);

        [OperationContract]
        [WebInvoke(Method = "POST", UriTemplate = "SignUp", BodyStyle = WebMessageBodyStyle.Bare, RequestFormat = WebMessageFormat.Json | WebMessageFormat.Xml, ResponseFormat = WebMessageFormat.Json | WebMessageFormat.Xml)]
        bool SignUp(User user);
    }
}
