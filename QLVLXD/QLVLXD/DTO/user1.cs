using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVLXD
{
	internal class user1
	{
		private string username;
		private string password;
		private string active;
		private string loai;

		private static user1 currentUser;

		public static user1 CurrentUser
		{
			get => currentUser;
			set => currentUser = value;
		}

		public string Username { get => username; set => username = value; }
		public string Password { get => password; set => password = value; }
		public string Active { get => active; set => active = value; }
		public string Loai { get => loai; set => loai = value; }

		public user1 () { }
		public user1(string username, string password, string active, string loai)
		{
			this.username = username;
			this.password = password;
			this.active = active;
			this.loai = loai;
		}
	}
}