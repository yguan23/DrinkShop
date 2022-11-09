using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class GreenFamily
    {
        public static IList<Drink> Family { get; private set; }

        static GreenFamily()
        {
            Family = new List<Drink>();

            Family.Add(new Drink
            {
                Name = "綠光鮮奶家庭號",
                Introduction = "",
                Price = "160",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090903520000001.png&w=307&zc=2"
            });
            Family.Add(new Drink
            {
                Name = "綠光鮮奶小資瓶",
                Introduction = "",
                Price = "90",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090903520000001.png&w=307&zc=2"
            });
            Family.Add(new Drink
            {
                Name = "小迷無加糖豆漿",
                Introduction = "無加糖、天然無負擔 入口就能感受到香醇黃豆香。選用 100 % 台灣國產非基改履歷黃豆，48小時內完成產季採收、 乾燥篩選、分裝冰存等製作流程。",
                Price = "89",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090903520000001.png&w=307&zc=2"
            });
        }
    }
}