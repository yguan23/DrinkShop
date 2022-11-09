using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ComebuyFruitteaData
    {
        public static IList<Drink> ComebuyFruittea { get; private set; }
        static ComebuyFruitteaData()
        {
            ComebuyFruittea = new List<Drink>();
            ComebuyFruittea.Add(new Drink
            {
                Name = "錫蘭紅茶",
                Price = "M 25/L 30",
                SizeM = "25",
                SizeL = "30",
                Introduction = "選用斯里蘭卡香醇的錫蘭紅茶，洋溢著花果清香，適合清飲，在下午茶及用過味道濃郁的大餐後，最適宜飲此茶。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_16.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "茉莉綠茶",
                Price = "M 25/L 30",
                SizeM = "25",
                SizeL = "30",
                Introduction = "獨創九次薰香，茶湯清新香醇，喉韻甘潤，清爽宜人。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_17.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "蜂蜜紅茶",
                Price = "M 45/L 50",
                SizeM = "45",
                SizeL = "50",
                Introduction = "【冰飲 | 只有加蜂蜜，無另外加糖】錫蘭紅茶使用優質蜂蜜，無另外加糖，糖度調整為蜂蜜多寡。(因蜂蜜的特性不建議易過敏或5歲以下孩童飲用)",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_18.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "蜂蜜綠茶",
                Price = "M 45/L 50",
                SizeM = "45",
                SizeL = "50",
                Introduction = "【冰飲｜只有加蜂蜜，無另外加糖】黃金綠茶使用優質蜂蜜，無另外加糖，糖度調整為蜂蜜多寡。(因蜂蜜的特性不建議易過敏或5歲以下孩童飲用)",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_17.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "玉荷冰綠",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "獨家荔枝汁加上清香淡雅的茉莉綠茶。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_80.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "檸檬冰茶",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "新鮮檸檬原汁配上錫蘭紅茶/黃金綠茶，檸檬含有豐富維他命C，非常適合經常外食的上班族。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_50.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "梅果茶",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "嚴選台灣南投信義鄉梅果調製而成，獨家梅汁配方平衡體內酸性，酸甜解渴，助消化。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_59.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "養樂多綠茶",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "【冰飲】養樂多配上黃金綠茶，含豐富乳酸菌，可以整腸健胃。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_20.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "百香搖果樂",
                Price = "M 55/L 60",
                SizeM = "55",
                SizeL = "60",
                Introduction = "【冰飲】清爽香甜的百香果綠茶搭配獨家荔枝凍、椰果、珍珠，呈現豐富多層次的口感。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_55.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "蘋果冰茶",
                Price = "M 55/L 60",
                SizeM = "55",
                SizeL = "60",
                Introduction = "【冰飲】蘋果果露加上新鮮檸檬汁，搭配嚼勁十足的寒天晶球，呈現蘋果甜味中略帶微酸的絕佳口感。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_49.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "鳳梨冰茶",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【冰飲｜少糖以上風味最佳】嚴選台灣鳳梨加入茉莉綠茶，酸甜果香茶香，調製解暑誘人時尚茶飲。| 因飲品風味考量不建議做去冰",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_38.jpg"
            });
            ComebuyFruittea.Add(new Drink
            {
                Name = "芭樂檸檬綠",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【冰飲｜半糖以上風味最佳】結合芭樂、檸檬與綠茶的完美混搭，層次豐富的水果香氣和清爽的口感讓人心曠神怡。| 因飲品風味考量不建議做去冰",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_76.jpg"
            });


        }
    }
}
