using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mobilna
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            //animalsListView.ItemsSource = new List<string> { "Pies", "Kot", "Świnka morska" };
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            DisplayAlert("Zapisana Wizyta", $"{nameAndSurnameEntry.Text}, {animalsListView.SelectedItem}, {Math.Floor(ageSlider.Value)}, {purposeEntry.Text}, {timePicker.Time}", "OK");
        }

        void AnimalsListView_ItemTapped(System.Object sender, Xamarin.Forms.ItemTappedEventArgs e)
        {
            string selectedAnimal = (string)e.Item;
            switch(selectedAnimal)
            {
                case "Pies":
                    ageSlider.Maximum = 18;
                    break;
                case "Kot":
                    ageSlider.Maximum = 20;
                    break;
                case "Świnka morska":
                    ageSlider.Maximum = 9;
                    break;
            }
        }
    }
}

