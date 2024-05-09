using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Window_Final_Term_Projcet__WPF_.Objects
{
    internal class CustomerDAO : DAO
    {
        public CustomerDAO() { }   
        public int? validateUser(String username, String password)
        {
            if (String.IsNullOrEmpty(username) || String.IsNullOrEmpty(password)) 
            {
                new WNotifiaction().Notification("Empty username or password");
                return null; 
            }
            var query = from q in dataBase.Customer
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
            return user.customerID;
        }
    }
}
