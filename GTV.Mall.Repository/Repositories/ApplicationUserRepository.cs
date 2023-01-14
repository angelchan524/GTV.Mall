using GTV.Mall.Models.DataModel;
using GTV.Mall.Models.ViewModel.Identity;
using GTV.Mall.Repository.Data;
using GTV.Mall.Repository.Repositories.Interface;
using Microsoft.EntityFrameworkCore.Update.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTV.Mall.Repository.Repositories
{
    public class ApplicationUserRepository : Repository<Member, Guid>
    {
        public ApplicationUserRepository(ApplicationDbContext context) : base(context)
        {
        }

        public ApplicationUser Get(Guid id)
        {
            ApplicationUser user;
            Member member = dbSet.Find(id);
            if (member == null) return null;
            
            Type t = typeof(Member);
            var properties = t.GetProperties().Where(prop => prop.CanRead && prop.CanWrite);

            user = new ApplicationUser();
            foreach (var prop in properties)
            {
                var value = prop.GetValue(member, null);
                if (value != null)
                    prop.SetValue(user, value, null);
            }
            return user;
        }


        public void Update(ApplicationUser user)
        {
            Member member = new Member();
            Update(ToDataModel(user));
        }

        public Member ToDataModel(ApplicationUser user)
        {
            return new Member() { };
        }
    }
}
