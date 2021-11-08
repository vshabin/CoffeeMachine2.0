using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeMachine2._0
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void openAdminPanel_Click(object sender, EventArgs e)
        {
            Form adminPanel = new AdminPanel();
            adminPanel.Show();
        }
    }
}
