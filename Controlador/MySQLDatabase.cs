using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocDeNotas.Controlador
{
    public static class MySQLDatabase
    {

        public static MySqlConnection CreateConnection(string ip, string database, string uID, string pwd)
        {
            MySqlConnection mysql = new MySqlConnection($"SERVER={ip}; DATABASE={database}; UID={uID}; PASSWORD={pwd}"); 
            return mysql;
        }

        public static DataTable FillTable(MySqlConnection mysql, string table)
        {
            MySqlDataAdapter mySqlDataAdapter;
            DataTable dataTable = new DataTable();
            mysql.Open();
            MySqlCommand mySqlCommand = new MySqlCommand($"SELECT * FROM {table}", mysql);
            mySqlDataAdapter = new MySqlDataAdapter();
            mySqlDataAdapter.SelectCommand = mySqlCommand;
            mySqlDataAdapter.Fill(dataTable);
            mysql.Close();
            return dataTable;
        }

        public static void CommandInsert(MySqlConnection mysql, string command)
        {
            MySqlCommand mySqlCommandInsert;
            mysql.Open();
            mySqlCommandInsert = new MySqlCommand(command, mysql);
            mySqlCommandInsert.ExecuteNonQuery();
            mysql.Close();
        }

    }
}
