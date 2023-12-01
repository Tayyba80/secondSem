using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWithInheritance.BL
{
    internal class sign
    {
        private string name;
        private string password;
        private string role;

        public sign(string name, string password, string role)
        {
            this.name = name;
            this.password = password;
            this.role = role;
        }
        public sign(string name, string password)
        {
            this.name = name;
            this.password = password;
        }

        public string getRole()
        {
            return role;
        }
        public string getName()
        {
            return name;
        }
        public string getPassword()
        {
            return password;
        }
        public void setName(string name)
        {
            this.name = name;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }

        public void setRole(string role)
        {
            this.role = role;
        }
    }
}

