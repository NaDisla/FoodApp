using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace FoodApp.ViewModels
{
    public class FoodViewModel
    {
        private int idFood;

        public int IDFood
        {
            get { return idFood; }
            set { idFood = value; }
        }

        private string foodName;

        public string FoodName
        {
            get { return foodName; }
            set { foodName = value; }
        }

        private string foodCategory;

        public string FoodCategory
        {
            get { return foodCategory; }
            set { foodCategory = value; }
        }

        public FoodViewModel()
        {

        }
    }
}
