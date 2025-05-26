using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace WinFormsApp1
{
    class DbConnection
    {
        public static DataTable select(string sql)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "cfif31.ru";
            builder.Port = 3306;
            builder.Database = "ISPr24-38_SolominaAV_AvtoServis";
            builder.UserID = "ISPr24-38_SolominaAV";
            builder.Password = "ISPr24-38_SolominaAV";
            MySqlConnection connect = new MySqlConnection(builder.ConnectionString);
            try
            {
                connect.Open();
                MySqlCommand command = new MySqlCommand(sql, connect);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable table = new DataTable();
                table.Load(reader);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("При выполнении запроса произошла ошибка!" + ex.Message);
                return null;
            }
        }
    }
}
