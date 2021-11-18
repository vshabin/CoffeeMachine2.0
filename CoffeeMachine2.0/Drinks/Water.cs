using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine2._0
{
    public class Water:Drink
    {
        public Water() { }
        public Water(string uname = "Без названия",
             string upicture = "../Resources/my_image.png",
            int ucost = 10,
            bool utemperature = false,
            int uCookingTime = 5000)
        {
            name = uname;
            picturepath = upicture;
            cost = ucost;
            temperature = utemperature;
            cookingTime = uCookingTime;

        }
    }
}
