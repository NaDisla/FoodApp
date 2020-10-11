using FoodApp.Models;
using FoodApp.ViewModels;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFoodPage : ContentPage
    {
        ModelFood objFood = new ModelFood();
        Random idRandom = new Random();
        FoodViewModel viewModelFood = new FoodViewModel();

        public AddFoodPage()
        {
            InitializeComponent();
            IDRandom();
        }

        private async void btnRegistroAlimento_Clicked(object sender, EventArgs e)
        {
            objFood.IDFood = int.Parse(txtIDFood.Text);
            objFood.FoodName = txtNameFood.Text;
            objFood.FoodCategory = txtCategoryFood.Text;

            if (txtNameFood.Text != null && txtCategoryFood.Text != null)
            {
                viewModelFood.SendFood(this, "AddingFood", objFood);
                await Navigation.PopModalAsync();
            }
            else
                await DisplayAlert("Campos vacíos", "Debe de completar los campos requeridos.", "OK");
        }
        public void IDRandom()
        {
            txtIDFood.Text = idRandom.Next(1001, 9999).ToString();
        }
    }
}