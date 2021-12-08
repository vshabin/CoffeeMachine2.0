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
    public partial class DrinkButton : UserControl
    {
        Color selectedColor = Color.FromArgb(213, 146, 26);
        Color defaultColor = Color.FromArgb(241, 216, 129);
        public bool selected = false;
        public Drink thisDrink;
        static int numberOfDrink = 0;

        public DrinkButton()
        {
            BackColor = defaultColor;
            InitializeComponent();
            Form1.drinkButtons.Add(this);
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
            Form1 main = this.Parent as Form1;

            DrinkButton element;

            if (!(sender is DrinkButton))
                element = (DrinkButton)((Control)sender).Parent;
            else
                element = sender as DrinkButton;

            foreach (DrinkButton db in Form1.drinkButtons)
            {
                if (db.Name != element.Name)
                    db.EmptyButton();
                else
                    element.SetSelectedButton();
            }

            //foreach (Control c in main.Controls)
            //{
            //    if (c is DrinkButton && c.Name != element.Name)
            //    {
            //        (c as DrinkButton).EmptyButton();
            //    }
            //    else if (c is DrinkButton)
            //    {
            //        element.SetSelectedButton();
            //    }
            //}

            main.labelDrink.Text = "Напиток: " + thisDrink.name;

            main.labelAmount.Text = "Сумма к оплате: " + thisDrink.cost;

            CoffeeMachine.selectedDrink = thisDrink;

            if (selected)
                CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.SELECTED_DRINK;
            else
                CoffeeMachine.cfStage = CoffeeMachine.CoffeeMachineStage.SELECTING_DRINK;
            main.SetStage(CoffeeMachine.cfStage);
        }
    }
}
