using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bina.az.Interface;

namespace Bina.az
{
    class NewBuilding : Category, IBillofSale, IRent, IWithMortgage, IWithAgency
    {
        public void BuyWithAgency()
        {
            Console.WriteLine("Agentliye odenilecek faiz menzil satish qiymetinin 2% teskil edir. ");
        }

        public void DailyRent()
        {
            Console.WriteLine("Neche otaqli menzil isteyirsiniz?");
            string roomCount = Console.ReadLine();
            if (roomCount.ToLower() == RoomCountForDaily.Bir.ToString())
            {
                this.Price = (int)RoomCountForDaily.Bir;
            }
            else if (roomCount.ToLower() == RoomCountForDaily.Iki.ToString())
            {
                this.Price = (int)RoomCountForDaily.Iki;
            }
            else if (roomCount.ToLower() == RoomCountForDaily.Uc.ToString())
            {
                this.Price = (int)RoomCountForDaily.Uc;
            }
            else if (roomCount.ToLower() == RoomCountForDaily.Dord.ToString())
            {
                this.Price = (int)RoomCountForDaily.Dord;
            }
            else
            {
                Console.WriteLine("Axtardiginiz parametrlere uygun menzil tapilmadi.");
            }
            Console.WriteLine("Menzilin gunluk kiraye qiymeti: " + this.Price);
        }

        public void MonthlyRent()
        {
            Console.WriteLine("Neche otaqli menzil isteyirsiniz?");
            string roomCount = Console.ReadLine();
            if (roomCount.ToLower() == RoomCountForMonthly.Bir.ToString())
            {
                this.Price = (int)RoomCountForMonthly.Bir;
            }
            else if (roomCount.ToLower() == RoomCountForMonthly.Iki.ToString())
            {
                this.Price = (int)RoomCountForMonthly.Iki;
            }
            else if (roomCount.ToLower() == RoomCountForMonthly.Uc.ToString())
            {
                this.Price = (int)RoomCountForMonthly.Uc;
            }
            else if (roomCount.ToLower() == RoomCountForMonthly.Dord.ToString())
            {
                this.Price = (int)RoomCountForMonthly.Dord;
            }
            else
            {
                Console.WriteLine("Axtardiginiz parametrlere uygun menzil tapilmadi.");
            }
            Console.WriteLine("Menzilin ayliq kiraye qiymeti: " + this.Price);
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
