using Bina.az.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bina.az
{
    public class LoginManager
    {
        public void LoginWith()
        {
            Console.WriteLine("Girish novunu sechin: 1: Girish et, 2: Qeydiyyat");
            int login = int.Parse(Console.ReadLine());
            if (login == (int)LoginType.girish)
            {
                Login login1 = new Login();
                login1.SignIn();
            }
            else if (login == (int)LoginType.qeydiyyat)
            {
                Login login1 = new Login();
                login1.SignUp();
            }
        }
    }
}
