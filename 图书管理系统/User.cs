using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 图书管理系统
{
    class User
    {
        private string name;
        public string  Name { get { return name; } }

        public User(string name)
        {
            this.name = name;
        }
    }
}
