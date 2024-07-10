using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace study2.DatabaseClass
{
    public class User
    {
        private int         _id;
        private string      _name;
        private string      _password;
        private DateTime    _birthday;
        private bool        _delflag;

        public User(int a1, string a2, string a3, DateTime a4, bool a5)
        {
            _id = a1;
            _name = a2;
            _password = a3;
            _birthday = a4;
            _delflag = a5;
        }

        public int Id { get { return _id; } }
        public string Name { get { return _name;} }
        public string Password { get { return _password; } }
        public DateTime Birthday { get { return _birthday; } }
        public bool delflag { get { return _delflag; } }
       
    }
}
