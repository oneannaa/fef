using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace WinFormsApp1
{
    public partial class menuForm : Form
    {
        public menuForm()
        {
            InitializeComponent();
        }

        private void managerBtN_Click(object sender, EventArgs e)
        {
            managersForm f2 = new managersForm();
            f2.Show();
            Hide();
        }

        private void companyBtN_Click(object sender, EventArgs e)
        {
            companyForm f2 = new companyForm();
            f2.Show();
            Hide();
        }
    }
}
