using FoodApp.Models;
using FoodApp.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FoodApp.ViewModels
{
    public class FoodViewModel
    {
        public int IdFood { get; set; }
        public string FoodName { get; set; }
        public string FoodCategory { get; set; }
        public ObservableCollection<FoodViewModel> ListNewFoods = new ObservableCollection<FoodViewModel>();
        
        public void SendFood(AddFoodPage sender, string name, ModelFood model)
        {
            MessagingCenter.Send(sender, name, model);
        }

        public void GetFoods(object suscriber, string name)
        {
            MessagingCenter.Subscribe<AddFoodPage, ModelFood>(suscriber, name, (obj, item)=>
            {
                var newFood = item;
                FoodViewModel foodReceived = new FoodViewModel()
                {
                    IdFood = item.IDFood,
                    FoodName = item.FoodName,
                    FoodCategory = item.FoodCategory
                };
                ListNewFoods.Add(foodReceived);
            });
        }
    }
}
