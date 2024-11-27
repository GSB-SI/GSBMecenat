﻿using ProGestionGSB.DAL;
using System.Collections.Generic;

namespace ProGestionGSB.BLL
{
    public class UserManager
    {
        #region Singleton
        private static UserManager instance;
        public static UserManager GetInstance()
        {
            if (instance == null)
            {
                instance = new UserManager();
            }
            return instance;
        }
        #endregion Singleton

        public List<User> GetUsers()
        {
            return UserDAO.GetInstance().GetUsers();
        }

        public sp_users_getById_Result GetUserById(int id)
        {
            return UserDAO.GetInstance().GetUserById(id);
        }

        public void AddUser(string login, string password, int role_id)
        {
            string password_hash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
            UserDAO.GetInstance().AddUser(login, password_hash, role_id);
        }

        public void UpdateUser(int id, string login, string password, int role_id)
        {
            string password_hash = BCrypt.Net.BCrypt.EnhancedHashPassword(password, 13);
            UserDAO.GetInstance().UpdateUser(id, login, password_hash, role_id);
        }

        public void DeleteUser(int id)
        {
            UserDAO.GetInstance().DeleteUser(id);
        }

        public User GetInfosUtilisateur(string login, string password)
        {
            var result = UserDAO.GetInstance().GetUserByLogin(login);
            User user = new User
            {
                id = result.id,
                login = result.login,
                password = result.password,
                role_id = result.role_id,
            };
            if (BCrypt.Net.BCrypt.EnhancedVerify(password, user.password) == false)
            {
                user = null;
            }
            return user;
        }
    }
}