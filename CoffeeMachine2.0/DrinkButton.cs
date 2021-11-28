﻿using System;
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
    public partial class DrinkButton : UserControl
    {
        Color selectedColor = Color.FromArgb(213, 146, 26);
        Color defaultColor = Color.FromArgb(241, 216, 129);
        public bool selected = false;
        public Drink thisDrink;

        public DrinkButton()
        {
            BackColor = defaultColor;
            InitializeComponent();
        }

        public void setDrink()
        {

                labelInfoAboutDrinkDB.Text = thisDrink.name + " : " + thisDrink.cost + " рублей";
                pbDrinkButton.Image = Image.FromFile(thisDrink.picturepath);

        }

        public void SetSelectedButton()
        {
            if (selected)
                selected = false;
            else
                selected = true;

            if (selected)
                BackColor = selectedColor;
            else
                BackColor = defaultColor;
        }

        public void EmptyButton()
        {
            selected = false;
            BackColor = defaultColor;
        }

        private void pbDrinkButton_Click(object sender, EventArgs e)
        {
            SetSelectedButton();
            Form1 main = this.Parent as Form1;
            foreach (Control c in Controls)
            {
                if (c is DrinkButton && c.Name != (sender as DrinkButton).Name)
                {
                    (c as DrinkButton).EmptyButton();
                }
                else if (c is DrinkButton)
                {
                    (sender as DrinkButton).SetSelectedButton();
                }
            }

            main.labelDrink.Text = "Напиток: " + thisDrink.name;

            main.labelAmount.Text = "Сумма к оплате: " + thisDrink.cost;

            CoffeeMachine.selectedDrink = thisDrink;

            if (selected)
                CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.SELECTED_DRINK;
            else
                CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.SELECTING_DRINK;
        }
    }
}
