using BlocDeNotas.Controlador;
using BlocDeNotas.Modelo;
using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas.Vista
{
    public partial class FormNoteWriter : Form
    {
        //Database
        private MySqlConnection mysql;
        private DataTable dataTable = new DataTable();
        //Local variables
        private Writer writer;
        private Admin admin;
        private int idSelectedNote;
        private bool isAdmin = false;

        public FormNoteWriter(MySqlConnection mysql, User user)
        {
            InitializeComponent();
            CenterToScreen();
            this.mysql = mysql;
            if (user is Writer)
            {
                this.writer = (Writer)user;
            }
            else if (user is Admin)
            {
                this.admin = (Admin)user;
                isAdmin = true;
            }

        }

        #region Events
        private void FormNoteWriter_Load(object sender, EventArgs e)
        {
            //Save button is not visible if the user is admin
            buttonSave.Visible = (isAdmin) ? false : true;
            //Also admin cannot modify notes
            richTextBoxNota.Enabled = (isAdmin) ? false : true;
            pictureSaveImage.Visible = (isAdmin) ? false : true;
            buttonNewNote.Enabled = (isAdmin) ? false : true;
            textNewTitle.Enabled = (isAdmin) ? false : true;

            var notes = (isAdmin) ? admin.GetNotes() : writer.GetNotes();
            //Update the NoteList
            foreach (Note i in notes) { listBoxNotes.Items.Add(i.GetTitle()); }
            try
            {
                dataTable = MySQLDatabase.FillTable(mysql, "NOTAS");
            }
            catch (Exception) { ConnectionError(); }
            EnableTextBox();
        }
        private void listBoxNotes_SelectedIndexChanged(object sender, EventArgs e)
        {
            EnableTextBox();
            string title = (string)listBoxNotes.SelectedItem;
            var notes = (isAdmin) ? admin.GetNotes() : writer.GetNotes();
            foreach (Note i in notes)
            {
                if (String.Equals(title, i.GetTitle()))
                {
                    richTextBoxNota.Text = i.GetText();
                    idSelectedNote = i.GetId_note();
                    labelLastChange.Text = "Ult. Mod: " + i.GetLastModification();
                    break;
                }
            }
            UpdateTitle();
        }
        private void buttonSave_Click(object sender, EventArgs e)
        {
            string date = DateTime.Now.ToString();
            MySQLDatabase.CommandInsert(mysql, $"UPDATE `blocdenotas`.`notas` SET `TEXTO` = '{richTextBoxNota.Text}' WHERE `ID_NOTA` = '{idSelectedNote}';");
            MySQLDatabase.CommandInsert(mysql, $"UPDATE `blocdenotas`.`notas` SET `DATE` = '{date}' WHERE `ID_NOTA` = '{idSelectedNote}';");
            LoadNewNotes();
        }
        private void buttonNewNote_Click(object sender, EventArgs e)
        {
            //Saving the new note in notes table from the database
            dataTable.Clear();
            dataTable = MySQLDatabase.FillTable(mysql, "NOTAS");
            int idLastNote = 0;
            foreach (DataRow dataRow in dataTable.Rows)
            {
                idLastNote = (idLastNote < (int)dataRow["ID_NOTA"]) ? idLastNote = (int)dataRow["ID_NOTA"] : idLastNote += 0;
            }
            idLastNote += 1;
            string title = " • " + textNewTitle.Text;
            string date = DateTime.Now.ToString();
            MySQLDatabase.CommandInsert(mysql, $"INSERT INTO notas(id_nota, titulo, texto, autor, date) VALUES('{idLastNote}','{title}', '{" Nueva nota "}', '{writer.Name}', '{date}');");
            LoadNewNotes();

            textNewTitle.Text = "Añadir Título";
            textNewTitle.TextAlign = HorizontalAlignment.Center;

        }
        private void buttonDeleteNote_Click(object sender, EventArgs e)
        {
            MySQLDatabase.CommandInsert(mysql, $"DELETE FROM NOTAS WHERE id_nota='{idSelectedNote}';");
            LoadNewNotes();
        }
        #endregion

        #region Functions
        private void ConnectionError()
        {
            MessageBox.Show("Error de conexión, recargue la aplicación");
            this.Close();
        }
        private void EnableTextBox()
        {
            if (!isAdmin)
            {
                richTextBoxNota.Enabled = (listBoxNotes.SelectedIndex == -1) ? false : true;
            }
        }
        private void UpdateListBox()
        {
            var notes = (isAdmin) ? admin.GetNotes() : writer.GetNotes();
            listBoxNotes.Items.Clear();
            foreach (Note i in notes) 
            { 
                listBoxNotes.Items.Add(i.GetTitle());
                labelLastChange.Text = "Ult. Mod: " + i.GetLastModification();
            }
        }
        private void LoadNewNotes()
        {
            dataTable.Clear();
            dataTable = MySQLDatabase.FillTable(mysql, "NOTAS");

            ArrayList id_notas = new ArrayList();
            List<Note> notas = new List<Note>();
            if (isAdmin)
            {
                DataTable dataTableNotes = MySQLDatabase.FillTable(mysql, "NOTAS");
                foreach (DataRow dataRow in dataTableNotes.Rows)
                {
                    Writer author = new Writer();
                    author.Name = (string)dataRow["AUTOR"];
                    notas.Add(new Note((string)dataRow["TITULO"], (string)dataRow["TEXTO"], (int)dataRow["ID_NOTA"], author, (string)dataRow["DATE"]));
                }
                admin.SetNotes(notas);
            }
            else if (!isAdmin)
            {
                //Search for all notes writen by this specific writer
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    if (dataRow["AUTOR"] != null)
                    {
                        if (writer.Name == (string)dataRow["AUTOR"]) { id_notas.Add((int)dataRow["id_nota"]); }
                    }
                }
                //Getting the notes in the data base
                dataTable.Clear();
                dataTable = MySQLDatabase.FillTable(mysql, "NOTAS");
                //Loading the notes
                foreach (DataRow dataRow in dataTable.Rows)
                {
                    foreach (int i in id_notas)
                    {
                        if (i == (int)dataRow["id_nota"])
                        {
                            notas.Add(new Note((string)dataRow["titulo"], (string)dataRow["texto"], i, writer, (string)dataRow["DATE"]));
                        }
                    }
                }
                writer.SetNotes(notas);
            }
            UpdateListBox();
        }
        private void UpdateTitle()
        {
            labelTitle.Text = (listBoxNotes.SelectedIndex != -1) ? (string)listBoxNotes.SelectedItem : null;
            labelTitle.Visible = (labelTitle.Text == null) ? false : true;

            if (isAdmin)
            {
                Writer author = null;
                var notes = admin.GetNotes();
                foreach (Note i in notes)
                {
                    if (i.GetTitle().Equals(listBoxNotes.SelectedItem))
                    {
                        author = i.Author();
                        break;
                    }
                }
                labelAuthor.Text = (listBoxNotes.SelectedIndex != -1) ? "Autor: " + author.Name : null;
            }
            else
            {
                labelAuthor.Text = (listBoxNotes.SelectedIndex != -1) ? "Autor: " + (string)writer.Name : null;
                labelAuthor.Visible = (labelTitle.Text == null) ? false : true;
            }
        }
        #endregion

        #region Visual validations
        //------------------------------------------------------------------------//
        private void textNewTitle_TextChanged(object sender, EventArgs e)
        {
            buttonNewNote.Enabled = (String.IsNullOrEmpty(textNewTitle.Text) || textNewTitle.Text == "Añadir Título") ? false : true;
            textNewTitle.TextAlign = HorizontalAlignment.Left;
        }
        private void textNewTitle_Click(object sender, EventArgs e)
        {
            textNewTitle.Text = null;
        }
        private void pictureSaveImage_Click(object sender, EventArgs e)
        {
            buttonSave_Click(sender, e);
        }
        //------------------------------------------------------------------------//
        #endregion
    }
}
