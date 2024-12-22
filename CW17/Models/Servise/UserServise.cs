using CW17.Models.Entity;
using CW17.Models.Repository;

namespace CW17.Models.Servise
{
	public class UserServise
	{
		private readonly UserRepository _userRepository;
        public UserServise()
        {
            _userRepository = new UserRepository();
        }
        public User Register(string username, string password)
        {
            return _userRepository.Register(username, password);
        }
        public bool Login(string username, string password) 
        {
            return _userRepository.Login(username, password);
        }
    }
}
