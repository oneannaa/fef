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
    public partial class AddManagersForm : Form
    {
        public AddManagersForm()
        {
            InitializeComponent();
            DataTable data = DbConnection.select("select Familia as Фамилия, Name as Имя, Otchestvo as Отчество, dataBirthday as ДеньРождение, MedSpravka as МедСправка, DopuskKRabote as Допуск from managers");
            dataGridView1.DataSource = data;
        }

        private void backBtN_Click(object sender, EventArgs e)
        {
            managersForm f3 = new managersForm();
            f3.Show();
            Hide();
        }

        private void editBtN_Click(object sender, EventArgs e)
        {
            {
                if ((famTB.Text == "") || (nameTB.Text == "") || (otchestvoTB.Text == "") || (dataTB.Text == "") || (spravkaTB.Text == "") || (dopuskTB.Text == ""))
                {
                    MessageBox.Show("Заполните все поля");
                }
                else
                {
                    DataTable data = DbConnection.select(@"INSERT INTO managers
(`Familia`, `Name`, `Otchestvo`, `dataBirthday`, `MedSpravka`, `DopuskKRabote`) VALUES ('" + famTB.Text + "', '" + nameTB.Text + "', '" + otchestvoTB.Text + "', '" + dataTB.Text + "', '" + spravkaTB.Text + "', '" + dopuskTB.Text + "')");
                    data = DbConnection.select(@"SELECT * FROM managers");
                    famTB.Clear();
                    nameTB.Clear();
                    otchestvoTB.Clear();
                    dataTB.Clear();
                    spravkaTB.Clear();
                    dopuskTB.Clear();
                    dataGridView1.DataSource = data;
                    managersForm f3 = new managersForm();
                    f3.Show();
                    Hide();
                }
            }
        }
    }
}
