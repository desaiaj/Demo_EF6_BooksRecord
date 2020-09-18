using FinalEFAjayDesai.Controller;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalEFAjayDesai
{
    class Program
    {
        static void Main(string[] args)
        {
            BooksController ctrlBooks = new BooksController();
            Console.WriteLine("\n\t Final Exam - Ajay Desai");
            do
            {
                try
                {
                    string choice = DisplayMenu();

                    switch (choice)
                    {
                        case "1":
                            ctrlBooks.GetAllAuthors();
                            break;

                        case "2":
                            Console.Write("\n Enter First Name: ");
                            string firstName = Console.ReadLine();

                            Console.Write("\n Enter Last Name: ");
                            string lastName = Console.ReadLine();

                            Console.Write("\n Enter Phone: ");
                            string phone = Console.ReadLine();

                            Console.Write("\n Enter Address: ");
                            string address = Console.ReadLine();

                            Console.Write("\n Enter City: ");
                            string city = Console.ReadLine();

                            Console.Write("\n Enter State: ");
                            string state = Console.ReadLine();

                            ctrlBooks.InsertAuthors(firstName, lastName, phone, address, city, state);
                            break;

                        case "3":
                            Console.Write("\n Enter AuthorID to update: ");
                            int AuthorID = int.Parse(Console.ReadLine());
                            if (!ctrlBooks.FindAuthorByID(AuthorID))//if data not found throw error
                            {
                                Console.WriteLine(" #### No data found for entered AuthorID, Please try again! ####");
                                break;
                            }
                            Console.Write("\n Enter New First Name: ");
                            string NewfirstName = Console.ReadLine();

                            Console.Write("\n Enter New Last Name: ");
                            string NewlastName = Console.ReadLine();

                            Console.Write("\n Enter New Phone: ");
                            string Newphone = Console.ReadLine();

                            Console.Write("\n Enter New Address: ");
                            string Newaddress = Console.ReadLine();

                            Console.Write("\n Enter New City: ");
                            string Newcity = Console.ReadLine();

                            Console.Write("\n Enter New State: ");
                            string Newstate = Console.ReadLine();

                            ctrlBooks.UpdateAuthors(AuthorID, NewfirstName, NewlastName, Newphone, Newaddress, Newcity, Newstate);
                            break;

                        case "4": // Exit
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine(" #### Invalid Choice or Wrong Input! Please try again ####");
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine(" Something went wrong! Please try again");
                }
            } while (true);
        }

        static string DisplayMenu()
        {
            Console.WriteLine("\n+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-+-\n");
            Console.WriteLine("\t 1 - View all authors");
            Console.WriteLine("\t 2 - Add author");
            Console.WriteLine("\t 3 - Update author");
            Console.WriteLine("\t 4 - Exit");
            Console.Write("\n Enter your choice: ");
            string ch = Console.ReadLine();
            return ch;
        }
    }
}