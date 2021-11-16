using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine2._0
{
    class Water:Drink
    {

        public Water(string uname = "Без названия",
            Image upicture = null,
            int ucost = 10,
            bool utemperature = false,
            int uCookingTime = 5000)
        {
            name = uname;
            picture = upicture;
            cost = ucost;
            temperature = utemperature;
            cookingTime = uCookingTime;
            if (picture == null)
            {
                picture = (Image)Properties.Resources.DefaultIcon;
            }

        }
    }
}
