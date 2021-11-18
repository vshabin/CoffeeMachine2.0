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
    public partial class Form1 : Form
    {
        string xmlpath = "../../Menu.xml";
        CoffeeMachine cf = new CoffeeMachine();
        private string userBalance = "Внесено: ";
        public Form1()
        {
            InitializeComponent();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Drink>));
                using (FileStream stream = new FileStream(xmlpath, FileMode.Open))
                {
                    CoffeeMachine.drinks = (List<Drink>)serializer.Deserialize(stream);
                }
        }

        void SetSettingsForDrinkButtons()
        {
            int i = 0;
            foreach (Control c in this.Controls)
            {
                if (c is DrinkButton)
                {
                    (c as DrinkButton).thisDrink = CoffeeMachine.drinks[i];
                    (c as DrinkButton).setDrink();
                    i++;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            labelCookStage.Text = cf.cookingStage;
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 1;
            timer1.Start();
            cf.Cook();
            await Task.Delay(CoffeeMachine.selectedDrink.cookingTime + 1000);
            timer1.Stop();
        }

        private void tbSugarProp_ValueChanged(object sender, EventArgs e)
        {
            labelAmountOfSugar.Text = labelAmountOfSugar.Text.Remove(labelAmountOfSugar.Text.Length - 1);
            labelAmountOfSugar.Text += tbSugarProp.Value.ToString();
        }

        private void tbTemperatureProp_ValueChanged(object sender, EventArgs e)
        {
            string tempDrinkDesign = "";
            switch (tbTemperatureProp.Value)
            {
                case 0: 
                    tempDrinkDesign = "Холодный";
                    break;
                case 1:
                    tempDrinkDesign = "Комнатной";
                    break;
                case 2:
                    tempDrinkDesign = "Тёплый";
                    break;
                case 3:
                    tempDrinkDesign = "Горячий";
                    break;
            }
            labelUserTemperature.Text = tempDrinkDesign;
        }

        private void panelCoinOne_MouseDown(object sender, MouseEventArgs e)
        {
            panelCoinOne.DoDragDrop(int.Parse(panelCoinOne.Tag.ToString()), DragDropEffects.Move);
        }

        private void panelCoinAcceptor_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panelCoinAcceptor_DragDrop(object sender, DragEventArgs e)
        {
            cf.SetBalance(int.Parse(e.Data.GetData(typeof(int)).ToString()));
            labelBalance.Text = userBalance + cf.balance.ToString();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form ap = new AdminPanel();
            ap.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetSettingsForDrinkButtons();
        }

        private void drinkButton1_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                if (c is DrinkButton && c.Name != (sender as DrinkButton).Name)
                {
                    (c as DrinkButton).EmptyButton();
                }
                else
                {
                    (sender as DrinkButton).SetSelectedButton();
                }
            }

            labelDrink.Text = "Напиток: " + (sender as DrinkButton).thisDrink.name;

            labelAmount.Text = "Сумма к оплате: " + (sender as DrinkButton).thisDrink.cost;

            CoffeeMachine.selectedDrink = (sender as DrinkButton).thisDrink;
        }
    }
}
