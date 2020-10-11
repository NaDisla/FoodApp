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

namespace FoodApp.Views
{
    public partial class MainPage : ContentPage
    {
        FoodViewModel viewModel = new FoodViewModel();

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
            if ((ListFood.ItemsSource as ObservableCollection<FoodViewModel>).Count != 0)
            {
                txtListEmpty.Text = null;
            }
        }
        void GetFoods()
        {
            viewModel.GetFoods(this, "AddingFood");
            ListFood.ItemsSource = viewModel.ListNewFoods;
        }
        private void btnNewFood_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new AddFoodPage());
        }
    }
}
