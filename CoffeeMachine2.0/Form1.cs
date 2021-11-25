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
        private delegate void cfStageDelegate();
        cfStageDelegate[] massOfStages = new cfStageDelegate[4];
        public Form1()
        {
            InitializeComponent();
            XmlSerializer serializer = new XmlSerializer(typeof(List<Drink>));
                using (FileStream stream = new FileStream(xmlpath, FileMode.Open))
                {
                    CoffeeMachine.drinks = (List<Drink>)serializer.Deserialize(stream);
                }

            massOfStages[0] = CoffeeMachineStageSelceting;
            massOfStages[1] = CoffeeMachineStageSelceted;
            massOfStages[2] = CoffeeMachineStageCoocking;
            massOfStages[3] = CoffeeMachineStageCoocked;

            SetStage(CoffeeMachine.CoffeeMachineStage.SELECTING_DRINK);
        }

        void SetStage(CoffeeMachine.CoffeeMachineStage stage)
        {
            int stageNumber = (int)stage;

            massOfStages[stageNumber]();
        }

        void CoffeeMachineStageSelceting()
        {
            tbTemperatureProp.Enabled = false;
            tbSugarProp.Enabled = false;
            butCook.Enabled = false;
            butChangeNDrink.Enabled = false;
            tbSugarProp.Value = 0;
            tbTemperatureProp.Value = 0;
            CoffeeMachine.selectedDrink = null;
            labelAmount.Text = "Сумма к оплате: ";
            labelBalance.Text = "Внесено: ";
            foreach (Control db in Controls)
            {
                if (db is DrinkButton)
                    (db as DrinkButton).EmptyButton();
            }
        }

        void CoffeeMachineStageSelceted()
        {
            if (CoffeeMachine.selectedDrink.sugar)
            tbTemperatureProp.Enabled = true;

            if(CoffeeMachine.selectedDrink.temperature)
            tbSugarProp.Enabled = true;

            butCook.Enabled = true;
        }

        void CoffeeMachineStageCoocking()
        {
            foreach (Control formElement in Controls)
            {
                if (!(formElement is Panel) && !(formElement is Panel))
                    formElement.Enabled = false;
            }
        }

        void CoffeeMachineStageCoocked()
        {
            foreach (Control formElement in Controls)
            {
                formElement.Enabled = true;
            }

            butCook.Enabled = false;
            butСancellation.Enabled = false;
            butChangeNDrink.Enabled = true;
        }

        public void SetSettingsForDrinkButtons()
        {
            int i = 0;
            foreach (Control c in this.Controls)
            {
                if (c is DrinkButton)
                {
                    if (i <= CoffeeMachine.drinks.Count - 1)
                    {
                        (c as DrinkButton).Visible = true;
                        (c as DrinkButton).thisDrink = CoffeeMachine.drinks[i];
                        (c as DrinkButton).setDrink();
                        i++;
                    }
                    else
                    {
                        (c as DrinkButton).Visible = false;
                    }
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
            SetStage(CoffeeMachine.cfStage);
            await Task.Delay(CoffeeMachine.selectedDrink.cookingTime + 1000);
            timer1.Stop();
        }

        private void tbSugarProp_ValueChanged(object sender, EventArgs e)
        {
            labelAmountOfSugar.Text = labelAmountOfSugar.Text.Remove(labelAmountOfSugar.Text.Length - 1);
            labelAmountOfSugar.Text += tbSugarProp.Value.ToString();
            CoffeeMachine.selectedDrink.userSugar = tbSugarProp.Value;
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
            CoffeeMachine.selectedDrink.userTemperature = tbTemperatureProp.Value;
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
            Form newForm = new AdminPanel();
            newForm.Owner = this; //устанавливаем родительской первую форму
            this.Opacity = .75; // устанавливаем прозрачность на 75% (для красоты)
            newForm.ShowInTaskbar = false; // скрываем всплывающую форму из панели задач (для красоты)
            newForm.ShowDialog(this); //открываем вторую форму в модальном режиме
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

            SetStage(CoffeeMachine.CoffeeMachineStage.SELECTED_DRINK);
        }

        private void butСancellation_Click(object sender, EventArgs e)
        {
            cf.balance = 0;
            cf.change = 0;
            SetStage(CoffeeMachine.CoffeeMachineStage.SELECTING_DRINK);
        }

        private void butChangeNDrink_Click(object sender, EventArgs e)
        {
            SetStage(CoffeeMachine.CoffeeMachineStage.COOCKED_DRINK);
        }
    }
}
