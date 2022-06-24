using Bina.az.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    class PropertyManager
    {
        public void WriteCategoryInfo()
        {
            bool isContinue = true;
            do
            {
                try
                {
                    Category category1 = new Category();
                    Console.WriteLine("Emlakin adini daxil edin: ");
                    category1.Name = Console.ReadLine();
                    Console.WriteLine("Emlakin unvanini daxil edin: ");
                    category1.Address = Console.ReadLine();
                    Console.WriteLine("Emlakin umumi sahesini qeyd edin: ");
                    category1.TotalArea = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Emlak barede melumat gosterin: ");
                    category1.Description = Console.ReadLine();
                    isContinue = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Melumatlari duzgun daxil edin.");
                }
            } while (isContinue); 
        }
        public void WriteApartmentInfo()
            {
            try
            {
                Console.WriteLine("1-Alish, 2-satish yoxsa 3-kiraye? *reqem daxil edin");
                int item = int.Parse(Console.ReadLine());
                if (item == (int)ApartmentOperation.Kiraye)
                {
                    Console.WriteLine("Gunluk yoxsa ayliq?");
                    string rent = Console.ReadLine();
                    if (rent.ToLower() == "gunluk")
                    {
                        Apartment apartment = new Apartment();
                        apartment.DailyRent();
                    }
                    else if (rent.ToLower() == "ayliq")
                    {
                        Apartment apartment = new Apartment();
                        apartment.MonthlyRent();
                    }
                }
                else if (item == (int)ApartmentOperation.Satish)
                {
                    Apartment apartment = new Apartment();
                    apartment.SaleWithAgency();
                }
                else if (item == (int)ApartmentOperation.Alish)
                {
                    Apartment apartment = new Apartment();
                    apartment.BuyWithAgency();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Netice yoxdur. Zehmet olmasa melumatlari yoxlayin");
            }
         }
     }
 }