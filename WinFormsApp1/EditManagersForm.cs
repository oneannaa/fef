using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace WinFormsApp1
{
    public partial class EditManagersForm : Form
    {
        public EditManagersForm()
        {
            InitializeComponent();
            DataTable data = DbConnection.select("select Familia as Фамилия, Name as Имя, Otchestvo as Отчество, dataBirthday as ДеньРождение, MedSpravka as МедСправка, DopuskKRabote as Допуск from managers");
            dataGridView1.DataSource = data;
        }

        private void backBtN_Click(object sender, EventArgs e)
        {
            managersForm f2 = new managersForm();
            f2.Show();
            Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           

        }
    }
}
