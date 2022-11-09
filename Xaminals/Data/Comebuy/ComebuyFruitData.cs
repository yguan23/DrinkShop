using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ComebuyFruitData
    {
        public static IList<Drink> ComebuyFruit { get; private set; }
        static ComebuyFruitData()
        {
            ComebuyFruit = new List<Drink>();
            ComebuyFruit.Add(new Drink
            {
                Name = "超桔霸氣飲",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "【甜度固定】金桔原汁與化應子等多種溫性草本組成，溫潤順喉、開胃爽口的漢方養氣茶飲，酸甜口感簡單無負擔。",
                ImageUrl= "https://cf.shopee.tw/file/61ab55e48d6a2573acb65be7a48c653c"
            });
            ComebuyFruit.Add(new Drink
            {
                Name = "蜂蜜蘆薈",
                Price = "M 45/L 50",
                SizeM = "45",
                SizeL = "50",
                Introduction = "【冰飲｜只有加蜂蜜，無另外加糖】優質蜂蜜搭配爽口蘆薈果肉，無另外加糖，糖度調整為蜂蜜多寡。夏日輕盈風味又清爽的飲品。因含有蘆薈，孕婦忌食。｜!不建議經期、懷孕或哺乳期婦女、12歲以下孩童、腸胃不適、腹痛患者及腎臟病患者使用",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_24.jpg"
            });
            ComebuyFruit.Add(new Drink
            {
                Name = "金桔檸檬",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "新鮮金桔與檸檬原汁結合，含豐富維他命C，冰冰喝清新爽快，熱飲有潤喉的功效，可以舒緩咳嗽。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_27.jpg"
            });
            ComebuyFruit.Add(new Drink
            {
                Name = "荔枝玉露",
                Price = "M 50/L55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "【冰飲】香甜清爽的荔汁果汁搭配獨家荔枝凍，含有豐富維生素，清香甜蜜的消暑水果飲品。不適合體熱者飲用。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_54.jpg"
            });
            ComebuyFruit.Add(new Drink
            {
                Name = "纖美小紫蘇",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【冰飲】玫瑰果露加上新鮮桔汁，搭配愛玉及小紫蘇，低卡清爽，卻有飽足感。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_53.jpg"
            });
            ComebuyFruit.Add(new Drink
            {
                Name = "芭樂多多",
                Price = "M 65/L 85",
                SizeM = "65",
                SizeL = "85",
                Introduction = "【冰飲｜冰量固定】清香芭樂、檸檬與香甜養樂多的合拍搭配，誘人酸甜愛不釋手，喝得到芭樂新鮮好滋味，多C好氣色。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_51.jpg"
            });
        }
    }
}

