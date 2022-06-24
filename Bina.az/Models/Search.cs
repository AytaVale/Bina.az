using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class Search
    {
        public Search()
        {
            this.Region = new List<string>();
            this.VIP = new List<string>();
        }
        public Int64 SearchID { get; set; }
        public DateTime Date { get; set; }
        public List <string> Region { get; set; }
        public int MinPrice { get; set; }
        public int MaxPrice { get; set; }
        public List <string> VIP { get; set; }
    }
}
