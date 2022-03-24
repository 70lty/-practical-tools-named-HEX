using Auth.GG_Example;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace AuthGG
{
    class Program
    {
        static void Main(string[] args)
        {

            //This connects your file to the Auth.GG API, and sends back your application settings and such
            OnProgramStart.Initialize("Hex login", "681234", "V2ITavcJXIe4Hczg8Of7bNWPuL3udUi8dXa", "1.0");
            if(ApplicationSettings.Freemode)
            {
                //Usually when your application doesn't need a login and has freemode enabled you put the code here you want to do
                MessageBox.Show("Freemode is active, bypassing login!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Information);
            }
            if (!ApplicationSettings.Status)
            {
                //If application is disabled in your web-panel settings this action will occur
                MessageBox.Show("Application is disabled!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Error);
                Process.GetCurrentProcess().Kill(); // closes the application
            }
            PrintLogo();
            Console.WriteLine("[1] Register");
            Console.WriteLine("[2] Login");
            string option = Console.ReadLine();
            if (option == "1")
            {
                if (!ApplicationSettings.Register)
                {
                    //Register is disabled in application settings, will show a messagebox that it is not enabled
                    MessageBox.Show("Register is not enabled, please try again later!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Error);
                    Process.GetCurrentProcess().Kill(); //closes the application
                }
                else
                {
                    Console.Clear();
                    PrintLogo();
                    Console.WriteLine();
                    Console.WriteLine("Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Password:");
                    string password = Console.ReadLine();
                    Console.WriteLine("Email:");
                    string email = Console.ReadLine();
                    Console.WriteLine("License:");
                    string license = Console.ReadLine();
                    if (API.Register(username, password, email, license))
                    {
                        MessageBox.Show("You have successfully registered!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Information);
                        // Do code of what you want after successful register here!
                    }
                }
            }
            else if (option == "2")
            {
                if (!ApplicationSettings.Login)
                {
                    //Register is disabled in application settings, will show a messagebox that it is not enabled
                    MessageBox.Show("Login is not enabled, please try again later!", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Error);
                    Process.GetCurrentProcess().Kill(); //closes the application
                }
                else
                {
                    Console.Clear();
                    PrintLogo();
                    Console.WriteLine();
                    Console.WriteLine("Username:");
                    string username = Console.ReadLine();
                    Console.WriteLine("Password:");
                    string password = Console.ReadLine();
                    if (API.Login(username, password))
                    {
                        MessageBox.Show("Login successfully", OnProgramStart.Name, MessageBoxButton.OK, MessageBoxImage.Information);
                        Console.Clear();
                        PrintLogo();
                        // Success login stuff goes here
                        Console.ForegroundColor = ConsoleColor.White;
                        API.Log(username, "Logged in!"); //Logs this action to your web-panel, you can do this anywhere and for anything!
                        Console.WriteLine("***************************************************");
                        Console.WriteLine("Do you want download launcher ? (1) ");
                        Console.WriteLine("***************************************************");

                        string optionn = Console.ReadLine();
                        {
                            if (optionn == "1") ;
                            Console.Clear();
                            Console.WriteLine("Module 1/8 download ");
                            bat.Launcher();
                            Spoof.SpoofC();
                            Console.WriteLine("Module 2/8 download ");
                            bat2.Launcher2();
                            SpoofD.Spoof();
                            Console.WriteLine("Module 3/8 download ");
                            bat3.Launcher3();
                            SpoofF.Spoof();
                            Console.WriteLine("Module 4/8 download ");
                            Phyton.dl();
                            Console.WriteLine("Module 5/8 download ");
                            Python2.dl2();
                            Console.WriteLine("Module 6/8 download ");
                            Python3.dl3();
                            Console.WriteLine("Module 7/8 download ");
                            Dl.Launcher();
                            Console.WriteLine("Module 8/8 download ");
                        }
                    }
                }
            }
        }
        public static void PrintLogo()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("                               ##     ## ######## ##     ##  ");
            Console.WriteLine("                               ##     ## ##        ##   ##  ");
            Console.WriteLine("                               ##     ## ##         ## ## ");
            Console.WriteLine("                               ######### ######      ### ");
            Console.WriteLine("                               ##     ## ##         ## ##  ");
            Console.WriteLine("                               ##     ## ##        ##   ##  ");
            Console.WriteLine("                               ##     ## ##       ##     ## ");
            Console.WriteLine("                               ##     ## ######## ##      ##");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}                