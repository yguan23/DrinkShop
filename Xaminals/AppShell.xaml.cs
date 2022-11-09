using System;
using System.Collections.Generic;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xaminals.Views;

namespace Xaminals
{
    public partial class AppShell : Shell
    {
        public Dictionary<string, Type> Routes { get; private set; } = new Dictionary<string, Type>();
        public ICommand HelpCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));
        public ICommand MapCommand => new Command<string>(async (url) => await Launcher.OpenAsync(url));

        public AppShell()
        {
            InitializeComponent();
            RegisterRoutes();
            BindingContext = this;
        }

        void RegisterRoutes()
        {
            Routes.Add("kebukedetails", typeof(KebukeDetailPage));

            Routes.Add("goodteadetails", typeof(GoodTeaDetailPage));
            Routes.Add("freshdetails", typeof(FreshDetailPage));
            Routes.Add("tastedetails", typeof(TasteDetailPage));
            Routes.Add("milkteadetails", typeof(MilkTeaDetailPage));

            Routes.Add("kumodetails", typeof(KumoDetailPage));
            Routes.Add("absolutelydetails", typeof(AbsolutelyDetailPage));
            Routes.Add("teadetails", typeof(TeaDetails));
            Routes.Add("greendetails", typeof(GreenLightDetailPage));
            Routes.Add("familydetails", typeof(GreenFamilyDetailPage));
            Routes.Add("pasturedetails", typeof(PastureDetailPage));
            Routes.Add("handdetails", typeof(HandMakeDetailPage));

            Routes.Add("ComebuyFruitdetails", typeof(ComebuyFruitDetailPage));
            Routes.Add("ComebuyFruitteadetails", typeof(ComebuyFruitteaDetailPage));
            Routes.Add("ComebuyMilkteadetails", typeof(ComebuyMilkteaDetailPage));
            Routes.Add("ComebuyNaturemilkteadetails", typeof(ComebuyNaturemilkteaDetailPage));
            Routes.Add("ComebuySummerspecialdetails", typeof(ComebuySummerspecialDetailPage));
            Routes.Add("ComebuyWinterspecialdetails", typeof(ComebuyWinterspecialDetailPage));
            Routes.Add("ComebuyTeadetails", typeof(ComebuyTeaDetailPage));


            foreach (var item in Routes)
            {
                Routing.RegisterRoute(item.Key, item.Value);
            }
        }
    }
}
