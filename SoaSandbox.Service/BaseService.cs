using SoaSandbox.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoaSandbox.Service
{
    public abstract class ServiceBase<EntityType>
        where EntityType : class
    {
        private Entities _model;

        public ServiceBase()
        {
            this._model = this.CreateEntitiesInstance();
            this.EntitySet = this._model.Set<EntityType>();
        }

        protected DbSet<EntityType> EntitySet { get; set; }

        protected virtual Entities CreateEntitiesInstance()
        {
            var entitiesAccessor = new EntitiesAccessor();
            return entitiesAccessor.Instance;
        }

        protected int SaveChanges()
        {
            var recordChanges = this._model.SaveChanges();
            return recordChanges;
        }
    }
}
