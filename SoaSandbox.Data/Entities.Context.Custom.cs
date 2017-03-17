using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaSandbox.Data
{
    public partial class Entities : DbContext
    {
        public Entities(String connectionString)
            : base(connectionString)
        {
        }
    }
}
