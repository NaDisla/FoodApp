using FoodApp.ViewModels;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace FoodApp
{
    public partial class MainPage : ContentPage
    {
        ObservableCollection<FoodViewModel> ListNewFoods = new ObservableCollection<FoodViewModel>();
        
        public MainPage()
        {
            InitializeComponent();
            GetFoods();
        }
        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            return true;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (ListFood.ItemsSource != null)
            {
                txtListEmpty.Text = null;
            }
        }
        void GetFoods()
        {
            MessagingCenter.Subscribe<AddFood, ModelFood>(this, "AddingFood", (obj, item) =>
            {
                var nuevaComida = item;
                FoodViewModel foodReceived = new FoodViewModel()
                {
                    IDFood = item.IDFood,
                    FoodName = item.FoodName,
                    FoodCategory = item.FoodCategory
                };
                ListNewFoods.Add(foodReceived);
                ListFood.ItemsSource = ListNewFoods;
            });
        }
        private void btnNewFood_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddFood());
        }
    }
}
