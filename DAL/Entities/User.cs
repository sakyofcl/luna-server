using System;

namespace LunaServer.DAL.Entities
{
    public class User
    {
        public int userId { get; set;}
        public string UserName { get; set;}
        public string Password { get; set;}
        public int? Status { get; set;}
        public int? ReferenceType { get; set;}
        public int? ReferenceId { get; set;}
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public string DeletedBy { get; set; }
        public DateTimeOffset? CreatedOn { get; set; }
        public DateTimeOffset? ModifiedOn { get; set; }
        public DateTimeOffset? DeletedOn { get; set; }
    }
}