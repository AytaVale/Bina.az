using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class About
    {
        public void AboutProperty()
        {
            Console.WriteLine("Emlakin novunu sechin: 1.menzil, 2.villa, 3.ofis, 4.qaraj, 5.torpaq sahesi.");
            int prop_character = int.Parse(Console.ReadLine());
            switch (prop_character)
            {
                case 1:
                    PropertyManager apartment = new PropertyManager();
                    apartment.WriteApartmentInfo();
                    break;
                case 2:
                    Villa villa = new Villa();
                    villa.SaleWithAgency();
                    villa.BuyWithAgency();
                    break;
                case 3:
                    Office ofis = new Office();
                    ofis.SaleWithAgency();
                    ofis.BuyWithAgency();
                    break;
                case 4:
                    Garage qaraj = new Garage();
                    qaraj.SaleWithAgency();
                    qaraj.BuyWithAgency();
                    break;
                case 5:
                    LandPlot torpaq = new LandPlot();
                    torpaq.SaleWithAgency();
                    torpaq.BuyWithAgency();
                    break;
                default:
                    Console.WriteLine("Melumatlar sehvdir!");
                    break;
            }
        }
    }
}
