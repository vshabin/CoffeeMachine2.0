using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeMachine2._0
{
    class CoffeeMachine
    {
        
        public int balance = 0;
        public int change = 0;
        public string cookingStage = "Ожидаю заказ...";

        public Drink selectedDrink = new Drink();

        public static List<Drink> drinks = new List<Drink>();

        public void SetDefaultDrinks()
        {
            drinks.Add(new Tea("Чёрный чай", null, 25, false, false, 7000));
            drinks.Add(new Tea("Зелёный чай", null, 25, false, false, 7000));
            drinks.Add(new Coffee("Латте", null, 35, false, false, 3, 10000));
            drinks.Add(new Coffee("Американо", null, 30, false, false, 10000));
            drinks.Add(new Water("Вода", null, 5, false, 2000));
            drinks.Add(new Drink("Молочный коктейль", null, 50, false, false, 0, 15000));
            drinks.Add(new Drink("Горячий шоколад", null, 25, false, false, 0, 11000));
            drinks.Add(new Coffee("Эспрессо", null, 25, false, false, 10000));
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
