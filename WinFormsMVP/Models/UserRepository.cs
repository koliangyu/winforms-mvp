using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP.Models
{
    public class UserRepository : IUserRepository
    {
        public User GetByName(string userName)
        {
            if (userName == "K")
            {
                User user = new User();

                user.name = "K";
                user.address = "台中";
                return user;
            }
            return null;
        }
    }
}
