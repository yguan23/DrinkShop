using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using static Xaminals.Views.FreshDetailPage;

namespace Xaminals.Controls
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShoppingCartPage : ContentPage
    {
        public ShoppingCartPage()
        {
            InitializeComponent();
        }
    }
}