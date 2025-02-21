﻿using PSDProject.Model;
using PSDProject.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace PSDProject.Repository
{
    public class UserRepository
    {
        public static RAisoDBEntities db = DatabaseSingleton.getInstance();
       
        public static void CreateUser(string name, string gender, string dob, string phone, string address, string password, string role)
        {
            MsUser newUser = UserFactory.CreateUser(name, gender, dob, phone, address, password, role);
            db.MsUsers.Add(newUser);
            db.SaveChanges();
        }

        public static MsUser FindByName(string name)
        {
            MsUser user = db.MsUsers.Where(x => x.UserName == name).ToList().FirstOrDefault();
            return user;
        }

        public static MsUser FindByID(int id)
        {
            MsUser user = db.MsUsers.Where(x => x.UserID == id).ToList().FirstOrDefault();
            return user;
        }

        public static void UpdateUser(string name, string gender, string dob, string phone, string address, string password, string role)
        {
            MsUser user = FindByName(name);
            user.UserName = name;
            user.UserGender = gender;
            user.UserDOB = DateTime.Parse(dob);
            user.UserPhone = phone;
            user.UserAddress = address;
            user.UserPassword = password;
            db.SaveChanges();
        }

        public static void DeleteUser(string name)
        {
            db.MsUsers.Remove(FindByName(name));
            db.SaveChanges();
        }

        public static List<MsUser> GetUsers() 
        {
            return db.MsUsers.ToList();
        }
    }
}