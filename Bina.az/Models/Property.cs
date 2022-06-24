using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public abstract class Property
    {
        public string Id { get; set; }
        public string TypeId { get; set; }
        public double TotalArea { get; set; }
        public string Address { get; set; }
        public int Price { get; set; }

        public abstract void Sale();
        public abstract void Rent();
    }
}
