using BlocDeNotas.Vista;
using BlocDeNotas.Modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using BlocDeNotas.Controlador;

namespace BlocDeNotas
{
    public partial class Form1 : Form
    {
        //Connection to DataBase
        private MySqlConnection mysql;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mysql = MySQLDatabase.CreateConnection();
            try
            {
                mysql.Open();
                labelComprobacionConexion.ForeColor = Color.Green;
                labelComprobacionConexion.Text = "Conectado";
                mysql.Close();
            }
            catch (Exception)
            {
                labelComprobacionConexion.ForeColor = Color.Red;
                labelComprobacionConexion.Text = "Sin conexión\n" +
                    "Reinicie la aplicación";
                Deny_Aplication();
            }
        }
        private void Deny_Aplication()
        {
            buttonAdministrador.Enabled = false;
            buttonSignUp.Enabled = false;
            buttonSignIn.Enabled = false;
        }
        private void buttonAdministrador_Click(object sender, EventArgs e)
        {
            var frm = new FormLoginAdmin(mysql); 
            frm.ShowDialog();
        }
        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            var frm = new FormSignUp(mysql);
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            var frm = new FormSignIn(mysql);
            frm.FormClosing += delegate { this.Show(); };
            frm.Show();
            this.Hide();
        }
    }
}

