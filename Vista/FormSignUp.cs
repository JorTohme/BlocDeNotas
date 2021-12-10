using BlocDeNotas.Controlador;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BlocDeNotas.Vista
{
    public partial class FormSignUp : Form
    {

        //
        private MySqlConnection mysql;
        private DataTable dataTable;

        //
        private bool userTaken = false;

        private bool user = false;
        private bool password = false;

        public FormSignUp(MySqlConnection mysql)
        {
            InitializeComponent();
            CenterToScreen();
            this.mysql = mysql;
        }

        private void FormSignUp_Load(object sender, EventArgs e)
        {
            try
            {
                dataTable = MySQLDatabase.FillTable(mysql, "ESCRITOR");
            }
            catch (Exception)
            {
                ConnectionError();
            }
        }
        
        #region Utilities
        //-----------------------------------------------------------------//
        //If there's any connection error the aplication will close
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

        #region USER AND PASSWORD VALIDATION
        //USER
        private void textName_TextChanged(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textName.Text)) //Checks if the field is empty
            {
                user = false;
                CreateUser();
            }
            else
            {
                foreach (DataRow dataRow in dataTable.Rows) //Busca si ese nombre de usuario ya está en uso
                {
                    if (textName.Text.TrimEnd(' ') == (string)dataRow["nombre"]) //El método TrimEnd quita los espacios al final
                    {
                        userTaken = true;
                        break;
                    } 
                    else
                    {
                        userTaken = false;
                    }
                }

                if (userTaken)
                {
                    labelTextName.Visible = true; //Shows "User alreay exist" message
                    groupUserAlreadyExists.Visible = true;
                    user = false;
                    CreateUser();
                }
                else
                {
                    labelTextName.Visible = false;
                    groupUserAlreadyExists.Visible = false;
                    user = true;
                    CreateUser();
                }
            }
        }
        //PASSWORD
        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text.Length < 5)
            {
                labelShortPassword.Visible = true;
                buttonCreateUser.Enabled = false;
                password = false;
                CreateUser();
            }
            else
            {
                labelShortPassword.Visible = false;
                buttonCreateUser.Enabled = true;
                CreateUser();
            }
        }
        private void textRePassword_TextChanged(object sender, EventArgs e)
        {
            if (textPassword.Text.Equals(textRePassword.Text))
            {
                labelRePassword.Visible = false;
                password = true;
                CreateUser();
            }
            else
            {
                labelRePassword.Visible = true;
                password = false;
                CreateUser();
            }
        }
        private void CreateUser()
        {
            buttonCreateUser.Enabled = (user && password) ? true : false;
        }
        #endregion


        //-----------------------------------------------------------------//
        //Create User
        private void buttonCreateUser_Click(object sender, EventArgs e)
        {
            string userUserName = textName.Text.TrimEnd(' ');
            string userPassword = textRePassword.Text;
            try
            {
                MySQLDatabase.CommandInsert(mysql, $"INSERT INTO escritor(nombre, contrasenia) VALUES('{userUserName}', '{userPassword}'); ");
                MessageBox.Show("¡USUARIO CREADO CORRECTAMENTE!");
                this.Close();
            }
            catch (Exception) { ConnectionError(); }
        }
        //-----------------------------------------------------------------//
    }
}
