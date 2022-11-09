using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class AbsolutelyRecommend
    {
        public static IList<Drink> Absolutely { get; private set; }

        static AbsolutelyRecommend()
        {
            //嚼對推薦
            Absolutely = new List<Drink>();

            Absolutely.Add(new Drink
            {
                Name = "珍珠紅茶拿鐵",
                Introduction = "迷客夏招牌飲品，使用自家綠光牧場鮮奶調配而成的鮮奶茶，搭配手工熬煮珍珠，軟Q彈牙！",
                Price = "M 60/L 70",
                SizeM = "60",
                SizeL = "70",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104061441570000001.png&w=307&zc=2"
            });
            Absolutely.Add(new Drink
            {
                Name = "蜜Q茉香拿鐵",
                Introduction = "",
                Price = "M 75/L 85",
                SizeM = "75",
                SizeL = "85",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104081554070000001.png&w=307&zc=2"
            });
            Absolutely.Add(new Drink
            {
                Name = "蜜Q大麥拿鐵",
                Introduction = "",
                Price = "M 75/L 85",
                SizeM = "75",
                SizeL = "85",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104081554070000001.png&w=307&zc=2"
            });
            Absolutely.Add(new Drink
            {
                Name = "芋園茉香綠茶拿鐵",
                Introduction = "Q彈小芋圓與茉香綠茶拿鐵的絕佳搭配，讓你一口接著一口停不下來",
                Price = "M 60/L 70",
                SizeM = "60",
                SizeL = "70",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104081554490000001.png&w=307&zc=2"
            });
            Absolutely.Add(new Drink
            {
                Name = "手感芋園芋泥鮮奶",
                Introduction = "芋頭控的最愛！！Q彈小芋圓搭配招牌芋頭鮮奶，還能吃得到芋泥顆粒，香甜有飽足感",
                Price = "M 75/L 95",
                SizeM = "75",
                SizeL = "95",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104081555270000001.png&w=307&zc=2"
            });
            Absolutely.Add(new Drink
            {
                Name = "珍珠手炒黑糖鮮奶",
                Introduction = "門市手工熬煮黑糖，清甜焦香不膩口搭配自家綠光鮮奶以及珍珠，口感豐富",
                Price = "M 70/L 90",
                SizeM = "70",
                SizeL = "90",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104081556130000001.png&w=307&zc=2"
            });
            Absolutely.Add(new Drink
            {
                Name = "雙Q琥珀烏龍拿鐵",
                Introduction = "珍珠加上芋圓，給你雙重豐富口感，搭配香醇烏龍拿鐵，口感柔順、氣息層次豐富，且具有炭焙香。",
                Price = "L 80",
                SizeM = "0",
                SizeL = "80",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104081557230000001.png&w=307&zc=2"
            });
            Absolutely.Add(new Drink
            {
                Name = "仙草凍冬瓜茶",
                Introduction = "小火慢熬軟嫩滑溜的嫩仙草咀嚼間帶有微微仙草甘味與冬瓜茶的滑順香甜感",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104081557590000001.png&w=307&zc=2"
            });
        }
    }
}
