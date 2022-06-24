using System;

namespace Bina.az
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinueOrNot = true;
            MenuManager manageProgram = new MenuManager();
            manageProgram.Menu();
            About about = new About();
            about.AboutProperty();
            do
            {
                Console.WriteLine("Devam etmek isteyirsinizmi? He/Yox");
                string answer = Console.ReadLine();
                if (answer.ToLower() == "he")
                {
                    about.AboutProperty();
                }
                else
                {
                    ContinueOrNot = false;
                }

            } while (ContinueOrNot);
        }
    }
}