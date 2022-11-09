using System.Linq;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TastePage : ContentPage
    {
        public TastePage()
        {
            InitializeComponent();
        }

        async private void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string tasteName = (e.CurrentSelection.FirstOrDefault() as Drink).Name;
            // The following route works because route names are unique in this application.
            await Shell.Current.GoToAsync($"tastedetails?name={tasteName}");
        }
    }
}