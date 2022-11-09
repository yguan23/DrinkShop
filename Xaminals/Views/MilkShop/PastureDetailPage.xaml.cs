using System;
using System.Linq;

using Xamarin.Forms;
using Xaminals.Controls;
using Xaminals.Models;

namespace Xaminals.Views
{
    [QueryProperty(nameof(Name), "name")]
    public partial class PastureDetailPage : ContentPage
    {
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

        public PastureDetailPage()
        {
            InitializeComponent();
        }
        void LoadDrink(string name)
        {
            try
            {
                Drink drink = Data.PastureData.Pasture.FirstOrDefault(a => a.Name == name);
                BindingContext = drink;
                DrinkName = name;
            }
            catch (Exception)
            {
                Console.WriteLine("Failed to load drink.");
            }
        }

        public int price = 0;

        private void sizeM(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (lblSizem.Text != "0")
            {
                if (sizel.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    sizel.BackgroundColor = Color.FromHex("#dddddd");
                    price -= int.Parse(lblSizel.Text);
                    lblshow.Text = price.ToString();
                    content.BackgroundColor = Color.FromHex("#0000ff");
                    price += int.Parse(lblSizem.Text);
                    lblshow.Text = price.ToString();
                }
                else
                {
                    if (content.BackgroundColor == Color.FromHex("#dddddd"))
                    {
                        content.BackgroundColor = Color.FromHex("#0000ff");
                        price += int.Parse(lblSizem.Text);
                        lblshow.Text = price.ToString();
                    }
                    else
                    {
                        content.BackgroundColor = Color.FromHex("#dddddd");
                        price -= int.Parse(lblSizem.Text);
                        lblshow.Text = price.ToString();
                    }
                }
            }
        }

        private void sizeL(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (sizel.Text != "0")
            {
                if (sizem.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    sizem.BackgroundColor = Color.FromHex("#dddddd");
                    price -= int.Parse(lblSizem.Text);
                    lblshow.Text = price.ToString();
                    content.BackgroundColor = Color.FromHex("#0000ff");
                    price += int.Parse(lblSizel.Text);
                    lblshow.Text = price.ToString();
                }
                else
                {
                    if (content.BackgroundColor == Color.FromHex("#dddddd"))
                    {
                        content.BackgroundColor = Color.FromHex("#0000ff");
                        price += int.Parse(lblSizel.Text);
                        lblshow.Text = price.ToString();
                    }
                    else
                    {
                        content.BackgroundColor = Color.FromHex("#dddddd");
                        price -= int.Parse(lblSizel.Text);
                        lblshow.Text = price.ToString();
                    }
                }
            }
        }

        private void ice1_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                ice2.BackgroundColor = Color.FromHex("#dddddd");
                ice3.BackgroundColor = Color.FromHex("#dddddd");
                ice4.BackgroundColor = Color.FromHex("#dddddd");
                ice5.BackgroundColor = Color.FromHex("#dddddd");
                ice6.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void ice2_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                ice1.BackgroundColor = Color.FromHex("#dddddd");
                ice3.BackgroundColor = Color.FromHex("#dddddd");
                ice4.BackgroundColor = Color.FromHex("#dddddd");
                ice5.BackgroundColor = Color.FromHex("#dddddd");
                ice6.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void ice3_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                ice2.BackgroundColor = Color.FromHex("#dddddd");
                ice1.BackgroundColor = Color.FromHex("#dddddd");
                ice4.BackgroundColor = Color.FromHex("#dddddd");
                ice5.BackgroundColor = Color.FromHex("#dddddd");
                ice6.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void ice4_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                ice2.BackgroundColor = Color.FromHex("#dddddd");
                ice3.BackgroundColor = Color.FromHex("#dddddd");
                ice1.BackgroundColor = Color.FromHex("#dddddd");
                ice5.BackgroundColor = Color.FromHex("#dddddd");
                ice6.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void ice5_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                ice2.BackgroundColor = Color.FromHex("#dddddd");
                ice3.BackgroundColor = Color.FromHex("#dddddd");
                ice4.BackgroundColor = Color.FromHex("#dddddd");
                ice1.BackgroundColor = Color.FromHex("#dddddd");
                ice6.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void ice6_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                ice2.BackgroundColor = Color.FromHex("#dddddd");
                ice3.BackgroundColor = Color.FromHex("#dddddd");
                ice4.BackgroundColor = Color.FromHex("#dddddd");
                ice5.BackgroundColor = Color.FromHex("#dddddd");
                ice1.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void sugar1_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                sugar2.BackgroundColor = Color.FromHex("#dddddd");
                sugar3.BackgroundColor = Color.FromHex("#dddddd");
                sugar4.BackgroundColor = Color.FromHex("#dddddd");
                sugar5.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void sugar2_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                sugar1.BackgroundColor = Color.FromHex("#dddddd");
                sugar3.BackgroundColor = Color.FromHex("#dddddd");
                sugar4.BackgroundColor = Color.FromHex("#dddddd");
                sugar5.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void sugar3_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                sugar2.BackgroundColor = Color.FromHex("#dddddd");
                sugar1.BackgroundColor = Color.FromHex("#dddddd");
                sugar4.BackgroundColor = Color.FromHex("#dddddd");
                sugar5.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void sugar4_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                sugar2.BackgroundColor = Color.FromHex("#dddddd");
                sugar3.BackgroundColor = Color.FromHex("#dddddd");
                sugar1.BackgroundColor = Color.FromHex("#dddddd");
                sugar5.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void sugar5_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                sugar2.BackgroundColor = Color.FromHex("#dddddd");
                sugar3.BackgroundColor = Color.FromHex("#dddddd");
                sugar4.BackgroundColor = Color.FromHex("#dddddd");
                sugar1.BackgroundColor = Color.FromHex("#dddddd");
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
            }
        }

        private void extra1_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                price += 10;
                lblshow.Text = price.ToString();
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
                price -= 10;
                lblshow.Text = price.ToString();
            }
        }

        private void extra5_Clicked(object sender, EventArgs e)
        {
            var content = (Button)sender;
            if (content.BackgroundColor == Color.FromHex("#dddddd"))
            {
                content.BackgroundColor = Color.FromHex("#0000ff");
                price += 15;
                lblshow.Text = price.ToString();
            }
            else
            {
                content.BackgroundColor = Color.FromHex("#dddddd");
                price -= 15;
                lblshow.Text = price.ToString();
            }
        }

        private void buy(object sender, EventArgs e)
        {
            if ((sizem.BackgroundColor == Color.FromHex("#dddddd") & 
                sizel.BackgroundColor == Color.FromHex("#dddddd")) |
                (ice1.BackgroundColor == Color.FromHex("#dddddd") & 
                ice2.BackgroundColor == Color.FromHex("#dddddd") & 
                ice3.BackgroundColor == Color.FromHex("#dddddd") & 
                ice4.BackgroundColor == Color.FromHex("#dddddd") &
                ice5.BackgroundColor == Color.FromHex("#dddddd") &
                ice6.BackgroundColor == Color.FromHex("#dddddd")) |
                (sugar1.BackgroundColor == Color.FromHex("#dddddd") &
                sugar2.BackgroundColor == Color.FromHex("#dddddd") & 
                sugar3.BackgroundColor == Color.FromHex("#dddddd") & 
                sugar4.BackgroundColor == Color.FromHex("#dddddd") & 
                sugar5.BackgroundColor == Color.FromHex("#dddddd")) |
                quantity.Text == "0")
            {
                DisplayAlert("警告", "大小，數量，冰塊，甜度請填妥", "確認");
            }
            else
            {
                if (sizel.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text += "大杯 ";
                }
                else
                {
                    totalinfo.Text += "小杯 ";
                }
                if (ice1.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + ice1.Text + " ";
                }
                if (ice2.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + ice2.Text + " ";
                }
                if (ice3.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + ice3.Text + " ";
                }
                if (ice4.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + ice4.Text + " ";
                }
                if (ice5.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + ice5.Text + " ";
                }
                if (sugar1.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + sugar1.Text + " ";
                }
                if (sugar2.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + sugar2.Text + " ";
                }
                if (sugar3.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + sugar3.Text + " ";
                }
                if (sugar4.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + sugar4.Text + " ";
                }
                if (sugar5.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + sugar5.Text + " ";
                }
                if (extra1.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + extra1.Text + " ";
                }
                if (extra2.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + extra2.Text + " ";
                }
                if (extra3.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + extra3.Text + " ";
                }
                if (extra4.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + extra4.Text + " ";
                }
                if (extra5.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + extra5.Text + " ";
                }
                if (extra6.BackgroundColor == Color.FromHex("#0000ff"))
                {
                    totalinfo.Text = totalinfo.Text + extra6.Text + " ";
                }
                price *= int.Parse(quantity.Text);
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
                    Price = price.ToString(),
                    Info = totalinfo.Text,
                    MoreInfo = DrinkMoreInfo,
                    Num = DrinkNum,
                };
                await Navigation.PushAsync(shoppingcart);
            }
        }
    }
}