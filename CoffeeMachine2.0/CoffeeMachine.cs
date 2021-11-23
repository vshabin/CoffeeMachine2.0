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

        public static Drink selectedDrink;

        public static List<Drink> drinks = new List<Drink>();

        public async void Cook()//готовка напитка
        {
            if (balance >= selectedDrink.cost)
            {
                /* Добавить текст с теми параметрами, которые выбрал пользователь в строку ниже */
                cookingStage = "Готовлю ваш заказ...";
                await Task.Delay(selectedDrink.cookingTime);
                CountChange();
                cookingStage = string.Format("Ваш заказ готов! Всего доброго! Ваши {0} рублей.", change);
                balance = 0;
            }
            else
                cookingStage = "У вас недостаточно денег!";
        }

        private void CountChange()//рассчитать сдачу
        {
            if(balance > selectedDrink.cost)
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
    }
}
