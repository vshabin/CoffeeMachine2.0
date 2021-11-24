using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine2._0
{
    public class Coffee : Drink
    {
        public Coffee() { }
        public Coffee(string uname = "Без названия",
            string upicture = "../Resources/my_image.png",
            int ucost = 10,
            bool utemperature = false,
            bool usugar = true,
            int uuserStrenght = 3,
            int uCookingTime = 5000)
        {
            name = uname;
            picturepath = upicture;
            cost = ucost;
            temperature = utemperature;
            sugar = usugar;
            userStrenght = uuserStrenght;
            cookingTime = uCookingTime;

        }
    }
}
