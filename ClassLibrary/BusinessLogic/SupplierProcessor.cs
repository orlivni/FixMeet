using ClassLibrary.DataAccess;
using ClassLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.BusinessLogic
{
    public static class SupplierProcessor
    {
        public  static int CreateSupplier(string firstName, string lastName, 
            string email, string userName, int radius/*, Address address, Category category*/)
        {
            Supplier data = new Supplier
            {
                FirstName = firstName,
                LastName = lastName,
                Email = email,
                UserName = userName,
                Radius = radius/*,
                Address = address,
                Category= category*/
            };

            string sql = @"insert into dbo.Supplier (FirstName, LastName, Email, UserName, Radius)
                           values (@FirstName, @LastName, @Email, @UserName, @Radius);";  //need to add address and category
            return SqlDataAccess.SaveData(sql, data);
        }

        public static List<Supplier> LoadSuppliers()
        {
            string sql = @"select FirstName, LastName, Email, UserName, Radius
                           from dbo.Supplier";

            return SqlDataAccess.LoadData<Supplier>(sql);
        }
    }
}
