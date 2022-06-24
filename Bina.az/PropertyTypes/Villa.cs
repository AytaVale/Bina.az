using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bina.az.Interface;

namespace Bina.az
{
    class Villa : Category, IBillofSale, IRent, IWithMortgage, IWithAgency
    {
        public void BuyWithAgency()
        {
            Console.WriteLine("Agentliye odenilecek faiz menzil alish qiymetinin 2% teskil edir. ");
        }

        public void DailyRent()
        {
            throw new NotImplementedException();
        }

        public void MonthlyRent()
        {
            throw new NotImplementedException();
        }

        public void RentWithBill()
        {
            throw new NotImplementedException();
        }

        public void RentWithoutBill()
        {
            throw new NotImplementedException();
        }

        public void SaleWithAgency()
        {
            Console.WriteLine("Agentliye odenilecek faiz menzil satish qiymetinin 1% teskil edir. ");
        }

        public void SaleWithBill()
        {
            throw new NotImplementedException();
        }

        public void SaleWithMortgage()
        {
            throw new NotImplementedException();
        }

        public void SaleWithoutBill()
        {
            throw new NotImplementedException();
        }
    }
}
