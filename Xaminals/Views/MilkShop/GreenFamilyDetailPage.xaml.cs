using System;
using System.Linq;

using Xamarin.Forms;
using Xaminals.Controls;
using Xaminals.Models;

namespace Xaminals.Views
{
    [QueryProperty(nameof(Name), "name")]
    public partial class GreenFamilyDetailPage : ContentPage
    {
        public GreenFamilyDetailPage()
        {
            InitializeComponent();
        }
        public string Name
        {
            set
            {
                LoadDrink(value);
            }
        }
        public String DrinkName;
        public String DrinkMoreInfo;
        public String DrinkNum;
        bool click = false;

        void LoadDrink(string name)
        {
            try
            {
                Drink drink = Data.GreenFamily.Family.FirstOrDefault(a => a.Name == name);
                BindingContext = drink;
                DrinkName = name;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load drink.");
            }
        }

        private void buy(object sender, EventArgs e)
        {
            if (quantity.Text == "0")
            {
                DisplayAlert("警告", "請輸入數量", "確認");
            }
            else
            {
                lblshow.Text = (int.Parse(lblshow.Text) * int.Parse(quantity.Text)).ToString();
                DisplayAlert("通知", "加入成功！", "確認");
                DrinkMoreInfo = moreinfo.Text;
                DrinkNum = quantity.Text;
                click = true;
            }
        }

        public class OrderModel
        {
            public String Name { get; set; }
            public String Price { get; set; }
            public String Info { get; set; }
            public String MoreInfo { get; set; }
            public String Num { get; set; }
        }

        async private void ShoppingCart_Clicked(object sender, EventArgs e)
        {
            if (click == true)
            {
                var shoppingcart = new ShoppingCartPage();
                shoppingcart.BindingContext = new OrderModel()
                {
                    Name = DrinkName,
                    Price = lblshow.Text,
                    MoreInfo = DrinkMoreInfo,
                    Num = DrinkNum,
                };
                await Navigation.PushAsync(shoppingcart);
            }
        }
    }
}