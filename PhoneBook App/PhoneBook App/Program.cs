using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PhoneBook_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User user1 = new User("Mohamed Amine Dhibi", "dhibi.amine@gmail.com",93790187);
            user1.addContact();
            user1.listContacts();
            Console.ReadKey();
        }
    }
}
