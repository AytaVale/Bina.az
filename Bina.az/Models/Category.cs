using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class Category : Property
    {
        public string Name { get; set; }
        public String Description { get; set; }

        public override void Rent()
        {
            throw new NotImplementedException();
        }

        public override void Sale()
        {
            throw new NotImplementedException();
        }
        public static void PrintInfo()
        {
            Category category = new Category();
            StringBuilder info = new StringBuilder();
            info.Append($"Adi + {category.Name} ");
            info.Append($"Unvani + {category.Address} ");
            info.Append($"Sahesi + {category.TotalArea} ");
            info.Append($"Emlak barede melumat + {category.Description} ");
        }
    }
}