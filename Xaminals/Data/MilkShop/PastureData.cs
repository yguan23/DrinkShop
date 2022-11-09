using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class PastureData
    {
        public static IList<Drink> Pasture { get; private set; }

        static PastureData()
        {
            //牧場鮮奶茶
            Pasture = new List<Drink>();

            Pasture.Add(new Drink
            {
                Name = "布朗紅茶拿鐵",
                Introduction = "門市手炒黑糖，特殊濃郁焦香，搭配經典大正紅茶及綠光鮮奶調製鮮奶茶，透過特殊漩茶技術，讓黑糖更為撲鼻誘人卻不膩口！",
                Price = "M 55/L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2111090904520000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "伯爵可可拿鐵",
                Introduction = "用五星主廚指定的法國頂級「法芙娜100%純可可」，與帶有佛手柑香氣的伯爵拿鐵融合，呈現可可香濃滋味及果香尾韻。",
                Price = "M 55/L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2111090905190000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "娜杯紅茶拿鐵",
                Introduction = "特選自斯里蘭卡中低海拔盧哈娜茶葉產區，添加迷客夏自家綠光牧場的鮮乳製成，特製的調飲比例讓盧哈娜紅茶與鮮奶風味達到完美平衡，奶味不失濃郁醇香，帶有些許焦糖香氣滑潤順口！",
                Price = "M 50/L 60",
                SizeM = "50",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2111090903440000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "伯爵紅茶拿鐵",
                Introduction = "使用帶果香(佛手柑)的伯爵紅茶搭配綠光鮮奶，茶香濃郁口感醇厚",
                Price = "M 50/L 60",
                SizeM = "50",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091153440000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "大正紅茶拿鐵",
                Introduction = "使用自家綠光牧場鮮奶搭配古早味大正紅茶，帶有香草香氣和濃醇奶香",
                Price = "M 50/L 60",
                SizeM = "50",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091153510000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "焙香大麥拿鐵",
                Introduction = "無咖啡因的決明子與麥茶融合，再搭配自家綠光牧場鮮奶，增添整體的香氣、風味更加豐富與圓潤層次！",
                Price = "M 45/L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090847450000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "茉香綠茶拿鐵",
                Introduction = "用茉香綠茶搭配自家綠光牧場鮮奶，清新茉莉花香，滋味清爽順口",
                Price = "M 45/L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090849110000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "琥珀烏龍拿鐵",
                Introduction = "高峰烏龍茶搭配自家綠光牧場鮮奶，口感柔順、氣息層次豐富，且具有炭焙香",
                Price = "M 45/L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090848510000001.png&w=307&zc=2"
            });

            Pasture.Add(new Drink
            {
                Name = "醲農紅茶鮮豆奶",
                Introduction = "大正紅茶清爽，融合香濃豆漿 採用台灣國產非基改黃豆，香氣厚實有延續性，茶味尾韻帶有豆香，非常適合素食者與健康概念族群。",
                Price = "L 55",
                SizeM = "0",
                SizeL = "55",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090850470000001.png&w=307&zc=2"
            });

        }
    }
}


