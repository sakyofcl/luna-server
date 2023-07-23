using LunaServer.DAL.Interface;
using LunaServer.DAL.DBContext;
using System.Collections.Generic;

namespace LunaServer.DAL.Repository{

    public abstract class AbstractRepository<TDomain, TKey> : IRepository<TDomain, TKey> where TDomain : class 
    {
        public readonly LunaDBContext context;
        public AbstractRepository(LunaDBContext context){
            this.context = context;
        }
        public abstract TKey Add(TDomain data);
        public abstract void Update(TDomain data);
        public abstract TKey Remove(TKey Id);
        public abstract TDomain Get(TKey id);
        public abstract ICollection<TDomain> GetAll();

    }

}