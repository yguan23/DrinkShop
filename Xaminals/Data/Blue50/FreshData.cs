using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class FreshData
    {
        public static IList<Drink> Fresh { get; private set; }
        static FreshData()
        {
            Fresh = new List<Drink>();

            Fresh.Add(new Drink
            {
                Name = "檸檬汁",
                Introduction = "中杯：總糖量34公克、總熱量161大卡, 大杯：總糖量48公克、總熱量228大卡",
                Price = "M 50 / L 60",
                SizeM = "50",
                SizeL = "60",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_24.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Fresh.Add(new Drink
            {
                Name = "金桔檸檬",
                Introduction = "中杯：總糖量34公克、總熱量161大卡, 大杯：總糖量48公克、總熱量228大卡",
                Price = "M 50 / L 60",
                SizeM = "50",
                SizeL = "60",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_51.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Fresh.Add(new Drink
            {
                Name = "檸檬梅汁",
                Introduction = "中杯：總糖量55公克、總熱量239大卡, 大杯：總糖量77公克、總熱量338大卡",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_25.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Fresh.Add(new Drink
            {
                Name = "檸檬養樂多",
                Introduction = "中杯：總糖量77公克、總熱量357大卡, 大杯：總糖量109公克、總熱量490大卡",
                Price = "M 60 / L 75",
                SizeM = "60",
                SizeL = "75",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_54.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Fresh.Add(new Drink
            {
                Name = "8冰茶",
                Introduction = "中杯：總糖量43公克、總熱量187大卡, 大杯：總糖量67公克、總熱量291大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_57.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Fresh.Add(new Drink
            {
                Name = "鮮柚汁",
                Introduction = "中杯：總糖量42公克、總熱量234大卡, 大杯：總糖量659公克、總熱量328大卡",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_58.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
        }
    }
}
