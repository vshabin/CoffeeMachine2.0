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
        Color chooseColor = Color.Black;
        bool selected = false;

        public DrinkButton()
        {
            InitializeComponent();
        }

        public bool Selected
        {
            set
            {
                selected = value;
                Refresh();
            }
            get { return selected; }
        }

        public Color ChooseColor
        {
            set 
            {
                chooseColor = value;
                Refresh();
            }
            get { return chooseColor; }
        }
    }
}
