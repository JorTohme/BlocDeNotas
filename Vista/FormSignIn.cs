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
    public partial class FormSignIn : Form
    {
        //
        private MySqlConnection mysql;
        private DataTable dataTable;
        //
        Writer writer;

        String userRealPassword = null;
        String userRealName = null;
        public FormSignIn(MySqlConnection mysql)
        {
            InitializeComponent();
            CenterToScreen();
            this.mysql = mysql;
        }

        private void FormSignIn_Load(object sender, EventArgs e)
        {
            try
            {
                dataTable = MySQLDatabase.FillTable(mysql, "ESCRITOR");
            }
            catch (Exception) { ConnectionError(); }
        }

        #region Utilities
        //-----------------------------------------------------------------//
        //If there's any connection exception the aplication will close
        private void ConnectionError()
        {
            MessageBox.Show("Error de conexión, recargue la aplicación");
            this.Close();
        }
        //Exit button in groupUserAlreadyExist
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //-----------------------------------------------------------------//
        #endregion

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            bool userExists = false;
            foreach (DataRow dataRow in dataTable.Rows) //Checks if the username actually exists in the database
            {
                if (textUserName.Text.TrimEnd(' ') == "ADMIN")
                {
                    labelWrongUserName.Visible = true;
                } 
                else
                {
                    userExists = (textUserName.Text.TrimEnd(' ') == (string)dataRow["nombre"]) ? true : false;
                }

                if (userExists)
                {
                    userRealName = (string)dataRow["nombre"];
                    userRealPassword = (string)dataRow["contrasenia"];
                    break;
                }
            }

            labelWrongUserName.Visible = (userExists) ? false : true; //Alert message

            if (userExists)
            {
                if (textPassword.Text == userRealPassword)
                {
                    labelWrongPassword.Visible = false;

                    dataTable.Clear();
                    dataTable = MySQLDatabase.FillTable(mysql, "NOTAS");

                    ArrayList id_notas = new ArrayList();
                    List<Note> notas = new List<Note>();

                    //Search for all notes writen by this specific writer
                    foreach (DataRow dataRow in dataTable.Rows)
                    {
                        if (dataRow["AUTOR"] != null)
                        {
                            if (userRealName == (string)dataRow["AUTOR"])
                            {
                                id_notas.Add((int)dataRow["ID_NOTA"]);
                            }
                        }
                    }

                    //Getting the notes of the data base
                    dataTable.Clear();
                    dataTable = MySQLDatabase.FillTable(mysql, "NOTAS");
                    var writer = new Writer();
                    writer.Name = userRealName;
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

                    writer = new Writer(userRealName, userRealPassword, notas);
                    var formWriter = new FormNoteWriter(mysql, writer);

                    this.Close();
                    formWriter.Show();

                }
                else 
                { 
                    labelWrongPassword.Visible = true; 
                }
            }
        }
    }
}
