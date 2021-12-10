using BlocDeNotas.Controlador;
using BlocDeNotas.Modelo;
using MySql.Data.MySqlClient;
using System;
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
    public partial class FormLoginAdmin : Form
    {
        private Admin admin;
        private DataTable dataTable = new DataTable();
        private DataTable dataTableNotes = new DataTable();
        private MySqlConnection mysql;

        private string adminPassword;
        private List<Note> notes = new List<Note>();
        public FormLoginAdmin(MySqlConnection mysql)
        {
            InitializeComponent();
            CenterToScreen();
            this.mysql = mysql;
        }

        private void FormLoginAdmin_Load(object sender, EventArgs e)
        {
            dataTable = MySQLDatabase.FillTable(mysql, "ESCRITOR");
            foreach (DataRow dataRow in dataTable.Rows)
            {
                if ("ADMIN".Equals((string)dataRow["NOMBRE"]))
                {
                    adminPassword = (string)dataRow["CONTRASENIA"];
                    break;
                }
            }
            admin = new Admin("ADMIN", adminPassword);
            adminPassword = null;
            dataTable.Clear();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (textContraseniaAdmin.Text.Equals(admin.Password))
            {
                dataTableNotes = MySQLDatabase.FillTable(mysql, "NOTAS");
                
                foreach (DataRow dataRow in dataTableNotes.Rows)
                {
                    Writer author = new Writer();
                    author.Name = (string)dataRow["AUTOR"];
                    notes.Add(new Note((string)dataRow["TITULO"], (string)dataRow["TEXTO"], (int)dataRow["ID_NOTA"], author, (string)dataRow["DATE"]));
                }
                admin.SetNotes(notes);
                var formWriter = new FormNoteWriter(mysql, admin);
                this.Close();
                formWriter.Show();
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
