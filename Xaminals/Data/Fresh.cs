using System;
using System.Collections.Generic;
using System.Text;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class FreshData
    {
        public static IList<Drink> Blue50 { get; private set; }
        static FreshData()
        {
            Blue50 = new List<Drink>();

            Blue50.Add(new Drink
            {
                Name = "熟成紅茶",
                Introduce = "解炸物/燒烤肉類油膩，茶味濃郁帶果香",
                Price = "30",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/01-S%E7%86%9F%E6%88%90%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Blue50.Add(new Drink
            {
                Name = "麗春紅茶",
                Introduce = "去除海鮮羶腥，茶味較淡帶花香",
                Price = "30",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2020/12/%E8%83%AD%E8%84%82%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Blue50.Add(new Drink
            {
                Name = "太妃紅茶",
                Introduce = "咖啡與茶的神祕比例搭配",
                Price = "35",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/03-S%E5%A4%AA%E5%A6%83%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Blue50.Add(new Drink
            {
                Name = "胭脂紅茶",
                Introduce = "絲絨般的蜜桃果香",
                Price = "40",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2020/12/%E9%BA%97%E6%98%A5%E7%B4%85%E8%8C%B6-1.jpg"
            });

            Blue50.Add(new Drink
            {
                Name = "雪藏紅茶",
                Introduce = "冰淇淋與紅茶的綿綿情意",
                Price = "50",
                ImageUrl = "https://www.kebuke.com/wp-content/uploads/2021/01/11-S%E9%9B%AA%E8%97%8F%E7%B4%85%E8%8C%B6.jpg"
            });

        }
    }
}
