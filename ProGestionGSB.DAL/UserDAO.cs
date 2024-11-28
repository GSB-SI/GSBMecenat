using System;
using System.Collections.Generic;
using System.Linq;

namespace ProGestionGSB.DAL
{
    public class UserDAO
    {
        #region Singleton
        private static UserDAO instance;

        public static UserDAO GetInstance()
        {
            if (instance == null)
            {
                instance = new UserDAO();
            }
            return instance;
        }
        #endregion

        public List<User> GetUsers()
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    var result = ctx.Users.Include("Role").ToList();
                    return result ?? throw new Exception("Users not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the list of users.", ex);
            }
        }

        public sp_users_getById_Result GetUserById(int id)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    var result = ctx.sp_users_getById(id).FirstOrDefault();
                    return result ?? throw new Exception("User not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the user.", ex);
            }
        }


        public void AddUser(string login, string password, int role_id)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_users_add(login, password, role_id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while adding the user.", ex);
            }
        }

        public void UpdateUser(int id, string login, int role_id)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_users_update(id, login, role_id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while updating the user.", ex);
            }
        }

        public void DeleteUser(int id)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_users_delete(id);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the user.", ex);

            }
        }

        public User GetUserByLogin(string login)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    var result = ctx.Users.Include("Role")
                        .Where(u => u.login == login)
                        .SingleOrDefault();
                    return result ?? throw new Exception("User not found.");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while retrieving the user.", ex);
            }
        }

        public void resetPassword(int id, string password)
        {
            try
            {
                using (GSBMecenatEntities ctx = new GSBMecenatEntities())
                {
                    ctx.sp_users_resetPassword(id, password);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while deleting the user.", ex);

            }
        }
    }
}
