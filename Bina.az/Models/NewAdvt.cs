using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class NewAdvt : Property
    {
        public NewAdvt()
        {
            this.PhoneNum = new List<string>();
        }
        public Int64 AdmanID { get; set; }
        public string Name { get; set; }
        public List <string> PhoneNum { get; set; }
        public string Email { get; set; }
        public string Location { get; set; }
        public string Description { get; set; }

        public override void Rent()
        {
            throw new NotImplementedException();
        }

        public override void Sale()
        {
            throw new NotImplementedException();
        }
    }
}
