using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocDeNotas.Modelo
{
    public class Note
    {
        private int idNote;
        private String title;
        private string text;
        private Writer author;
        private string lastModification;
        //private Escritor 

        public Note(string title, string text, int idNote, Writer author, string lastModification)
        {
            this.title = title;
            this.text = text;
            this.idNote = idNote;
            this.author = author;
            this.lastModification = lastModification;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetText()
        {
            return text;
        }

        public int GetId_note()
        {
            return idNote;
        }

        public Writer Author()
        {
            return author;
        }

        public string GetLastModification()
        {
            return lastModification;
        }
    }
}
