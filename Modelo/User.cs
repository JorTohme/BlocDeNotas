using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocDeNotas.Modelo
{
    public abstract class User
    {
        protected String name;
        protected String password;

        public User(String name, String password)
        {
            this.name = name;
            this.password = password;
        }
        public User()
        {

        }
        public string Password { get => password; set => password = value; }
        public string Name { get => name; set => name = value; }
    }
}
