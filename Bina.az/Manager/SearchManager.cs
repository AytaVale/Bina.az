using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class SearchManager
    {
        public void WriteSearchInfo()
        {
            Search search1 = new Search();
            Console.WriteLine("Hansi tarixde olan elan ile maraqlanirsiniz?  *yyyy.mm.dd.");
            search1.Date = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Rayon elave edin ");
            string response = string.Empty;
            do
            {
                string district = Console.ReadLine();
                search1.Region.Add(district);
                Console.WriteLine("Bashqa rayon elave etmek isteyirsinizmi? He/Yox");
                response = Console.ReadLine();
            } while (response.ToLower() == "he");

            foreach (var item in ViewData.Searches)
            {
                Console.WriteLine($"Elanin yerleshdirme tarixi: {item.Date}, Rayon: {item.Region} ");
            }
        }
    }
}
