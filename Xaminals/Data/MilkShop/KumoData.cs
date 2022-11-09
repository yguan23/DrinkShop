using System.Collections.Generic;
using Xaminals.Models;

namespace Xaminals.Data
{
    public static class KumoData
    {
        public static IList<Drink> Kumo { get; private set; }

        static KumoData()
        {
            //KUMO雲奶霜
            Kumo = new List<Drink>();

            Kumo.Add(new Drink
            {
                Name = "KUMO紅茶",
                Introduction = "",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/upload/product_catalog/1908091309090000001.png"
            });

            Kumo.Add(new Drink
            {
                Name = "KUMO決明大麥",
                Introduction = "",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/upload/product_catalog/1908091309090000001.png"
            });

            Kumo.Add(new Drink
            {
                Name = "KUMO圓片清茶",
                Introduction = "",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/upload/product_catalog/1908091309090000001.png"
            }) ;

            Kumo.Add(new Drink
            {
                Name = "KUMO琥珀烏龍",
                Introduction = "",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/upload/product_catalog/1908091309090000001.png"
            });

            Kumo.Add(new Drink
            {
                Name = "KUMO茉莉綠茶",
                Introduction = "",
                Price = "L 60",
                SizeM = "0",
                SizeL = "60",
                ImageUrl = "https://www.milkshoptea.com/upload/product_catalog/1908091309090000001.png"
            });

        }
    }
}
