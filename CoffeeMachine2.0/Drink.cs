using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace CoffeeMachine2._0
{
    class Drink
    {

        string name;
        Image picture;
        int cost;
        bool temperature, sugar;
        int userTemperature, userSugar, userStrenght;
        public Drink(string uname="Без названия",
            Image upicture=null,
            int ucost=10,
            bool utemperature=false,
            bool usugar=false,
            int uuserTemperature=0,
            int uuserSugar=0,
            int uuserStrenght=0)
        {
            name = uname;
            picture = upicture;
            temperature = utemperature;
            sugar = usugar;
            userTemperature = uuserTemperature;
            userSugar = uuserSugar;
            userStrenght = uuserStrenght;
            if (picture == null)
            {
                picture = (Image)Properties.Resources.DefaultIcon;
            }

        }
    }
}
