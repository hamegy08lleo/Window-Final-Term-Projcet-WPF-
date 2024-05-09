using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_.Objects
{
    internal class OwnerDAO : DAO
    {
        public OwnerDAO() { }
        public bool isUniqueUsername(string username)
        {
            var query = from q in dataBase.Owner
                        where q.username == username
                        select q;
            return query.Count() == 0; 
        }
        public bool isUniqueEmail(string email)
        {
            var query = from q in dataBase.Owner
                        where q.email == email
                        select q;
            return query.Count() == 0; 
        }
        public bool isUniquePhoneNumber(string phoneNumber)
        {
            var query = from q in dataBase.Owner
                        where q.phoneNumber == phoneNumber
                        select q;
            return query.Count() == 0; 
        }
        public int? validateLogin(String username, String password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) 
            {
                new WNotifiaction().Notification("Empty username or password");
                return null; 
            }
            var query = from q in dataBase.Owner
                        where q.username == username
                        select q;
            if (query.Count() > 0 )
            {
            }
            else
            {
                new WNotifiaction().Notification("Username does not existed");
                return null;  
            }
            var user = query.FirstOrDefault();
            if (password != user.password)
            {
                new WNotifiaction().Notification("Incorrect Password");
                return null; 
            }
            new WNotifiaction().Notification("Success!");
            return user.ownerID;
        }

        public bool validateRegister(String username, String email, String phoneNumber)
        {
            if (String.IsNullOrEmpty (username))
            {
                new WNotifiaction().Notification("username must be non empty");
                return false; 
            }
            if (!isUniqueEmail(email) || !isUniquePhoneNumber(phoneNumber) || !isUniqueUsername(username))
            {
                new WNotifiaction().Notification("username, email or phone number existed");
                return false; 
            }
            return true; 
        }

        public int register(String username, String password, String email, String phoneNumber)
        {
            Owner owner = new Owner
            {
                username = username,
                password = password,
                email = email,
                phoneNumber = phoneNumber, 
            };
            dataBase.Owner.Add(owner); 
            dataBase.SaveChanges();
            new WNotifiaction().Notification("Success!"); 
            return owner.ownerID; 
        }
        public string getUsername(int id)
        {
            var query = from q in dataBase.Owner
                        where q.ownerID == id
                        select q; 
            return query.FirstOrDefault().username;
        }
    }
}
