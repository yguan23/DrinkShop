using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    
    public static class TeaCow
    {
        public static IList<Drink> TeaData { get; private set; }

        static TeaCow() 
        {
            //愛茶的牛
            TeaData = new List<Drink>();

            TeaData.Add(new Drink
            {
                Name = "娜杯紅茶",
                Introduction = "特選自斯里蘭卡中低海拔盧哈娜茶葉產區，得天獨厚的氣候造就厚實的紅茶風味，單茶酌飲茶香獨特，餘韻持久，口感清爽不甜膩。",
                Price = "L 35",
                SizeM = "0",
                SizeL = "35",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2111090902160000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "英倫伯爵紅茶",
                Introduction = "選用印度的阿薩姆紅茶，搭配斯里蘭卡的錫蘭紅茶茶味濃郁 加入佛手柑薰香，獨有的奔放果香風味，果香獨特",
                Price = "L 35",
                SizeM = "0",
                SizeL = "35",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091322430000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "大正醇香紅茶",
                Introduction = "選用阿薩姆紅茶，偏古早味紅茶帶點清新木質香氣，風味柔順",
                Price = "L 35",
                SizeM = "0",
                SizeL = "35",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091151450000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "焙香決明大麥",
                Introduction = "一般對麥茶的印象大多是清爽或炭焙香氣，但迷客夏的麥茶，加了決明子！決明子與麥茶融合後，增添整體的香氣、風味更加豐富與圓潤層次!",
                Price = "L 30",
                SizeM = "0",
                SizeL = "30",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091152330000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "原片初露青茶",
                Introduction = "選用台灣原片青茶，滋味淡雅清香，圓潤清甜",
                Price = "L 30",
                SizeM = "0",
                SizeL = "30",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091151560000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "琥珀高峰烏龍",
                Introduction = "帶炭焙香氣，口感清爽溫潤甘甜",
                Price = "L 30",
                SizeM = "0",
                SizeL = "30",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091152200000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "茉莉原淬綠茶",
                Introduction = "綠茶帶有清新茉莉花香，入口後滋味清盈不澀口",
                Price = "L 30",
                SizeM = "0",
                SizeL = "30",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/1908091133330000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "原鄉冬瓜茶",
                Introduction = "門市手工熬煮冬瓜糖液，入口柔順",
                Price = "L 30",
                SizeM = "0",
                SizeL = "30",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090839010000001.png&w=307&zc=2"
            });
            TeaData.Add(new Drink
            {
                Name = "青採翠玉",
                Introduction = "選用南投杉林溪-青心烏龍，淺焙烏龍，茶味圓潤，尾韻甘甜",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                ImageUrl = "https://www.milkshoptea.com/includes/timthumb.php?src=upload/product/2104090841150000001.png&w=307&zc=2"
            });
        }

    }
}
