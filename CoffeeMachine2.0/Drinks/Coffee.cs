using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine2._0
{
    class Coffee : Drink
    {

        public Coffee(string uname = "Без названия",
            Image upicture = null,
            int ucost = 10,
            bool utemperature = false,
            bool usugar = false,
            int uuserStrenght = 0,
            int uCookingTime = 5000)
        {
            name = uname;
            picture = upicture;
            cost = ucost;
            temperature = utemperature;
            sugar = usugar;
            userStrenght = uuserStrenght;
            cookingTime = uCookingTime;
            if (picture == null)
            {
                picture = (Image)Properties.Resources.DefaultIcon;
            }

        }
    }
}
