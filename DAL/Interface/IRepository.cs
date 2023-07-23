using System.Collections.Generic;

namespace LunaServer.DAL.Interface{
    public interface IRepository<TDomain, TKey>{
        public TDomain Get(TKey Id);
        public ICollection<TDomain> GetAll();
        public TKey Add (TDomain data);
        public void Update(TDomain data);
        public TKey Remove(TKey Id);
    }
}