using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_App
{
    internal class User
    {
        private string _fullname;
        private string _email;
        private int _num;
        private List<Contact> _contacts;


        public User(string name, string email, int num)
        {
            this._fullname = name;
            this._email = email;
            this._num = num;
            this._contacts = new List<Contact>();
        }

        //add contact method
        public void addContact()
        {
            List<int> _numList = new List<int>();
            Console.WriteLine("contact name:");
            string _name =Console.ReadLine();
            Console.WriteLine("contact email:");
            string _email = Console.ReadLine();
            while (true) {
                Console.WriteLine("contact phone number(s) (enter 0 if finished):");
                string input = Console.ReadLine();
                if (input == "0"){break;}
                else
                {
                    _numList.Add(Int32.Parse(input));
                }
            }
            
           
            Contact newcontact =  new Contact(_name, _email, _numList);
            this._contacts.Add(newcontact);
        }

        //remove contact from user
        public void removeContact(String fname)
        {
            for (int i = 0; i < this._contacts.Count; i++)
            {
                if (this._contacts[i].fullname() == fname ) {
                    this._contacts.RemoveAt(i);
                    break;
                }
            }
        }

        //print contact details
        private string contactToString(Contact contact)
        {
            string _list = string.Empty;
            foreach (int e in contact.numList())
            {
                _list += e;
                _list += ", ";
            }
            return "contact name : " + contact.fullname() + ", email : " + contact.email() + " and phone number(s): " + _list;
        }
        

        //list all contacts for a user
        public void listContacts ()
        {
            foreach (Contact contact in this._contacts)
            {
                Console.WriteLine(this.contactToString(contact));
            }
        }


        //search for a contact
        public void searchfor(string name)
        {
            foreach(Contact contact in this._contacts)
            {
                if (contact.fullname() == name)
                {
                    Console.WriteLine(contactToString(contact) );
                    break;
                }
                else { Console.WriteLine("contact not found"); }
            }
        }



    }
}
