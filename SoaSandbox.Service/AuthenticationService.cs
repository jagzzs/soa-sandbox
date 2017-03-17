using SoaSandbox.Contract;
using System;
using SoaSandbox.Contract.DataContracts;
using SoaSandbox.Data;
using System.Linq;

namespace SoaSandbox.Service
{
    public class AuthenticationService : ServiceBase<auth_user>, IAuthenticationService
    {
        public bool SignIn(User user)
        {
            var query = this.EntitySet
                .Where(x => x.name == user.Name && x.password == user.Password)
                .Count();

            return query == 1;
        }

        public bool SignUp(User user)
        {
            var entity = this.EntitySet.Create();
            entity.name = user.Name;
            entity.password = user.Password;

            this.EntitySet.Add(entity);

            var recordsChanged = this.SaveChanges();

            return recordsChanged == 1;
        }
    }
}
