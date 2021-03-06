using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace CoffeeMachine2._0
{
    [XmlInclude(typeof(Tea))]
    [XmlInclude(typeof(Coffee))]
    [XmlInclude(typeof(Water))]
    [Serializable]
    public class Drink
    {
        public string name;
        public string picturepath;
        public int cost;
        public bool temperature, sugar;
        public int userStrenght, userSugar;
        public string userTemperature = "Горячий";
        public int cookingTime;
        public string animation;

        public Drink()
        {
        }

        public Drink(string uname="Без названия",
            string upicture= "../Resources/my_image.png",
            int ucost=10,
            bool utemperature=false,
            bool usugar=false,
            int uuserStrenght = 3,
            int uCookingTime = 5000,
            string uanimation = "../../Resources/default_animation.gif",
            int uUserSugar = 0,
            string uUserTemperature = "Горячий")
        {
            name = uname;
            picturepath = upicture;
            cost = ucost;
            temperature = utemperature;
            sugar = usugar;
            userStrenght = uuserStrenght;
            cookingTime = uCookingTime;
            animation = uanimation;
            userSugar = uUserSugar;
            userTemperature = uUserTemperature;
            
        }
    }
}
