using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class GreenLight
    {
        public static IList<Drink> GreenData { get; private set; }

        static GreenLight()
        {
            //綠光牧場鮮奶
            GreenData = new List<Drink>();

            GreenData.Add(new Drink
            {
                Name = "手炒黑糖鮮奶",
                Introduction = "門市手工炒製的黑糖，清甜焦香不膩口搭配自家綠光鮮奶，香醇可口",
                Price = "M 60",
                SizeM="60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091155410000001.png&w=307&zc=2"
            });
            GreenData.Add(new Drink
            {
                Name = "嫩仙草凍奶",
                Introduction = "純淨鮮奶搭配小火慢熬，軟嫩滑溜的嫩仙草，咀嚼間帶有微微仙草甘味與鮮奶的滑順香甜感。",
                Price = "M 60",
                SizeM = "60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908161525260000001.png&w=307&zc=2"
            });
            GreenData.Add(new Drink
            {
                Name = "法芙娜純可可鮮奶",
                Introduction = "選用法芙娜(Valrhona) 100%純可可，法芙娜被譽為可可界的愛馬仕，通常以殿堂級來形容法芙娜可可的品質和地位。",
                Price = "M 60",
                SizeM = "60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091155500000001.png&w=307&zc=2"
            });
            GreenData.Add(new Drink
            {
                Name = "布丁鮮奶",
                Introduction = "手工熬煮的布丁，口感Q彈紮實，帶有糕點香甜氣息咀嚼間帶有淡淡焦糖香氣與鮮奶融合的香甜感。",
                Price = "M 60",
                SizeM = "60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091407120000001.png&w=307&zc=2"
            });
            GreenData.Add(new Drink
            {
                Name = "珍珠鮮奶",
                Introduction = "門市手工熬煮的珍珠，以蜂蜜蜜漬軟Q彈牙",
                Price = "M 65",
                SizeM = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091154110000001.png&w=307&zc=2"
            });
            GreenData.Add(new Drink
            {
                Name = "芋頭鮮奶",
                Introduction = "迷客夏招牌經典飲品！選用台灣特級品種並只取風味最佳的中段，口感鬆軟綿密，香氣濃郁！",
                Price = "M 65",
                SizeM = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090902560000001.png&w=307&zc=2"
            });
            GreenData.Add(new Drink
            {
                Name = "手感芋園鮮奶",
                Introduction = "Q彈小芋圓，搭配自家綠光鮮奶，香甜有飽足感唷",
                Price = "M 70",
                SizeM = "70",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090857020000001.png&w=307&zc=2"
            });
        }
    }
}
