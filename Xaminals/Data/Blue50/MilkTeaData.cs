using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class MilkTeaData
    {
        public static IList<Drink> MilkTea { get; private set; }
        static MilkTeaData()
        {
            MilkTea = new List<Drink>();

            MilkTea.Add(new Drink
            {
                Name = "奶茶",
                Introduction = "中杯：總糖量32公克、總熱量372大卡, 大杯：總糖量46公克、總熱量532大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_8.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            MilkTea.Add(new Drink
            {
                Name = "奶綠",
                Introduction = "中杯：總糖量32公克、總熱量372大卡, 大杯：總糖量46公克、總熱量532大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_8.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            MilkTea.Add(new Drink
            {
                Name = "紅茶瑪奇朵",
                Introduction = "中杯：總糖量42公克、總熱量452大卡, 大杯：總糖量60公克、總熱量636大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_17.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            MilkTea.Add(new Drink
            {
                Name = "烏龍瑪奇朵",
                Introduction = "中杯：總糖量42公克、總熱量452大卡, 大杯：總糖量60公克、總熱量636大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_67.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            MilkTea.Add(new Drink
            {
                Name = "四季奶青",
                Introduction = "中杯：總糖量32公克、總熱量372大卡, 大杯：總糖量46公克、總熱量532大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_38.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            MilkTea.Add(new Drink
            {
                Name = "黃金烏龍奶茶",
                Introduction = "中杯：總糖量31公克、總熱量330大卡, 大杯：總糖量45公克、總熱量472大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_37.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            MilkTea.Add(new Drink
            {
                Name = "阿華田",
                Introduction = "中杯：總糖量33公克、總熱量359大卡, 大杯：總糖量47公克、總熱量512大卡",
                Price = "M 50 / L 60",
                SizeM = "50",
                SizeL = "60",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_40.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            MilkTea.Add(new Drink
            {
                Name = "可可芭蕾",
                Introduction = "中杯：總糖量28公克、總熱量290大卡, 大杯：總糖量40公克、總熱量414大卡",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_41.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            MilkTea.Add(new Drink
            {
                Name = "紅茶拿鐵",
                Introduction = "中杯：總糖量36公克、總熱量235大卡, 大杯：總糖量51公克、總熱量334大卡",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_15.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            MilkTea.Add(new Drink
            {
                Name = "阿華田拿鐵：",
                Introduction = "中杯：總糖量38公克、總熱量301大卡, 大杯：總糖量54公克、總熱量428大卡",
                Price = "M 60 / L 75",
                SizeM = "60",
                SizeL = "75",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_63.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10

        }
    }
}