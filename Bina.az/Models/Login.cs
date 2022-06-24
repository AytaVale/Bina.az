using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class Login
    {
        public string PhoneNumber { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }
        public string AgencyName { get; set; }
        public string PersonName { get; set; }
        public void SignIn()
        {
            Console.Write("E-mail: ");
            this.Mail = Console.ReadLine();
            bool isTrue = true;
            do
            {
                Console.Write("Shifre: ");
                this.Password = Console.ReadLine();
                if (this.Password.Length < 8)
                {
                    Console.WriteLine("Shifre 8 simvoldan az olmamalidir");
                }
                else
                {
                    isTrue = false;
                }
            } while (isTrue);
            
        }
        public void SignUp()
        {
            Console.Write("Shirketin adi: ");
            this.AgencyName = Console.ReadLine();
            Console.Write("Elaqedar shexs: ");
            this.PersonName = Console.ReadLine();
            Console.Write("E-mail: ");
            this.Mail = Console.ReadLine();
            bool isTrue = true;
            do
            {
                Console.Write("Shifre: ");
                this.Password = Console.ReadLine();
                if (this.Password.Length < 8)
                {
                    Console.WriteLine("Shifre 8 simvoldan az olmamalidir");
                }
                else
                {
                    isTrue = false;
                }
            } while (isTrue);
        }
    }
}
