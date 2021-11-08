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
    public partial class AdminPanel : Form
    {
        public AdminPanel()
        {
            InitializeComponent();
        }
        Image tempImage=null;
        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (res.ShowDialog() == DialogResult.OK)
            {
                tempImage= Image.FromFile(res.FileName);
                pictureBox1.Image = tempImage;
            }
        }
        private void AdminPanel_Load(object sender, EventArgs e)
        {

        }

        private void cost_KeyUp(object sender, KeyEventArgs e)
        {
            if (cost.Value > 10000) cost.Value = 10000;
        }

        private void AddDrink_Click(object sender, EventArgs e)
        {
            Drink newDrink = new Drink(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked,
                tbStrenght.Value);

        }
    }
}
