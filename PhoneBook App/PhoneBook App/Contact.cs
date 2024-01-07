using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBook_App
{
    internal class Contact
    {
        private string _fullname;
        private string _email;
        private int _num;
        private List<int> _numList;

        //
        public Contact(string name, string email, List<int> numList)
        {
            this._fullname = name;
            this._email = email;
            this._numList = numList;
        }
        public string fullname() {  return this._fullname; }
        public string email() { return this._email;}
        public int num() { return this._num; }
        public List<int> numList() {  return this._numList; }


    }
}
