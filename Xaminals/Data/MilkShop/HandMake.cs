using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class HandMake
    {
        public static IList<Drink> HandData { get; private set; }

        static HandMake()
        {
            //手作特調
            HandData = new List<Drink>();

            HandData.Add(new Drink
            {
                Name = "蜂蜜檸檬晶凍",
                Introduction = "",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090915340000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "阿文鮮梅綠",
                Introduction = "迷客夏粉絲們最愛的夏日飲料，酸甜口感超清爽又解渴！",
                Price = "L 55",
                SizeM = "0",
                SizeL = "55",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090907080000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "阿文檸7",
                Introduction = "結合純釀阿文梅露、爽口七喜、新鮮檸片，入口可以感受到氣泡沁涼暢快的爽口，和新鮮檸檬片的酸香濃郁，尾韻帶有清新梅子的鹹甘甜！",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090907080000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "冰糖洛神梅",
                Introduction = "手工以洛神花、冰糖及烏梅熬煮， 酸甜不膩口",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090914180000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "水漾檸紅",
                Introduction = "以檸檬酸香為主體，搭配佛手柑香氣，尾韻細長、清新順口。",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090916150000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "水漾檸綠",
                Introduction = "以檸檬香氣為主體，搭配茉莉花香，整體清爽順口，尾韻帶出話梅甘甜，增添風味層次。",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090917000000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "冬瓜麥茶",
                Introduction = "結合冬瓜及麥茶兩者風味，以麥茶輕爽感受修飾冬瓜甜膩，兩種原物料風味完美融合，更添飲品層次。",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090907080000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "冬瓜檸檬",
                Introduction = "門市手工熬煮的冬瓜糖液，加上100%檸檬原汁，台灣人熟悉的味道，酸甜不膩口",
                Price = "L 45",
                SizeM = "0",
                SizeL = "45",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090913260000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "冬瓜青茶",
                Introduction = "門市手工熬煮冬瓜糖液搭配青茶，清甜不膩口",
                Price = "L 45",
                SizeM = "0",
                SizeL = "45",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090909250000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "白甘蔗青茶",
                Introduction = "選用台灣南投100%白甘蔗原汁，搭配HPP冷壓殺菌技術處理，讓甘蔗原汁衛生安全無虞又保有原始風味。",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090923140000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "養樂多綠",
                Introduction = "茉莉原淬綠茶搭配養樂多多，清甜微酸 清爽無負擔",
                Price = "L 45",
                SizeM = "0",
                SizeL = "45",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090921050000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "香柚綠茶",
                Introduction = "萄柚熬製成果露，搭配綠茶，柑橘氣息，微酸微苦",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090920230000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "冰萃檸檬",
                Introduction = "採用100%檸檬原汁，選用當季鮮果榨汁、冷凍保存。獨特殺菌處理，達國家安全衛生標準，呈現鮮採檸檬原汁風味。",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091315060000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "冰萃柳丁",
                Introduction = "入口柳丁清新柑橘香氣帶有蜜香，碎冰口感清爽沁涼果茶風味，更沁涼消暑 選用台南(南化水庫以北，嘉義以南)100%當季柳丁鮮果原汁、冷凍保存。",
                Price = "L 55",
                SizeM = "0",
                SizeL = "55",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090918220000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "青檸香茶",
                Introduction = "青檸香茶是迷客夏特色飲品之一現削檸檬皮與綠茶雪克，帶出檸檬清香",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090919210000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "柳丁綠茶",
                Introduction = "使用台灣100%柳丁原汁搭配甘醇茶湯，喝得到柳丁果肉柳丁柑橘清香帶出淡淡果甜氣息，融合出鮮爽的果茶滋味，滋味清甜酸香",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091314530000001.png&w=307&zc=2"
            });
            HandData.Add(new Drink
            {
                Name = "柳丁青茶",
                Introduction = "",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090923140000001.png&w=307&zc=2"
            });
        }
    }
}
