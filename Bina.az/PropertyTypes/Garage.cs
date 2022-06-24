using Bina.az.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    class Garage : Category, IWithAgency
    {
        public void BuyWithAgency()
        {
            Console.WriteLine("Agentliye odenilecek faiz menzil alish qiymetinin 2% teskil edir. ");
        }
        public void SaleWithAgency()
        {
            Console.WriteLine("Agentliye odenilecek faiz menzil satish qiymetinin 1% teskil edir. ");
        }
    }
}
