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
        public bool isCoocking = false;
        public bool balanceZeroMore = false;

        public static Drink selectedDrink;

        public static List<Drink> drinks = new List<Drink>();

        public static CoffeeMachineStage cfStage = CoffeeMachineStage.SELECTING_DRINK;

        public enum CoffeeMachineStage
        {
            SELECTING_DRINK,
            SELECTED_DRINK,
            COOCKING_DRINK,
            COOCKED_DRINK
        }

        public async void Cook()//готовка напитка
        {
            if (balanceZeroMore)
            {
                cfStage = CoffeeMachineStage.COOCKING_DRINK;
                isCoocking = true;
                /* Добавить текст с теми параметрами, которые выбрал пользователь в строку ниже */
                await Task.Delay(selectedDrink.cookingTime);
                CountChange();
                balance = 0;
                cfStage = CoffeeMachineStage.COOCKED_DRINK;
                isCoocking = true;
            }
            else
            {
                cfStage = CoffeeMachineStage.SELECTED_DRINK;
                isCoocking = false;
            }
            balanceZeroMore = false;
        }

        public void CountChange()//рассчитать сдачу
        {
            //if(balance > selectedDrink.cost)
            change = balance - selectedDrink.cost;

            if (change >= 0)
                balanceZeroMore = true;
            else
                balanceZeroMore = false;
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
