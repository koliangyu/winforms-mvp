using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsMVP.Views
{
    public interface IUserView
    {
        string SearchUser { get; }
        string UserName { set; }
        string UserAddress { set; }
    }
}
