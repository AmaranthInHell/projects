using IssueTrackingSystem2B.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IssueTrackingSystem2B.Repositories;
namespace IssueTrackingSystem2B.Services
{
    public class AuthenticationService
    {
        public static User LoggedUser { get; set; }

        public static User AuthenticateUser(string username, string password)
        {
            UsersRepository userRepository = new UsersRepository();
            LoggedUser = userRepository.GetByUsernameAndPassword(username, password);
            return LoggedUser;
        }
    }
}
