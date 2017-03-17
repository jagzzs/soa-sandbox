using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaSandbox.Data
{
    public class EntitiesAccessor
    {
        public EntitiesAccessor()
            : this("App.ConnectionString")
        {
        }

        public EntitiesAccessor(String connectionStringFilePath)
        {
            this.ConnectionStringFilePath = connectionStringFilePath;
        }
        
        private Entities _instance;

        private String _connectionString;

        public String ConnectionStringFilePath
        {
            set
            {
                this._connectionString = this.GetConnectionString(value);
            }
        }

        public Entities Instance
        {
            get
            {
                this._instance = this._instance ?? new Entities(this._connectionString);
                return this._instance;
            }
        }

        private String GetConnectionString(String path)
        {
            return File.ReadAllText(path).Trim();
        }
    }
}