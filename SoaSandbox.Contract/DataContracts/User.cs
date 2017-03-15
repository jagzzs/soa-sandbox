using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SoaSandbox.Contract.DataContracts
{
    [DataContract]
    public class User
    {
        [DataMember]
        public Guid Id { get; set; }
    
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String Password { get; set; }
    }
}
