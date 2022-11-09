using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class TasteData
    {
        public static IList<Drink> Taste { get; private set; }
        static TasteData()
        {
            Taste = new List<Drink>();

            Taste.Add(new Drink
            {
                Name = "四季春加珍波椰",
                Introduction = "中杯：總糖量32公克、總熱量372大卡, 大杯：總糖量46公克、總熱量532大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRxyi1qvgxcBUU-l5pATlOhYKeP3YwEhjiU3A&usqp=CAU"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "波霸紅茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_65.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "波霸綠茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_65.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "波霸青茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_65.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "波霸黃金烏龍茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_65.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "波霸奶茶",
                Introduction = "中杯：總糖量37公克、總熱量480大卡, 大杯：總糖量53公克、總熱量678大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_43.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "波霸奶綠",
                Introduction = "中杯：總糖量37公克、總熱量480大卡, 大杯：總糖量53公克、總熱量678大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_44.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "波霸烏龍奶茶",
                Introduction = "中杯：總糖量37公克、總熱量480大卡, 大杯：總糖量53公克、總熱量678大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_65.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "珍珠紅茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_66.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "珍珠綠茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_66.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "珍珠青茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_66.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "珍珠黃金烏龍茶",
                Introduction = "中杯：總糖量35公克、總熱量299大卡, 大杯：總糖量49公克、總熱量424大卡",
                Price = "M 35 / L 45",
                SizeM = "35",
                SizeL = "45",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_66.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "珍珠奶茶",
                Introduction = "中杯：總糖量37公克、總熱量480大卡, 大杯：總糖量53公克、總熱量678大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_10.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "珍珠奶綠",
                Introduction = "中杯：總糖量37公克、總熱量480大卡, 大杯：總糖量53公克、總熱量678大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_46.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "珍珠烏龍奶茶",
                Introduction = "中杯：總糖量37公克、總熱量480大卡, 大杯：總糖量53公克、總熱量678大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_46.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "椰果奶茶",
                Introduction = "中杯：總糖量72公克、總熱量464大卡, 大杯：總糖量102公克、總熱量655大卡",
                Price = "M 45 / L 55",
                SizeM = "45",
                SizeL = "55",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_69.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋、奶霜 +10
            Taste.Add(new Drink
            {
                Name = "布丁奶茶",
                Introduction = "中杯：總糖量39公克、總熱量376大卡, 大杯：總糖量64公克、總熱量592大卡",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_49.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
            Taste.Add(new Drink
            {
                Name = "布丁奶綠",
                Introduction = "中杯：總糖量39公克、總熱量376大卡, 大杯：總糖量64公克、總熱量592大卡",
                Price = "M 55 / L 65",
                SizeM = "55",
                SizeL = "65",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/28722339/28722339_49.jpg"
            });
            //冰：去冰、微冰、少冰、標準冰、常溫、溫、熱
            //糖:無糖、微糖、半糖、少糖、9分甜、標準甜
            //珍珠、波霸、椰果、真波椰、混珠 +0
            //布丁、香草冰淇淋 +10
        }
    }
}
