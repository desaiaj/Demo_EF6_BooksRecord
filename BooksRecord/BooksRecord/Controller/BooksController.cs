using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFAjayDesai.Controller
{
    class BooksController
    {
        private BooksDBEntities BookContext = new BooksDBEntities();
        public void GetAllAuthors()
        {
            var authors = from auth in BookContext.Authors
                          select auth;
            Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");
            Console.WriteLine("AuthorID FirstName\tLastName\t Phone\t\tAddress\t\t\tCity\t\tState\n");
            foreach (var row in authors)
                Console.WriteLine($"{row.AuthorID,8} {row.FirstName,-14} {row.LastName,-16} {row.Phone,-14} {row.Address,-23} {row.City,-15} {row.State}");
        }
        public void InsertAuthors(string firstName, string lastName, string phone, string address, string city, string state)
        {
            try
            {
                BookContext.Authors.Add(new Author(firstName, lastName, phone, address, city, state));
                BookContext.SaveChanges();
                Console.WriteLine(" Inserted Successfully!!");
            }
            catch
            {
                Console.WriteLine(" Failed to insert!! Try again!");
            }
        }

        public bool FindAuthorByID(int authorID)
        {
            var auth = BookContext.Authors.Find(authorID);
            return auth != null;
        }


        public void UpdateAuthors(int authorID, string newfirstName, string newlastName, string newphone, string newaddress, string newcity, string newstate)
        {
            try
            {
                var auth = BookContext.Authors.Find(authorID);

                auth.FirstName = newfirstName;
                auth.LastName = newlastName;
                auth.Phone = newphone;
                auth.Address = newaddress;
                auth.City = newcity;
                auth.State = newstate;
                BookContext.SaveChanges();
                Console.WriteLine(" Updated Successfully!!");
            }
            catch
            {
                Console.WriteLine(" Failed to Update!! Try again!");
            }
        }
    }
}
