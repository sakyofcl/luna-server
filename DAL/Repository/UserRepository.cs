using System.Collections.Generic;
using LunaServer.Models;
using LunaServer.DAL.DBContext;

namespace LunaServer.DAL.Repository
{
    public class UserRepository : AbstractRepository<UserModel, int>
    {
        public UserRepository(LunaDBContext context):base(context){}

        public override int Add(UserModel data)
        {
            
            throw new System.NotImplementedException();
        }

        public override UserModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public override ICollection<UserModel> GetAll()
        {
            var x = context.Users;
            return null;
        }

        public override int Remove(int Id)
        {
            throw new System.NotImplementedException();
        }

        public override void Update(UserModel data)
        {
            throw new System.NotImplementedException();
        }
    }
}
