using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace L01_v19
{
    class User
    {
        string name, password;
        string dateOfRegister;
        int age;

        public User(string name_, string password_, int age_, string registerDate)
        {
            name = name_;
            password = password_;
            age = age_;
            dateOfRegister = registerDate;
        }

        public override string ToString()
        {
            return $"{name} {age} {password} {dateOfRegister}";
        }
        //public string Name => name;
        //public string Password => password;
        //public int ag
    }
}
