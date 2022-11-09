using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FreshPage : ContentPage
    {
        public FreshPage()
        {
            InitializeComponent();
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string freshName = (e.CurrentSelection.FirstOrDefault() as Drink).Name;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"freshdetails?name={freshName}");
        }
    }
}