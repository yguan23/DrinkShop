using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GoodTeaPage : ContentPage
    {
        public GoodTeaPage()
        {
            InitializeComponent();
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string goodteaName = (e.CurrentSelection.FirstOrDefault() as Drink).Name;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"goodteadetails?name={goodteaName}");
        }
    }
}