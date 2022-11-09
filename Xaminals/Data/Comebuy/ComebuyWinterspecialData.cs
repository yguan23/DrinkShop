using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class ComebuyWinterspecialData
    {
        public static IList<Drink> ComebuyWinterspecial { get; private set; }
        static ComebuyWinterspecialData()
        {
            ComebuyWinterspecial = new List<Drink>();
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "桂圓紅棗",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "【溫飲或熱飲｜甜度固定】桂圓與紅棗的香甜搭配，冬天飲用的絕佳溫暖飲品。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_41.jpg"
            });
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "暖薑茶",
                Price = "L 50",
                SizeM = "0",
                SizeL = "50",
                Introduction = "【溫飲或熱飲｜甜度固定】道地薑母製成的養生飲品，微辣口感，可以馬上溫暖身體。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_39.jpg"
            });
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "暖薑奶茶",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                Introduction = "【溫飲或熱飲｜甜度固定】薑母配上濃郁奶茶製成的溫暖飲品，薑汁飲品的新選擇。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_40.jpg"
            });
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "熱檸茶",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "新鮮檸檬原汁配上錫蘭紅茶/茉莉綠茶",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_87.png"
            });
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "熱桔茶",
                Price = "M 50/L 55",
                SizeM = "50",
                SizeL = "55",
                Introduction = "新鮮金桔原汁，豐富維他命C，熱熱喝有潤喉感。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_86.png"
            });
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "紫米奶茶",
                Price = "M 60/L 65",
                SizeM = "60",
                SizeL = "65",
                Introduction = "紫米富含花青素、維生素B1、維生素B3、鈣、磷、鐵、鎂、鋅等礦物質，還含有人體必需胺基酸等超強營養成分，搭配香濃的奶茶，讓人有超級大確幸的飲品。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_44.jpg"
            });
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "紫米可可",
                Price = "M 65/L 70",
                SizeM = "65",
                SizeL = "70",
                Introduction = "紫米富含花青素、維生素B1、維生素B3、鈣、磷、鐵、鎂、鋅等礦物質，還含有人體必需胺基酸等超強營養成分，搭配香濃的巧克力，讓人有超級幸福感的飲品。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_43.jpg"
            });
            ComebuyWinterspecial.Add(new Drink
            {
                Name = "黑糖薑汁可可",
                Price = "L 65",
                SizeM = "0",
                SizeL = "65",
                Introduction = "【溫飲或熱飲｜甜度固定】薑母配上五星級餐廳專用的巧克力製成的溫暖飲品，薑汁飲品的新選擇。",
                ImageUrl = "https://foodtracer.taipei.gov.tw/Backend/upload/product/24483673/24483673_42.jpg"
            });

        }
    }
}
