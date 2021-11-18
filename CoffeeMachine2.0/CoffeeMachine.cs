using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine2._0
{
    class CoffeeMachine
    {
        string xmlpath = "Menu.xml";
        public int balance = 0;
        public int change = 0;
        public string cookingStage = "Ожидаю заказ...";

        public Drink selectedDrink = new Drink();

        public static List<Drink> drinks = new List<Drink>();

        public void SetDefaultDrinks()
        {
            drinks.Add(new Drink("Капучино", null, 15, true, true, 5, 10000));
        }

        public async void Cook()//готовка напитка
        {
            /* Добавить текст с теми параметрами, которые выбрал пользователь в строку ниже */
            cookingStage = "Готовлю ваш заказ...";
            await Task.Delay(selectedDrink.cookingTime);
            CountChange();
            cookingStage = string.Format("Ваш заказ готов! Всего доброго! Ваши {0} рублей.", change);
        }

        private void CountChange()//рассчитать сдачу
        {
            change = balance - selectedDrink.cost;
        }

        public void Cancellation()//отмена действий
        {
            selectedDrink = null;
            balance = 0;
            change = 0;
        }

        public void SetBalance(int balance)//добавление внесённой суммы к балансу
        {
            this.balance += balance;
        }

        public void SetDrink()//занесение выбранного напитка
        {

        }
    }
}
