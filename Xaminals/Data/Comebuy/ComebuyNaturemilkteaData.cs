using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ComebuyNaturemilkteaData
    {
        public static IList<Drink> ComebuyNaturemilktea { get; private set; }
        static ComebuyNaturemilkteaData()
        {
            ComebuyNaturemilktea = new List<Drink>();
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "絕代雙Q奶茶",
                Price = "M 55/L 60",
                SizeM = "55",
                SizeL = "60",
                Introduction = "【+15元升級鮮奶】香醇奶茶加入珍珠X芋圓&薯圓X粉條2選1任消費者選擇，一次享受雙重Q彈口感，顛覆以往的經典風味。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_47.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "招牌奶茶",
                Price = "M 45/L 50",
                SizeM = "45",
                SizeL = "50",
                Introduction = "採用世界第一品牌奶精，搭配錫蘭紅茶，並用專屬COMEBUY的黃金比例調製，使用蔗糖與紅蔗糖，品嚐甜潤繞口的奶茶。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_8.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "黃金奶綠",
                Price = "M 45/L 50",
                SizeM = "45",
                SizeL = "50",
                Introduction = "採用世界第一品牌奶精，搭配獨門醺香的黃金綠茶，用專屬COMEBUY的黃金比例調製，帶給你綠茶清爽與牛奶香醇的完美組合。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_9.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "珍珠奶茶",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "擁有紅茶甜潤與牛奶香醇的招牌奶茶內，加入口感彈Q略帶焦糖香的珍珠，豐富的口味搭配，帶給你口齒間最滿足的享受。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_10.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "鮮萃大麥奶茶",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                Introduction = "大麥煎焙炒香搭配柔滑奶香、 組合完美口感。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_89.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "海神奶茶",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【半糖以上風味最佳】獨特日式煎茶調製奶茶，淡淡蜂蜜清香，讓奶茶清爽不膩。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_64.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "玩火奶茶",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                Introduction = "日本靜岡甘甜的煎茶與產自春天高山上的清香烏龍茶調製奶茶，富有熱帶水果香氣與淡淡蘭花香，讓奶茶風味獨特又清爽不膩。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_94.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "玫瑰普洱奶茶",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                Introduction = "有美容茶之聲譽，嚴選優質普洱為基底，搭配玫瑰入味，調製成的時尚奶茶，滋味醇厚回甘具獨特的陳香完美組合。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_98.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "粉條奶茶",
                Price = "M 55/L 60",
                SizeM = "55",
                SizeL = "60",
                Introduction = "擁有紅茶甜潤與牛奶香醇的招牌奶茶內，加入口感Q彈香甜的粉條，老朋友都知道的好味道，給你口齒間最滿足的享受。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_95.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "仙草凍奶茶",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "以滑Q順口的關西仙草凍，加入擁有紅茶甜潤與牛奶香醇的招牌奶茶，利用仙草的甘澀，帶給奶茶另一種甜而不膩的滋味，並讓你享受到大口爽快的仙草躍動。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_11.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "桂花奶綠",
                Price = "M 60/L 65",
                SizeM = "60",
                SizeL = "65",
                Introduction = "【只有加桂花蜜，無另外加糖】桂花香氣與黃金奶綠的甘甜韻味融合，清新淡雅甜蜜柔和。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_102.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "港式厚奶",
                Price = "M 70",
                SizeM = "70",
                SizeL = "0",
                Introduction = "【M-450cc｜半糖以上風味最佳 | 加料後因改為大杯裝故會有不滿杯情況】香港國民聖飲，嚴選淡奶與錫蘭紅茶調製，與眾不同的經典口感，帶出香醇濃厚的絕妙滋味。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_65.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "觀音厚奶",
                Price = "M 70",
                SizeM = "70",
                SizeL = "0",
                Introduction = "【新品同步上市】M-450cc｜甜度建議半糖以上 | 嚴選淡奶與熟倉觀音調製為香氣熟運、奶香濃厚的奶茶 | 加料後因改為大杯裝故會有不滿杯情況",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_101.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "經典可可",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "精選五星級餐廳專用巧克力調製而成，入口剎那同時享受巧克力的香濃，讓你沉溺於被稱為〝眾神的飲料〞專屬於巧克力的幸福與滿足。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_12.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "宇治抹茶",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                Introduction = "特選宇治抹茶，香氣濃郁、香醇口感，極致口感邂逅味蕾上的小京都。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_84.jpg"
            });
            ComebuyNaturemilktea.Add(new Drink
            {
                Name = "抹茶拿鐵",
                Price = "L 80",
                SizeM = "0",
                SizeL = "80",
                Introduction = "京都宇治抹茶加入鮮奶，享受迷人翠綠風味與白色醇厚的極致口感。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_85.jpg"
            });

        }
    }
}
