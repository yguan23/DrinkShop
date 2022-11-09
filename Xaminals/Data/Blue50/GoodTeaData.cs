using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class GoodTeaData
    {
        public static IList<Drink> GoodTea { get; private set; }
        static GoodTeaData()
        {
            GoodTea = new List<Drink>();

            GoodTea.Add(new Drink
            {
                Name = "茉莉綠茶",
                Introduction = "中杯：總糖量28公克、總熱量119大卡, 大杯：總糖量40公克、總熱量170大卡",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_27.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 (中杯 +5 、大杯+10)
            //布丁、香草冰淇淋、奶霜 (中杯 +15 、大杯+20)
            GoodTea.Add(new Drink
            {
                Name = "阿薩姆紅茶",
                Introduction = "中杯：總糖量28公克、總熱量119大卡, 大杯：總糖量40公克、總熱量170大卡",
                Price = "M 30 / L 35",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_2.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            // 珍珠、波霸、椰果、真波椰、混珠(中杯 + 5 、大杯 + 10)
            //布丁、香草冰淇淋、奶霜 (中杯 +15 、大杯+20)
            GoodTea.Add(new Drink
            {
                Name = "四季春青茶",
                Introduction = "中杯：總糖量28公克、總熱量119大卡, 大杯：總糖量40公克、總熱量170大卡",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_28.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            // 珍珠、波霸、椰果、真波椰、混珠(中杯 + 5 、大杯 + 10)
            //布丁、香草冰淇淋、奶霜 (中杯 +15 、大杯+20)
            GoodTea.Add(new Drink
            {
                Name = "黃金烏龍",
                Introduction = "中杯：總糖量28公克、總熱量119大卡, 大杯：總糖量40公克、總熱量170大卡",
                Price = "M 30 / L 35",
                SizeM = "30",
                SizeL = "35",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_18.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            // 珍珠、波霸、椰果、真波椰、混珠(中杯 + 5 、大杯 + 10)
            //布丁、香草冰淇淋、奶霜 (中杯 +15 、大杯+20)
            GoodTea.Add(new Drink
            {
                Name = "檸檬綠",
                Introduction = "中杯：總糖量34公克、總熱量154大卡, 大杯：總糖量48公克、總熱量217大卡",
                Price = "M 45/ L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_19.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            GoodTea.Add(new Drink
            {
                Name = "梅の綠",
                Introduction = " 中杯：總糖量65公克、總熱量276大卡, 大杯：總糖量93公克、總熱量395大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_30.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            GoodTea.Add(new Drink
            {
                Name = "8冰綠",
                Introduction = "中杯：總糖量42公克、總熱量186大卡, 大杯：總糖量61公克、總熱量267大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_33.png"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            GoodTea.Add(new Drink
            {
                Name = "養樂多綠",
                Introduction = "中杯：總糖量53公克、總熱量230大卡, 大杯：總糖量73公克、總熱量318大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_34.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            GoodTea.Add(new Drink
            {
                Name = "冰淇淋紅茶",
                Introduction = "中杯：總糖量39公克、總熱量244大卡, 大杯：總糖量54公克、總熱量330大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_16.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            GoodTea.Add(new Drink
            {
                Name = "旺來紅",
                Introduction = "中杯：總糖量53公克、總熱量228大卡, 大杯：總糖量75公克、總熱量326大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_2.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            GoodTea.Add(new Drink
            {
                Name = "鮮柚綠",
                Introduction = "中杯：總糖量42公克、總熱量234大卡, 大杯：總糖量59公克、總熱量328大卡",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_36.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
        }
    }
}
