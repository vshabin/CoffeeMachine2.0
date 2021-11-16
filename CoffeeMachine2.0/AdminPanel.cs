using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//имя
namespace CoffeeMachine2._0
{
    public partial class AdminPanel : Form
    {
        Image tempImage= (Image)Properties.Resources.DefaultIcon;

        public AdminPanel()
        {
            InitializeComponent();
            foreach (Drink drink in CoffeeMachine.drinks)
            {
                ListOfDrinks.Items.Add(drink.name);
            }
        }

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
        private void TimeToCook_KeyUp(object sender, KeyEventArgs e)
        {
            if (cost.Value > 300) cost.Value = 300;
        }
        private void AddDrink_Click(object sender, EventArgs e)
        {
            if (name.Text == "") return;
            Drink newDrink;
            if (rbWater.Checked)
            {
                newDrink = new Water(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked);
            }
            else if (rbTea.Checked)
            {
                newDrink = new Tea(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked);
            }
            else if (rbCoffee.Checked)
            {
                newDrink = new Coffee(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked,
                tbStrenght.Value);
            }
            else{
                newDrink = new Drink(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked,
                tbStrenght.Value,
                (int)TimeToCook.Value * 1000);
            }
            CoffeeMachine.drinks.Add(newDrink);
            ListOfDrinks.Items.Add(newDrink.name);
            tempImage = (Image)Properties.Resources.DefaultIcon;
            pictureBox1.Image = tempImage;

        }

        private void DeleteDrink_Click(object sender, EventArgs e)
        {
            if (ListOfDrinks.SelectedItems.Count == 0) return;
            CoffeeMachine.drinks.RemoveAt(ListOfDrinks.SelectedIndex);
            ListOfDrinks.Items.RemoveAt(ListOfDrinks.SelectedIndex);
        }

        private void EditDrink_Click(object sender, EventArgs e)
        {
            if (ListOfDrinks.SelectedItems.Count == 0) return;
            AddDrink.Visible = false;
            SaveEdit.Visible = true;
            Drink DrinkToEdit = CoffeeMachine.drinks[ListOfDrinks.SelectedIndex];
            name.Text = DrinkToEdit.name;
            tempImage = DrinkToEdit.picture;
            pictureBox1.Image = tempImage;
            cost.Value= DrinkToEdit.cost;
            if (DrinkToEdit.GetType() == typeof(Water))
            {
                rbWater.Checked = true;
                boolTemperature.Checked = DrinkToEdit.temperature;
                return;
            }
            if (DrinkToEdit.GetType() == typeof(Tea))
            {
                boolTemperature.Checked = DrinkToEdit.temperature;
                boolSugar.Checked = DrinkToEdit.sugar;
                rbTea.Checked = true;
                return;
            }
            if (DrinkToEdit.GetType() == typeof(Coffee))
            {
                boolTemperature.Checked = DrinkToEdit.temperature;
                boolSugar.Checked = DrinkToEdit.sugar;
                tbStrenght.Value = DrinkToEdit.userStrenght;
                rbCoffee.Checked = true;
                return;
            }

            boolTemperature.Checked = DrinkToEdit.temperature;
            boolSugar.Checked = DrinkToEdit.sugar;
            tbStrenght.Value = DrinkToEdit.userStrenght;
            TimeToCook.Value = DrinkToEdit.cookingTime / 1000;
            rbCustom.Checked = true;
            return;
            
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            SaveEdit.Visible = false;
            AddDrink.Visible = true;
            CoffeeMachine.drinks[ListOfDrinks.SelectedIndex].name = name.Text;
            CoffeeMachine.drinks[ListOfDrinks.SelectedIndex].picture = tempImage;
            CoffeeMachine.drinks[ListOfDrinks.SelectedIndex].cost = (int)cost.Value;
            CoffeeMachine.drinks[ListOfDrinks.SelectedIndex].temperature = boolTemperature.Checked;
            CoffeeMachine.drinks[ListOfDrinks.SelectedIndex].sugar = boolSugar.Checked;
            CoffeeMachine.drinks[ListOfDrinks.SelectedIndex].userStrenght = tbStrenght.Value;
            ListOfDrinks.Items[ListOfDrinks.SelectedIndex] = name.Text;
            name.Text = "";
            tempImage = (Image)Properties.Resources.DefaultIcon;
            pictureBox1.Image = tempImage;
            cost.Value = 0;
            boolTemperature.Checked = false;
            boolSugar.Checked = false;
            tbStrenght.Value = 0;
        }

        private void rbWater_CheckedChanged(object sender, EventArgs e)
        {
            if (rbWater.Checked)
            {
                boolSugar.Visible = false;
                tbStrenght.Visible = false;
                TimeToCook.Visible = false;
                label6.Visible = false;
                label9.Visible = false;
                label7.Visible = false;
                
            }
            else
            {
                boolSugar.Visible = true;
                tbStrenght.Visible = true;
                TimeToCook.Visible = true;
                label6.Visible = true;
                label9.Visible = true;
                label7.Visible = true;
            }
        }

        private void rbTea_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTea.Checked)
            {
                tbStrenght.Visible = false; 
                TimeToCook.Visible = false;
                label9.Visible = false;
                label7.Visible = false;
            }
            else
            {
                tbStrenght.Visible = true;
                TimeToCook.Visible = true;
                label9.Visible = true;
                label7.Visible = true;
            }
        }

        private void rbCoffee_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCoffee.Checked)
            {
                TimeToCook.Visible = false;
                label7.Visible = false;
            }
            else
            {
                TimeToCook.Visible = true;
                label7.Visible = true;
            }
        }
    }
}
