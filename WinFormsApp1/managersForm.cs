using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class managersForm : Form
    {
        public managersForm()
        {
            InitializeComponent();
            DataTable data = DbConnection.select("select Familia as Фамилия, Name as Имя, Otchestvo as Отчество, dataBirthday as ДеньРождение, MedSpravka as МедСправка, DopuskKRabote as Допуск from managers");
            dataGridView1.DataSource = data;
        }

        private void backBtN_Click(object sender, EventArgs e)
        {
            menuForm f2 = new menuForm();
            f2.Show();
            Hide();
        }

        private void addBtN_Click(object sender, EventArgs e)
        {
            AddManagersForm f2 = new AddManagersForm();
            f2.Show();
            Hide();
        }

        private void editBtN_Click(object sender, EventArgs e)
        {
            EditManagersForm f2 = new EditManagersForm();
            f2.Show();
            Hide();
        }
    }
}
