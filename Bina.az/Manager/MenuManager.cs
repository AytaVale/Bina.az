using Bina.az.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Bina.az
{
    public class MenuManager
    {
        public void Menu()
        {
            Console.Write("1.Girish et;  ");
            Console.Write("2.Yeni elan; ");
            Console.Write("3.Axtar;  "); ;
            int choisee = int.Parse(Console.ReadLine());
            switch (choisee)
            {
                case 1:
                    LoginManager loginManager = new LoginManager();
                    loginManager.LoginWith();
                    break;
                case 2:
                    PropertyManager propertyManager = new PropertyManager();
                    propertyManager.WriteCategoryInfo();
                    break;
                case 3:
                    SearchManager searchManager = new SearchManager();
                    searchManager.WriteSearchInfo();
                    break;
                default:
                    Console.WriteLine("Melumatlar sehvdir!");
                    break;
            }
        }
    }
}