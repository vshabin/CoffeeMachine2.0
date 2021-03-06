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
        string tempDrinkDesign = "Холодный";
        public static List<DrinkButton> drinkButtons = new List<DrinkButton>();

        public Form1()
        {
            InitializeComponent();
            BackColor = Color.FromArgb(249, 244, 230);
            panel1.BackColor = Color.FromArgb(241, 216, 129);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Drink>));
                using (FileStream stream = new FileStream(xmlpath, FileMode.Open))
                {
                    CoffeeMachine.drinks = (List<Drink>)serializer.Deserialize(stream);
                }

            massOfStages[0] = CoffeeMachineStageSelecting;
            massOfStages[1] = CoffeeMachineStageSelceted;
            massOfStages[2] = CoffeeMachineStageCoocking;
            massOfStages[3] = CoffeeMachineStageCoocked;

            CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.SELECTING_DRINK;
            SetStage(CoffeeMachine.cfStage);
        }



        public void SetStage(CoffeeMachine.CoffeeMachineStage stage)
        {
            int stageNumber = (int)stage;

            massOfStages[stageNumber]();
        }

        void CoffeeMachineStageSelecting()
        {
            CoffeeMachine.selectedDrink = new Drink();
            labelDrink.Text = "Напиток: ";
            labelAmount.Text = "Сумма к оплате: ";
            labelBalance.Text = "Внесено: " + cf.balance;
            labelCookStage.Text = "Ожидаю заказ...";
            foreach (Control db in Controls)
            {
                if (db is MenuStrip)
                    db.Enabled = true;

                if (db is TrackBar)
                {
                    db.Enabled = false;
                    (db as TrackBar).Value = 0;
                }

                if (db is Button && (db != butСancellation))
                    db.Enabled = false;

                if (db is Panel)
                    db.Enabled = true;

                if (db is DrinkButton)
                {
                    (db as DrinkButton).EmptyButton();
                    db.Enabled = true;
                }

            }
            CoffeeMachine.selectedDrink = null; 
            if(pbAnimation.Image != null)
            pbAnimation.Image.Dispose();
            pbAnimation.Image = Image.FromFile("..\\..\\Resources\\selecting.png");
        }

        void CoffeeMachineStageSelceted()
        {
            menuStrip1.Enabled = false;
            cf.CountChange();
            butСancellation.Enabled = true;
            
            if (cf.balanceZeroMore)
            {
                labelCookStage.Text = "Нажмите 'Готовить'";
                butCook.Enabled = true;
            }
            else
            {
                labelCookStage.Text = "Недостаточно денег";
                butCook.Enabled = false;
            }

            if (CoffeeMachine.selectedDrink.temperature)
                tbTemperatureProp.Enabled = true;
            else
                tbTemperatureProp.Enabled = false;

            if(CoffeeMachine.selectedDrink.sugar)
                tbSugarProp.Enabled = true;
            else
                tbSugarProp.Enabled = false;
            pbAnimation.Enabled = true;
        }

        void CoffeeMachineStageCoocking()
        {
            labelCookStage.Text = "Готовлю ваш заказ...";
            pbAnimation.Image.Dispose();
            pbAnimation.Image = Image.FromFile(CoffeeMachine.selectedDrink.animation);

            foreach (Control formElement in Controls)
            {
                if ((formElement != panelDisplay) && !(formElement is Label))
                    formElement.Enabled = false;
            }
            CoffeeMachine.selectedDrink.userTemperature = tempDrinkDesign;
            pbAnimation.Enabled = true;
        }

        void CoffeeMachineStageCoocked()
        {
                if(!CoffeeMachine.selectedDrink.temperature)
                labelCookStage.Text = string.Format("Ваш заказ готов: {1}, {2} сах.! Всего доброго! Ваши {0} рублей.",
                                      cf.change,
                                      CoffeeMachine.selectedDrink.name,
                                      CoffeeMachine.selectedDrink.userSugar);
            else
                labelCookStage.Text = string.Format("Ваш заказ готов: {1}, {2} сах.,{3}! Всего доброго! Ваши {0} рублей.",
                                      cf.change,
                                      CoffeeMachine.selectedDrink.name,
                                      CoffeeMachine.selectedDrink.userSugar,
                                      CoffeeMachine.selectedDrink.userTemperature);
            pbAnimation.Image.Dispose();
            pbAnimation.Image = Image.FromFile(CoffeeMachine.selectedDrink.picturepath);
            pbAnimation.Enabled = true;
            pbAnimation.Enabled = true;
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
            //SetStage(CoffeeMachine.cfStage);
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            cf.Cook();
            if(cf.isCoocking)
            CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.COOCKING_DRINK;
            SetStage(CoffeeMachine.cfStage);
            await Task.Delay(CoffeeMachine.selectedDrink.cookingTime + 1000);
            cf.isCoocking = false;
            CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.COOCKED_DRINK;
            SetStage(CoffeeMachine.cfStage);
        }

        private void tbSugarProp_ValueChanged(object sender, EventArgs e)
        {
            labelAmountOfSugar.Text = labelAmountOfSugar.Text.Remove(labelAmountOfSugar.Text.Length - 1);
            labelAmountOfSugar.Text += tbSugarProp.Value.ToString();
            CoffeeMachine.selectedDrink.userSugar = tbSugarProp.Value;
        }

        private void tbTemperatureProp_ValueChanged(object sender, EventArgs e)
        {
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
            CoffeeMachine.selectedDrink.userTemperature = labelUserTemperature.Text;
        }

        private void panelCoinOne_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Panel).DoDragDrop(int.Parse((sender as Panel).Tag.ToString()), DragDropEffects.Move);
        }

        private void panelCoinAcceptor_DragOver(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panelCoinAcceptor_DragDrop(object sender, DragEventArgs e)
        {
            cf.SetBalance(int.Parse(e.Data.GetData(typeof(int)).ToString()));
            labelBalance.Text = userBalance + cf.balance.ToString();
            cf.CountChange();
            SetStage(CoffeeMachine.cfStage);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetSettingsForDrinkButtons();
        }


        private void butСancellation_Click(object sender, EventArgs e)
        {
            if (cf.balance > 0)
                MessageBox.Show(string.Format("Мы вернули вам {0} рублей", cf.balance), "Возврат денег", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cf.balance = 0;
            cf.change = 0;
            CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.SELECTING_DRINK;
            SetStage(CoffeeMachine.cfStage);
        }

        private void butChangeNDrink_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmAdminPanel_Click(object sender, EventArgs e)
        {
            Form newForm = new AdminPanel();
            newForm.Owner = this; //устанавливаем родительской первую форму
            this.Opacity = .75; // устанавливаем прозрачность на 75% (для красоты)
            newForm.ShowInTaskbar = false; // скрываем всплывающую форму из панели задач (для красоты)
            newForm.ShowDialog(this);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (cf.isCoocking)
            {
                DialogResult result = MessageBox.Show("Вы точно хотите оставить нам свой кофе?", "Происходит готовка...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
            else if (CoffeeMachine.cfStage == CoffeeMachine.CoffeeMachineStage.COOCKED_DRINK || cf.balance > 0)
            {
                DialogResult result = MessageBox.Show("Вы точно хотите оставить нам свои деньги?", "Вы не забрали деньги...", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    e.Cancel = true;
            }
        }

        private void pbAnimation_Click(object sender, EventArgs e)
        {
            CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.SELECTING_DRINK;
            SetStage(CoffeeMachine.cfStage);
        }
    }
}