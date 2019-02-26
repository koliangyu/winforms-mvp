using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP.Models
{
    public interface IUserRepository
    {
        User GetByName(string userName);
    }
}
