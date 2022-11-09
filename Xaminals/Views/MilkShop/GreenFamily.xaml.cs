using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Xaminals.Models;

namespace Xaminals.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GreenFamily : ContentPage
    {
        public GreenFamily()
        {
            InitializeComponent();
        }

        async void OnCollectionViewSelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string drinkName = (e.CurrentSelection.FirstOrDefault() as Drink).Name;
            // The following route works because route names are unique in this application.
            //await Shell.Current.GoToAsync($"catdetails?name={drinkName}");
            // The full route is shown below.
            await Shell.Current.GoToAsync($"//milkshop/greenfamily/familydetails?name={drinkName}");
        }
    }
}