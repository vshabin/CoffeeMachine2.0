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

        public DrinkButton()
        {
            BackColor = defaultColor;
            InitializeComponent();
        }

        public void setDrink()
        {
            labelInfoAboutDrinkDB.Text = thisDrink.name + " : " + thisDrink.cost + " рублей";
            pbDrinkButton.Image = thisDrink.picture;
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
            BackColor = defaultColor;
        }
    }
}
