using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace CoffeeMachine2._0
{
    public partial class AdminPanel : Form
    {
        string xmlpath = "../../Menu.xml";
        string tempImage= "../../Resources/DefaultIcon.png";

        public AdminPanel()
        {
            InitializeComponent();
            foreach (Drink drink in CoffeeMachine.drinks)
            {
                ListOfDrinks.Items.Add(drink.name);
            }
            if (CoffeeMachine.drinks.Count == 8)
            {
                lNotice.Visible = true;
            }
        }

        private void uploadImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog res = new OpenFileDialog();
            res.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";
            if (res.ShowDialog() == DialogResult.OK)
            {
                tempImage= res.FileName;
                pictureBox1.Image = Image.FromFile(tempImage);
            }
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
            if (CoffeeMachine.drinks.Count == 8) return;
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
            tempImage = "../../Resources/DefaultIcon.png";
            pictureBox1.Image = Image.FromFile(tempImage);
            if (CoffeeMachine.drinks.Count == 8)
            {
                lNotice.Visible = true;
            }
            else lNotice.Visible = false;
            Save();
        }

        private void DeleteDrink_Click(object sender, EventArgs e)
        {
            if (ListOfDrinks.SelectedItems.Count == 0) return;
            CoffeeMachine.drinks.RemoveAt(ListOfDrinks.SelectedIndex);
            ListOfDrinks.Items.RemoveAt(ListOfDrinks.SelectedIndex);
            Save();
        }

        private void EditDrink_Click(object sender, EventArgs e)
        {
            if (ListOfDrinks.SelectedItems.Count == 0) return;
            AddDrink.Visible = false;
            SaveEdit.Visible = true;
            Drink DrinkToEdit = CoffeeMachine.drinks[ListOfDrinks.SelectedIndex];
            name.Text = DrinkToEdit.name;
            tempImage = DrinkToEdit.picturepath;
            pictureBox1.Image = Image.FromFile(tempImage);
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
        }

        private void SaveEdit_Click(object sender, EventArgs e)
        {
            if (name.Text == "") return;
            if (rbWater.Checked)
            {
                CoffeeMachine.drinks[ListOfDrinks.SelectedIndex] = new Water(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked);
            }
            else if (rbTea.Checked)
            {
                CoffeeMachine.drinks[ListOfDrinks.SelectedIndex] = new Tea(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked);
            }
            else if (rbCoffee.Checked)
            {
                CoffeeMachine.drinks[ListOfDrinks.SelectedIndex] = new Coffee(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked,
                tbStrenght.Value);
            }
            else
            {
                 CoffeeMachine.drinks[ListOfDrinks.SelectedIndex] = new Drink(name.Text,
                tempImage,
                (int)cost.Value,
                boolTemperature.Checked,
                boolSugar.Checked,
                tbStrenght.Value,
                (int)TimeToCook.Value * 1000);
            }
            tempImage = "../../Resources/DefaultIcon.png";
            pictureBox1.Image = Image.FromFile(tempImage);
            rbCoffee.Checked = false;
            rbWater.Checked = false;
            rbTea.Checked = false;
            rbCustom.Checked = false;
            Save();
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
        private void Save()
        {
            File.WriteAllText(xmlpath, String.Empty);
            XmlSerializer serialiser = new XmlSerializer(typeof(List<Drink>));
            TextWriter FileStream = new StreamWriter(xmlpath);
            serialiser.Serialize(FileStream, CoffeeMachine.drinks);
            FileStream.Close();
        }

        private void AdminPanel_FormClosing(object sender, FormClosingEventArgs e)
        {
            Form1 main = this.Owner as Form1;
            if (main != null)
            {
                main.Opacity = 1;
                main.SetSettingsForDrinkButtons();
            }
        }
    }
}
