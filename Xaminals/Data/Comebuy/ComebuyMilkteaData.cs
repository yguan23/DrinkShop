using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ComebuyMilkteaData
    {
        public static IList<Drink> ComebuyMilktea { get; private set; }
        static ComebuyMilkteaData()
        {
            ComebuyMilktea = new List<Drink>();
            ComebuyMilktea.Add(new Drink
            {
                Name = "紅茶拿鐵",
                Price = "M 60/L 65",
                SizeM = "60",
                SizeL = "65",
                Introduction = "【半糖以上風味最佳】現泡烏瓦紅茶加上香醇鮮乳調製而成，濃郁茶香略帶花香，更增添鮮乳的香甜，是愛好奶茶且注重健康的首選。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_13.jpg"
            });
            ComebuyMilktea.Add(new Drink
            {
                Name = "烏龍拿鐵",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【100%台灣茶｜半糖以上風味最佳】百年茶廠烘焙出的烏龍綠茶，加上濃郁的鮮乳調製而成，煙燻口感適合重口味的你。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_14.jpg"
            });
            ComebuyMilktea.Add(new Drink
            {
                Name = "金萱拿鐵",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【半糖以上風味最佳】微微甘甜，淡淡奶香的金色茶湯，加上香醇鮮奶更添濃郁多層次味蕾享受。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_74.jpg"
            });
            ComebuyMilktea.Add(new Drink
            {
                Name = "觀音拿鐵",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【100%台灣茶｜半糖以上風味最佳】熟滄觀音融入香醇鮮奶，滋味醇厚甘鮮，入口回甘喉韻強。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_75.jpg"
            });
            ComebuyMilktea.Add(new Drink
            {
                Name = "玫瑰普洱拿鐵",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "有美容茶之聲譽，嚴選優質普洱為基底，搭配玫瑰入味，與鮮奶的完美融合，口感香醇又回甘。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_99.jpg"
            });
        }
    }
}
