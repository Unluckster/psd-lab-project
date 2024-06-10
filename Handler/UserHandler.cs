using PSDProject.Model;
using PSDProject.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PSDProject.Handler
{
    public class UserHandler
    {
        public static void CreateUser(string name, string gender, string dob, string phone, string address, string password, string role)
        {
            UserRepository.CreateUser(name, gender, dob, phone, address, password, role);
        }

        public static string Login(string username, string password)
        {
            MsUser user = UserRepository.FindByName(username);
            if (user == null)
            {
                return "User does not exist. Please register and try again";
            }
            else if (user.UserPassword != password) 
            {
                return "Wrong password";
            }
            else
            {
                return user.UserRole;
            }
        }

        public static void UpddateUser(string name, string gender, string dob, string phone, string address, string password, string role)
        {
            UserRepository.UpdateUser(name, gender, dob, phone, address, password, role);
        }

        public static void DeleteUser(string username)
        {
            UserRepository.DeleteUser(username);

        }

        public static MsUser GetUser(string username)
        {
            return UserRepository.FindByName(username);
        }

        public static List<MsUser> GetUsers() 
        {
            return UserRepository.GetUsers();
        }

    } 
}