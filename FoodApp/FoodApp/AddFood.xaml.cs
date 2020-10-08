using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FoodApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddFood : ContentPage
    {
        ModelFood objFood = new ModelFood();
        Random idRandom = new Random();

        public AddFood()
        {
            InitializeComponent();
            IDRandom();
        }
        private async void btnRegistroAlimento_Clicked(object sender, EventArgs e)
        {
            objFood.IDFood = int.Parse(txtIDFood.Text);
            objFood.FoodName = txtNameFood.Text;
            objFood.FoodCategory = txtCategoryFood.Text;

            try
            {
                MessagingCenter.Send(this, "AddingFood", objFood);
                await Navigation.PopModalAsync();
            }
            catch (Exception)
            {
                await DisplayAlert("Registro incorrecto", "Ocurrió un error durante el registro.", "OK");
            }
        }
        public async Task MostrarMensaje()
        {
            var action = await DisplayAlert("Registro satisfactorio", "¿Desea agregar más alimentos?", "SÍ", "NO");
            if (action)
            {
                IDRandom();
                txtNameFood.Text = null;
                txtCategoryFood.Text = null;
                return;
            }
            else
            {
                await Navigation.PopModalAsync();
            }
        }
        public void IDRandom()
        {
            txtIDFood.Text = idRandom.Next(1001, 9999).ToString();
        }
    }
}