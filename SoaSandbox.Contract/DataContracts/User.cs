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
        public User()
        {
            this.Id = Guid.NewGuid();
        }

        public User(String name, String password)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Password = password;
        }

        [DataMember]
        public Guid Id { get; set; }
    
        [DataMember]
        public String Name { get; set; }

        [DataMember]
        public String Password { get; set; }
    }
}
