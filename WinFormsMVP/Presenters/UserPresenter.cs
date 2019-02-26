using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsMVP.Models;
using WinFormsMVP.Views;

namespace WinFormsMVP.Presenters
{
    public class UserPresenter
    {
        private readonly IUserView _view;
        private readonly IUserRepository _userRepository;

        public UserPresenter(IUserView view) : this(view, new UserRepository())
        {
        }

        public UserPresenter(IUserView view, IUserRepository userRepository)
        {
            _view = view;
            _userRepository = userRepository;
        }

        public void OnUserSearched()
        {
            if (string.IsNullOrEmpty(_view.SearchUser))
            {
                return;
            }

            User user = _userRepository.GetByName(_view.SearchUser);

            if (user == null)
            {
                return;
            }

            _view.UserName = user.name;
            _view.UserAddress = user.address;
        }
    }
}
