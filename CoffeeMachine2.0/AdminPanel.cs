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

        private void AddDrink_Click(object sender, EventArgs e)
        {
            Drink newDrink = new Drink(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked,
                tbStrenght.Value);
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
            boolTemperature.Checked= DrinkToEdit.temperature;
            boolSugar.Checked=DrinkToEdit.sugar;
            tbStrenght.Value= DrinkToEdit.userStrenght;
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
    }
}
