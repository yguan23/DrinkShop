using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HandMake : ContentPage
    {
        public HandMake()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string drinkName = (e.CurrentSelection.FirstOrDefault() as Drink).Name;
            // The following route works because route names are unique in this application.
            //await Shell.Current.GoToAsync($"catdetails?name={drinkName}");
            // The full route is shown below.
            await Shell.Current.GoToAsync($"//milkshop/handmake/handdetails?name={drinkName}");
        }
    }
}