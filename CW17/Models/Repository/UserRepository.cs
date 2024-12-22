using CW17.Models.DB;
using CW17.Models.Entity;

namespace CW17.Models.Repository
{
	public class UserRepository
	{
		private readonly AppDbContext _context;
        public UserRepository()
        {
            _context = new AppDbContext();
        }
		public User Register(string username, string password)
		{
			User user = new User()
			{
				Username = username,
				Password = password
			};
			_context.Users.Add(user);
			_context.SaveChanges();
			return user;
		}
		public bool Login(string username, string password)
        {
			var user = _context.Users.FirstOrDefault
					(x => x.Username == username && x.Password == password);
			if (user != null)
			{
				return true;
			}
			return false;
        }

    }
}
