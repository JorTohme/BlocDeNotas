using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocDeNotas.Modelo
{
    public class Writer : User
    {

        private List<Note> notes = new List<Note>();

        public Writer(string name, string password, List<Note> notes) 
            : base(name, password)
        {
            this.notes = notes;
        }

        public Writer()
        {

        }



        public void SetNotes(List<Note> notes)
        {
            this.notes = notes;
        }

        public List<Note> GetNotes()
        {
            return notes;
        }

    }
}
