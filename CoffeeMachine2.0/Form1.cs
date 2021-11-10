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
        CoffeeMachine cf = new CoffeeMachine();
        public Form1()
        {
            InitializeComponent();
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
            await Task.Delay(6000);
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

        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void panel1_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void panel1_DragDrop(object sender, DragEventArgs e)
        {
            //cf.balance += e.

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdminPanel a = new AdminPanel();
            a.Show();
        }
    }
}
