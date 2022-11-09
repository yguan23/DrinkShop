using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ComebuyTeaData
    {
        public static IList<Drink> ComebuyTea { get; private set; }
        static ComebuyTeaData()
        {
            ComebuyTea = new List<Drink>();
            ComebuyTea.Add(new Drink
            {
                Name = "鮮萃大麥紅茶",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "以阿薩姆紅茶與大麥煎焙炒香製成、口感溫潤、風味迷人。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_88.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "海神",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "以清爽日式煎茶調製,採用蜂蜜醃製過的水果搭配茶葉烘製，具有水果香氣帶有淡淡蜜香的黃金茶湯如海波動，獨創茶的神話。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_4.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "玩火",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "日本靜岡甘甜的煎茶與產自春天高山上的清香烏龍茶，搭配百香果、芒果等熱帶水果風味烘製而成的黃金茶湯。喝的到水果香氣與淡淡蘭花香的獨家茶飲。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_93.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "碧螺春",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "中國十大名茶之一，屬於高級綠茶，使用獨特炒菁製茶工法的不發酵茶，所以茶色碧綠明澈，茶香清新高雅，茶滋味淡雅花果味，入喉甘甜沁然入心。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_56.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "四季春",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "因茶樹強韌耐寒四季皆可採收而得名。帶有烏龍茶韻味及獨樹一格百花香氣，入口回甘清香。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_57.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "玫瑰普洱",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "有美容茶之聲譽，嚴選優質普洱為基底，搭配玫瑰入味，調製成的時尚茶飲，茶湯烏潤成褐紅色，滋味醇厚回甘具獨特的陳香。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_97.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "烏龍綠茶",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "【100% 台灣茶】嚴選台南百年茶廠，遵循古法烘焙，茶湯略帶烘培味，滋味醉人回甘，餘韻不絕。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_2.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "茉莉烏龍",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "【100% 台灣茶】以臺灣南投清香烏龍為基底薰以茉莉花，文火的輕焙伴隨著具體而微的茉莉花香，清香甘醇，口感再升級。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_78.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "屋瓦紅茶",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "世界三大紅茶之一，茶色橙紅明亮，滋味醇厚帶點回甘。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_3.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "金萱茶",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "輕淡奶香茶味，味覺緩緩甦醒，享受溫潤甘甜的滋味。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_5.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "熟滄觀音",
                Price = "L 40",
                SizeM = "0",
                SizeL = "40",
                Introduction = "【100% 台灣茶】重發酵茶葉，擁有熟果香及熟火香的特性，製程需特別反覆進行焙揉，形成特別熟韻。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_69.png"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "文山包種",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "【100% 台灣茶】盛產於台灣北部的輕發酵烏龍茶，茶湯水色蜜綠帶金黃，以青心烏龍或大葉烏龍烘焙而成，滋味醇厚鮮爽，香氣輕揚。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_61.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "東方美人",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "【100% 台灣茶】熟果香與蜜糖香在橙紅明亮的茶湯，恣意張揚，濃厚香醇口感，叫人上癮。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_60.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "白桃蜜烏龍",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "用白桃的香甜氣味來彰顯烏龍茶原有的清爽，加入酸甜杏桃丁，給予茶葉與水果的雙重甘甜。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_48.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "洛神花蜜香紅茶",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "嚴選台灣洛神花，混搭風味蜜香紅茶，甜蜜的微酸口感。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_66.jpg"

            });
            ComebuyTea.Add(new Drink
            {
                Name = "桂花四季春",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "【只有加桂花蜜，無另外加糖，僅提供微糖以上】迷人桂花香與四季春清雅甘醇，花香入鼻與茶韻留喉，質地溫和且甘潤。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_82.jpg"

            });

        }

    }
}
