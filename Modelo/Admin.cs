using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocDeNotas.Modelo
{
    public class Admin : User
    {
        private List<Note> everyNote = new List<Note>();

        public Admin(string name, string password)
            : base(name, password)
        {

        }

        public void SetNotes(List<Note> value)
        {
            everyNote = value;
        }

        public List<Note> GetNotes()
        {
            return everyNote;
        }
    }
}
