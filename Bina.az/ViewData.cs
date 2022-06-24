using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class ViewData
    { 
        public static List <NewAdvt> NewAdvts { get; set; }
        public static List <Search> Searches { get; set; }
        static ViewData()
        {
            NewAdvts = new List<NewAdvt>();
            Searches = new List<Search>();
        }
    }
}
