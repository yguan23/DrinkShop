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
    public partial class ComebuyMilkteaPage : ContentPage
    {
        public ComebuyMilkteaPage()
        {
            InitializeComponent();
        }
        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string ComebuyMilkteaName = (e.CurrentSelection.FirstOrDefault() as Drink).Name;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"ComebuyMilkteadetails?name={ ComebuyMilkteaName}");
        }
    }
}