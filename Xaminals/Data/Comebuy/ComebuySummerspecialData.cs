using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ComebuySummerspecialData
    {
        public static IList<Drink> ComebuySummerspecial { get; private set; }
        static ComebuySummerspecialData()
        {
            ComebuySummerspecial = new List<Drink>();
            ComebuySummerspecial.Add(new Drink
            {
                Name = "檸檬愛玉",
                Price = "L 55",
                SizeM = "0",
                SizeL = "55",
                Introduction = "100%新鮮檸檬原汁加入愛玉凍，豐富的酸甜滑順口感，爽口好選擇。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_26.jpg"
            });
            ComebuySummerspecial.Add(new Drink
            {
                Name = "百香果冰沙",
                Price = "L 55",
                SizeM = "0",
                SizeL = "55",
                Introduction = "【冰量固定】百香果果汁調製成酸甜可口、清爽直逼破表的綿密冰沙。建議少糖以上。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_31.jpg"
            });
            ComebuySummerspecial.Add(new Drink
            {
                Name = "七巧歐蕾",
                Price = "L 70",
                SizeM = "0",
                SizeL = "70",
                Introduction = "【巧克力冰沙，冰量固定｜本產品含有花生、牛奶製品】七七乳加巧克力配上五星級可可調製成冰沙，可可本身無糖，建議少糖以上，口感香濃。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_52.jpg"
            });
            ComebuySummerspecial.Add(new Drink
            {
                Name = "金芒果優酪",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "嚴選台灣愛文芒果及道地土芒果雙芒組合，果肉橙黃柔軟細膩，搭配優質優酪乳好菌多多。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_77.jpg"
            });
            ComebuySummerspecial.Add(new Drink
            {
                Name = "葡萄柚綠茶",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【冰飲】新鮮葡萄柚汁配上黃金綠茶，含有豐富的兒茶素，是絕佳的抗氧化組合，(食用高血壓藥物者忌飲)。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_22.jpg"
            });
            ComebuySummerspecial.Add(new Drink
            {
                Name = "青檸香柚QQ ",
                Price = "L 75",
                SizeM = "0",
                SizeL = "75",
                Introduction = "【冰飲】天然葡萄柚與檸檬汁搭配蘆薈、寒天晶球，清爽零負擔，食用高血壓藥物者忌飲。｜!不建議經期、懷孕或哺乳期婦女、12歲以下孩童、腸胃不適、腹痛患者及腎臟病患者使用",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_30.jpg"
            });
        }
    }
}
